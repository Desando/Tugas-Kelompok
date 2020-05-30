using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Kelompok_Pemvis
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            textJalan.Text = "Data persebaran Covid di Nganjuk pada tanggal 19 Mei 2020 berdasarkan data dari Covid19.nganjuk.go.id";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Rejoso' table. You can move, or remove it, as needed.
            this.rejosoTableAdapter.Fill(this.covid_NganjukDataSet.Rejoso);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Prambon' table. You can move, or remove it, as needed.
            this.prambonTableAdapter.Fill(this.covid_NganjukDataSet.Prambon);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Patianrowo' table. You can move, or remove it, as needed.
            this.patianrowoTableAdapter.Fill(this.covid_NganjukDataSet.Patianrowo);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Pace' table. You can move, or remove it, as needed.
            this.paceTableAdapter.Fill(this.covid_NganjukDataSet.Pace);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Ngronggot' table. You can move, or remove it, as needed.
            this.ngronggotTableAdapter.Fill(this.covid_NganjukDataSet.Ngronggot);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Nganjuk' table. You can move, or remove it, as needed.
            this.nganjukTableAdapter.Fill(this.covid_NganjukDataSet.Nganjuk);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Loceret' table. You can move, or remove it, as needed.
            this.loceretTableAdapter.Fill(this.covid_NganjukDataSet.Loceret);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Lengkong' table. You can move, or remove it, as needed.
            this.lengkongTableAdapter.Fill(this.covid_NganjukDataSet.Lengkong);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Kertosono' table. You can move, or remove it, as needed.
            this.kertosonoTableAdapter.Fill(this.covid_NganjukDataSet.Kertosono);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Jatikalen' table. You can move, or remove it, as needed.
            this.jatikalenTableAdapter.Fill(this.covid_NganjukDataSet.Jatikalen);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Gondang' table. You can move, or remove it, as needed.
            this.gondangTableAdapter.Fill(this.covid_NganjukDataSet.Gondang);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Berbek' table. You can move, or remove it, as needed.
            this.berbekTableAdapter.Fill(this.covid_NganjukDataSet.Berbek);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Baron' table. You can move, or remove it, as needed.
            this.baronTableAdapter.Fill(this.covid_NganjukDataSet.Baron);
            // TODO: This line of code loads data into the 'covid_NganjukDataSet.Bagor' table. You can move, or remove it, as needed.
            this.bagorTableAdapter.Fill(this.covid_NganjukDataSet.Bagor);

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gunaComboBox1.Text=="Bagor")
            {
                chartBatang.DataSource = bagorBindingSource;
                chartPie.DataSource = bagorBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers= "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Baron")
            {
                chartBatang.DataSource = baronBindingSource;
                chartPie.DataSource = baronBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Berbek")
            {
                chartBatang.DataSource = berbekBindingSource;
                chartPie.DataSource = berbekBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Gondang")
            {
                chartBatang.DataSource = gondangBindingSource;
                chartPie.DataSource = gondangBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Jatikalen")
            {
                chartBatang.DataSource = jatikalenBindingSource;
                chartPie.DataSource = jatikalenBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Kertosono")
            {
                chartBatang.DataSource = kertosonoBindingSource;
                chartPie.DataSource = kertosonoBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Lengkong")
            {
                chartBatang.DataSource = lengkongBindingSource;
                chartPie.DataSource = lengkongBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Loceret")
            {
                chartBatang.DataSource = loceretBindingSource;
                chartPie.DataSource = loceretBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Ngonggot")
            {
                chartBatang.DataSource = ngronggotBindingSource;
                chartPie.DataSource = ngronggotBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Pace")
            {
                chartBatang.DataSource = paceBindingSource;
                chartPie.DataSource = paceBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Patianrowo")
            {
                chartBatang.DataSource = patianrowoBindingSource;
                chartPie.DataSource = patianrowoBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Prambon")
            {
                chartBatang.DataSource = prambonBindingSource;
                chartPie.DataSource = prambonBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }
            else if (gunaComboBox1.Text == "Rejoso")
            {
                chartBatang.DataSource = rejosoBindingSource;
                chartPie.DataSource = rejosoBindingSource;
                chartBatang.Series["ODP"].YValueMembers = "ODP";
                chartBatang.Series["PDP"].YValueMembers = "PDP";
                chartBatang.Series["OTG"].YValueMembers = "OTG";
                chartPie.Series["Positif"].YValueMembers = "Positif";
                chartPie.Series["Sembuh"].YValueMembers = "Sembuh";
                chartBatang.DataBind();
                chartPie.DataBind();
            }

        }

        private void timertextjalan_Tick(object sender, EventArgs e)
        {
            if (textJalan.Left + textJalan.Width<=0)
            {
                textJalan.Left = textJalan.Width;
            }
            textJalan.Left = textJalan.Left - 10;

        }
    }
}
