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
    public partial class FrmMain : Form
    {
        User user = new User();
        Chart chartWater = new Chart();
        List<LEICore.Objects.Object> objlist = new List<LEICore.Objects.Object>();
        static Timer reloadTimer = new Timer();


        public FrmMain(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();
            reloadTimer.Tick += new EventHandler(RealodTimerEventObject);

            // Sets the timer interval to 15 seconds.
            reloadTimer.Interval = 15000;
            reloadTimer.Start();
        }

        private void LoadData() {
            LoadDvgObjects();
            LoadConsumptionLabels();
        }

        private void LoadDvgObjects() {
            ObjectRepository objectRepository = new ObjectRepository();

            objlist = objectRepository.GetObjects(user.Id);

            if (objlist != null && objlist.Count > 0)
            {
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

        private void LoadConsumptionLabels() {
            float waterconsumption, gasconsumption, electryconsumption;
            ConsumptionRepository consumptionRepository = new ConsumptionRepository();
            List<ConsumptionData> consumptionData = new List<ConsumptionData>();
            DateTime timenow = DateTime.Now;

            waterconsumption = gasconsumption = electryconsumption = 0;

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

            lblWaterConsumption.Text = waterconsumption.ToString() + " kWh";
            lblGasConsumption.Text = gasconsumption.ToString() + " L/s";
            lblElectrConsumption.Text = electryconsumption.ToString() + "";
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
