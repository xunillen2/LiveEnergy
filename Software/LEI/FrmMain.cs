﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LEICore.Consumption;
using LEICore.Objects;
using LEICore.Users;


namespace LEI
{
    /// <summary>
    /// Main form.
    /// Displays all avilable objects and options to users.
    /// It updates every 20s to display current Consumptions of
    /// all users object.
    /// For live update of consumption to work, LESensors needs to be running.
    /// </summary>
    public partial class LiveEnergy : Form
    {
        User user = new User();
        Chart chartWater = new Chart();
        List<LEICore.Objects.Object> objlist = new List<LEICore.Objects.Object>();
        static Timer reloadTimer = new Timer();


        public LiveEnergy(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Disable non admin stuff
            if (!user.IsAdmin())
            {
                btnAddRemoveObj.Enabled = false;
                //btnSensors.Enabled= false;
            }

            SetUsername();
            LoadData();
            SetElementStyles();

            // Setup timer
            // Data is reloaded on every Tick by calling LoadData.
            reloadTimer.Tick += new EventHandler(RealodTimerEventObject);

            reloadTimer.Interval = 15000;
            reloadTimer.Start();
        }

        /// <summary>
        /// Loads All data.
        /// Populates Dvg with all items (Objects)
        /// And refreshes labels with proper Consumption text.
        /// </summary>
        private void LoadData() {
            LoadDvgObjects();
            LoadConsumptionLabels();
        }

        private void LoadDvgObjects() {
            ObjectRepository objectRepository = new ObjectRepository();

            // If user is admin, get all objects.
            if (!user.IsAdmin())
                objlist = objectRepository.GetObjects(user.Id);
            else
                objlist = objectRepository.GetObjects();

            if (objlist != null && objlist.Count > 0)
            {
                /* Sets Columns idexes, header text and hides
                 * Columns that are not needed in this Form.
                 */
                dvgObjects.DataSource = objlist;
                dvgObjects.Columns["Name"].DisplayIndex = 0;
                dvgObjects.Columns["City"].DisplayIndex = 1;
                dvgObjects.Columns["Street"].DisplayIndex = 2;
                dvgObjects.Columns["ObjectType"].DisplayIndex = 3;

                dvgObjects.Columns["Name"].HeaderText = "Ime";
                dvgObjects.Columns["City"].HeaderText = "Grad";
                dvgObjects.Columns["Street"].HeaderText = "Ulica";
                dvgObjects.Columns["ObjectType"].HeaderText = "Tip Objekta";

                dvgObjects.Columns["Sensor"].Visible = false;
                dvgObjects.Columns["User"].Visible = false;
                dvgObjects.Columns["Id"].Visible = false;
                dvgObjects.Columns["PredictedConsumption"].Visible = false;
            }
        }

        /// <summary>
        /// Refreshes text on Consumption labels by going through avilable Objects.
        /// </summary>
        private void LoadConsumptionLabels() {
            float waterconsumption, gasconsumption, electryconsumption;
            ConsumptionRepository consumptionRepository = new ConsumptionRepository();
            List<ConsumptionData> consumptionData = new List<ConsumptionData>();
            DateTime timenow = DateTime.Now;

            waterconsumption = gasconsumption = electryconsumption = 0;

            // Go through all loaded object that user has access, see if date is right (to minute),
            // compare consumptionType and add it to temporary var.
            foreach (LEICore.Objects.Object obj in objlist)
            {
                consumptionData = consumptionRepository.GetConsumptionsByObject(obj.Id, false);
                if (consumptionData != null) {
                    foreach (ConsumptionData cdata in consumptionData) {
                        if (cdata.Date.Year == timenow.Year && cdata.Date.Month == timenow.Month &&
                            cdata.Date.Day == timenow.Day && cdata.Date.Minute == timenow.Minute)
                        {
                            if (cdata.ConsumptionType == ConsumptionData.consumptionType.Water)
                                waterconsumption += cdata.ConsumptionValue;
                            else if (cdata.ConsumptionType == ConsumptionData.consumptionType.Gas)
                                gasconsumption += cdata.ConsumptionValue;
                            else if (cdata.ConsumptionType == ConsumptionData.consumptionType.Electricity)
                                electryconsumption += cdata.ConsumptionValue;
                        }
                    }
                }
            }

            // Display Calculated Consumption
            lblWaterConsumption.Text = waterconsumption.ToString() + " L/s";
            lblGasConsumption.Text = gasconsumption.ToString() + " L/s";
            lblElectrConsumption.Text = electryconsumption.ToString() + "kWh";
        }

        void SetUsername() { 
            lblUsername.Text = user.FirstName + " " + user.LastName;
        }

        void SetElementStyles() {
            if (dvgObjects.DataSource != null)
            {
                dvgObjects.Columns["ObjectType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dvgObjects.EnableHeadersVisualStyles = true;
            }
        }

        private void RealodTimerEventObject 
            (System.Object myObject, EventArgs myEventArgs) {
            LoadData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRemoveObj_Click(object sender, EventArgs e)
        {
            FrmObjControl Frmobj = new FrmObjControl(user);
            Frmobj.ShowDialog();
        }

        private void dvgObjects_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmObjInfo frminfo = new FrmObjInfo(objlist[e.RowIndex]);
            frminfo.ShowDialog();            
        }

    }
}
