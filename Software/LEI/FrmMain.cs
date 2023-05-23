using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LEICore.Objects;
using LEICore.Users;


namespace LEI
{
    public partial class FrmMain : Form
    {
        User user = new User();
        Chart chartWater = new Chart();

        public FrmMain(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() {
            List<LEICore.Objects.Object> objlist = new List<LEICore.Objects.Object>();
            ObjectRepository objectRepository = new ObjectRepository();

            objlist = objectRepository.GetObjects(user.Id);

            if (objlist != null && objlist.Count > 0)
            {
                dvgObjects.DataSource = objlist;
                dvgObjects.Columns["Name"].DisplayIndex = 0;
                dvgObjects.Columns["City"].DisplayIndex = 1;
                dvgObjects.Columns["Street"].DisplayIndex = 2;
                dvgObjects.Columns["ObjectType"].DisplayIndex = 3;
                //dvgObjects.Columns["SensorID"].Visible = false;
                //dvgObjects.Columns["UserID"].Visible = false;

                Chart myChart = new Chart();
                myChart.Series.Add("Data");
                myChart.Series["Data"].Points.AddXY(0, 2);
                myChart.Series["Data"].Points.AddXY(1, 5);
                myChart.Series["Data"].Points.AddXY(2, 6);
                myChart.Series["Data"].ChartType = SeriesChartType.Line;


                this.Controls.Add(myChart);
            }
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
    }
}
