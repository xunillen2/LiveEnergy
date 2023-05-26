using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEICore.Consumption;
using LEICore.Objects;
using LEICore.Sensors;
using LEICore.Users;

namespace LEI
{
    public partial class FrmObjAdd : Form
    {
        ObjectRepository objectRepository = new ObjectRepository();
        UserRepository userRepository = new UserRepository();
        SensorRepository sensorRepository = new SensorRepository();
        LEICore.Objects.Object objUpdating = new LEICore.Objects.Object();
        List<LEICore.Objects.Object> objectList = new List<LEICore.Objects.Object>();   // Temporary solution for getting used sensors.
                                                                                        // Send object list and get used sensors from that list.

        int id;
        bool isUpdating = false;
        int predictedConsumption;


        /// <summary>
        /// Opens Form for Adding Object to DB.
        /// Empty constructor.
        /// Used when Adding Object.
        /// </summary>
        public FrmObjAdd(List<LEICore.Objects.Object> objectList)
        {
            this.Text = "Dodavanje Objekta";
            this.objectList = objectList;
            InitializeComponent();
        }

        /// <summary>
        /// Sets Form for updating by seting isUpdating and objUpdating.
        /// </summary>
        /// <param name="obj"></param>
        public FrmObjAdd(LEICore.Objects.Object obj, List<LEICore.Objects.Object> objectList)
        {
            isUpdating = true;
            this.objUpdating = obj;
            this.objectList = objectList;
            this.Text = "Ažuriranje Objekta";
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Sensor sensor = (Sensor)cmbSensors.SelectedItem;
            User user = (User)cmbUsers.SelectedItem;

            // If validation fails, return
            if(!ValidateInput())
            {
                return;
            }

            // Create Object that will be saved to DB.
            LEICore.Objects.Object obj = new LEICore.Objects.Object
            {

                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                City = txtCity.Text,
                Street = txtStreet.Text,
                ObjectType = (objectType)cmboType.SelectedIndex,
                User = new User {
                    Id = user.Id
                },
                Sensor = new Sensor { 
                    Id = sensor.Id
                },
                PredictedConsumption = int.Parse(txtPredicted.Text)
            };

            if (!isUpdating)
            {
                if (objectRepository.InsertObject(obj) == 0)
                {
                    DisplayError("Greška prilikom dodavanja objekta u DB");
                }
            }
            else
            {
                if (objectRepository.UpdateObject(obj) == 0)
                {
                    DisplayError("Greška prilikom ažuriranja objekta unutar DBa");
                }
            }

            Close();
            
        }

        private bool ValidateInput() {
            if (txtCity.Text.Length > 50) {
                DisplayError("Ime grada ne smije biti veće od 50 znakova");
                return false;
            }
            else if (txtName.Text.Length > 50)
            {
                DisplayError("Ime Objekta ne smije biti veće od 40 znakova");
                return false;
            }
            else if (txtStreet.Text.Length > 50)
            {
                DisplayError("Ime Ulice ne smije biti veće od 40 znakova");
                return false;
            }
            // Try and parse inputed number. If it fails, return from function
            // and display error message.
            if (!int.TryParse(txtPredicted.Text, out predictedConsumption))
            {
                DisplayError("Unesen broj nije u valjanom formatu");
                return false;
            }
            return true;
        }

        private void FrmObjAdd_Load(object sender, EventArgs e)
        {

            LoadUsers();
            LoadSensors();
            if (!isUpdating)
                LoadId();
            else
                LoadObjInfo();  // If we are updating Object, populate all textboxes and elements
                                // with values of given object.
        }

        private void LoadObjInfo() {
            txtID.Text = objUpdating.Id.ToString();
            txtName.Text = objUpdating.Name;
            txtCity.Text = objUpdating.City;
            txtStreet.Text = objUpdating.Street;
            txtPredicted.Text = objUpdating.PredictedConsumption.ToString();
            cmbSensors.SelectedItem = objUpdating.Sensor;
            cmbUsers.SelectedItem = objUpdating.User;
            cmboType.SelectedIndex = (int) objUpdating.ObjectType;
        }


        // Sets Label TextBox to next avilable id.
        private void LoadId() {
            this.id = ++objectRepository.GetObjectMaxId().Id;
            txtID.Text = this.id.ToString();
        }

        private void LoadUsers() {
            List<User> users = userRepository.GetUsers();

            if (users != null)
            {
                cmbUsers.DataSource = users;
            }
        }
        private void LoadSensors()
        {
            List<Sensor> sensors = sensorRepository.GetSensors();
            List<Sensor> sensorsunused = new List<Sensor>();

            if (sensors != null && objectList != null)
            {
                // Temporary fix for geting used sensors.
                foreach (Sensor sensor in sensors)
                {
                    bool ishit = false;
                    foreach (LEICore.Objects.Object obj in objectList)
                    {
                        if (obj.Sensor.Id == sensor.Id)
                        {
                            ishit = true;
                            break;
                        }
                    }
                    if (!ishit)
                        sensorsunused.Add(sensor);
                }
                if(isUpdating)
                {
                    sensorsunused.Add(objUpdating.Sensor);
                }
                cmbSensors.DataSource = sensorsunused;
            }
        }

        private void DisplayError (string msg)
        {
            LblError.Text = msg;
            LblError.Visible = true;
        }
    }
}
