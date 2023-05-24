﻿using LEICore.Consumption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEI
{
    public partial class FrmObjInfo : Form
    {
        LEICore.Objects.Object obj = new LEICore.Objects.Object();
        List<ConsumptionData> consumptionDataWater = new List<ConsumptionData>();
        List<ConsumptionData> consumptionDataGas = new List<ConsumptionData>();
        List<ConsumptionData> consumptionDataElectric = new List<ConsumptionData>();

        ConsumptionRepository consumptionRepository = new ConsumptionRepository();

        /// <summary>
        /// Opens Form for Viewing Object info and Consumption data.
        /// </summary>
        /// <param name="obj"></param>
        public FrmObjInfo(LEICore.Objects.Object obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void ObjInfo_Load(object sender, EventArgs e)
        {
            LoadLabels();
            LoadDvg();
            SetElementStyles();
        }

        /* Functions for setting up user interfaces */
        private void LoadLabels() {
            lblObjName.Text = obj.Name;
            lblCity.Text = obj.City;
            lblStreet.Text = obj.Street;
            lblOwner.Text = obj.User.FirstName + " " + obj.User.LastName;
        }
        void SetElementStyles()
        {
            dvgWater.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dvgWater.EnableHeadersVisualStyles = true;
            dvgGas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dvgGas.EnableHeadersVisualStyles = true;
            dvgElectric.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dvgElectric.EnableHeadersVisualStyles = true;
        }
        /// Populate all Dvgs with data. 
        private void LoadDvg() {
            consumptionDataWater =
                consumptionRepository.GetConsumptionsByObjAndType(obj.Id, ConsumptionData.consumptionType.Water, false);
            consumptionDataGas =
                consumptionRepository.GetConsumptionsByObjAndType(obj.Id, ConsumptionData.consumptionType.Gas, false);
            consumptionDataElectric =
                consumptionRepository.GetConsumptionsByObjAndType(obj.Id, ConsumptionData.consumptionType.Electricity, false);
            dvgWater.DataSource = consumptionDataWater;
            dvgGas.DataSource = consumptionDataGas;
            dvgElectric.DataSource = consumptionDataElectric;
            SetDvgLayout();
        }
        private void SetDvgLayout() {

            /* Seting table Visuals.
             Hidding uneeded Columns and setting Header Text */
            dvgWater.Columns [0].Visible = dvgGas.Columns [0].Visible = 
                dvgElectric.Columns [0].Visible = false;
            dvgWater.Columns [1].Visible = dvgGas.Columns [1].Visible =
                dvgElectric.Columns [1].Visible = false;
            dvgWater.Columns [3].Visible = dvgGas.Columns [3].Visible =
                dvgElectric.Columns [3].Visible = false;

            dvgWater.Columns [2].HeaderText = "Vrijednost potršnje (L)";
            dvgElectric.Columns [2].HeaderText = "Vrijednost potršnje (kWh)";
            dvgGas.Columns [2].HeaderText = "Vrijednost potršnje (L)";
            dvgWater.Columns [4].HeaderText = dvgGas.Columns [4].HeaderText =
                dvgElectric.Columns [4].HeaderText = "Datum/Vrijeme";
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            List<ConsumptionData> consumptionDataWaterFiltered = new List<ConsumptionData>();
            List<ConsumptionData> consumptionDataGasFiltered = new List<ConsumptionData>();
            List<ConsumptionData> consumptionDataElectricFiltered = new List<ConsumptionData>();

            // Go through current consumptionData's and match Dates.
            // If date matches, copy ConsumptionData to new filtered List.
            dvgWater.DataSource = null;
            foreach (ConsumptionData cdata in consumptionDataWater)
            {
                Debug.WriteLine(cdata.Date.Date.ToString() + " " + dateFilter.Value.Date.ToString());
                if (cdata.Date.Date == dateFilter.Value.Date)
                    consumptionDataWaterFiltered.Add(cdata);
            }
            foreach (ConsumptionData cdata in consumptionDataGas)
            {
                if (cdata.Date.Date == dateFilter.Value.Date)
                    consumptionDataGasFiltered.Add(cdata);
            }
            foreach (ConsumptionData cdata in consumptionDataElectric)
            {
                if (cdata.Date.Date == dateFilter.Value.Date)
                    consumptionDataElectricFiltered.Add(cdata);
            }

            // Set filtered Lists as data source
            dvgWater.DataSource = consumptionDataWaterFiltered;
            dvgGas.DataSource = consumptionDataGasFiltered;
            dvgElectric.DataSource = consumptionDataElectricFiltered;
            SetDvgLayout();
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            // Restore data source to origial Lists.
            dvgWater.DataSource = consumptionDataWater;
            dvgGas.DataSource = consumptionDataGas;
            dvgElectric.DataSource = consumptionDataElectric;
        }
    }
}
