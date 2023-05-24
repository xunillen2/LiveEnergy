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

        int id;
        bool isUpdating = false;


        public FrmObjAdd()
        {
            this.Text = "Dodavanje Objekta";
            InitializeComponent();
        }
        public FrmObjAdd(LEICore.Objects.Object obj)
        {
            isUpdating = true;
            this.objUpdating = obj;
            this.Text = "Ažuriranje Objekta";
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Sensor sensor = (Sensor)cmbSensors.SelectedItem;
            User user = (User)cmbUsers.SelectedItem;

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
                objectRepository.InsertObject(obj);
            }
            else
            {
                objectRepository.UpdateObject(obj);
            }

            Close();
            
        }

        private void FrmObjAdd_Load(object sender, EventArgs e)
        {

            LoadUsers();
            LoadSensors();
            if (!isUpdating)
                LoadId();
            else
                LoadObjInfo();
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
            /*
            Id = this.id,
                Name = txtName.Text,
                City = txtCity.Text,
                Street = txtStreet.Text,
                ObjectType = (objectType)cmboType.SelectedIndex,
                User = new User
                {
                    Id = user.Id
                },
                Sensor = new Sensor
                {
                    Id = sensor.Id
                },
                PredictedConsumption = int.Parse(txtPredicted.Text)*/
        }

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

            if (sensors != null)
            {
                cmbSensors.DataSource = sensors;
            }
        }
    }
}
