using LiveCharts;
using LiveCharts.Wpf;
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

namespace _POS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }



        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            btnDashboard.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            pagesMainMenu.SetPage(1);
            

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (btnDashboard.onHoverState.FillColor == Color.FromArgb(105, 181, 255))
            {
                btnDashboard.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            }
            pagesMainMenu.SetPage(0);
            btnProducts.Invalidate();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            btnSales.BackColor1 = Color.FromArgb(105, 181, 255);
            pagesMainMenu.SetPage(2);
            btnProducts.Invalidate();
        }

        private void btnPeoples_Click(object sender, EventArgs e)
        {
            btnPeoples.BackColor1 = Color.FromArgb(105, 181, 255);
            pagesMainMenu.SetPage(3);
            btnProducts.Invalidate();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            btnReports.BackColor1 = Color.FromArgb(105, 181, 255);
            pagesMainMenu.SetPage(4);
            btnProducts.Invalidate();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.BackColor1 = Color.FromArgb(105, 181, 255);
            pagesMainMenu.SetPage(5);
            btnProducts.Invalidate();
        }

        private void tabPageSettings_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chartSales.Series[0].Points.AddXY("Jan-Feb", "100");
            chartSales.Series[0].Points.AddXY("Mar-Apr", "8000");
            chartSales.Series[0].Points.AddXY("May-Jun", "7000");
            chartSales.Series[0].Points.AddXY("Jul-Aug", "10000");
            chartSales.Series[0].Points.AddXY("Sep-Oct", "8500");
            chartSales.Series["Sales"].Points.AddXY("Nov-Dec", "8500");


            chartSales.Series[1].Points.AddY("1000");
            chartSales.Series[1].Points.AddY("8000");
            chartSales.Series[1].Points.AddY("7000");
            chartSales.Series[1].Points.AddY("10000");
            chartSales.Series[1].Points.AddY("8500");
            chartSales.Series[1].Points.AddY("8500");
            //chart title  
            chartSales.Titles.Add("This Year Sales & Purchases");
        }

        private void fillPieChart()
        {
            Random rnd = new Random();
            LiveCharts.SeriesCollection sers = new LiveCharts.SeriesCollection();
            for(int i = 0; i < 5; i++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rnd.NextDouble(), 2) };
                ser.Title = "Sales" + (i + 1).ToString();
                ser.DataLabels = true;
                sers.Add(ser);
            }
            pChartSales.Series = sers;
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            fillChart();
            fillPieChart();
        }

      
       

      
        private void bunifuGradientPanel1_MouseHover(object sender, EventArgs e)
        {
            imageBtnTodaySales.ZoomIn();
        }

        private void bunifuGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            imageBtnTodaySales.ZoomOut();
        }

        private void bunifuGradientPanel2_MouseHover(object sender, EventArgs e)
        {
            imageBtnLastSales.ZoomIn();
        }

        private void bunifuGradientPanel2_MouseLeave(object sender, EventArgs e)
        {
            imageBtnLastSales.ZoomOut();
        }

        private void bunifuGradientPanel3_MouseHover(object sender, EventArgs e)
        {
            imageBtnTotalSales.ZoomIn();
        }

        private void bunifuGradientPanel3_MouseLeave(object sender, EventArgs e)
        {
            imageBtnTotalSales.ZoomOut();
        }

        private void bunifuGradientPanel7_MouseHover(object sender, EventArgs e)
        {
            imageBtnRecentSales.ZoomIn();
        }

        private void bunifuGradientPanel7_MouseLeave(object sender, EventArgs e)
        {
            imageBtnRecentSales.ZoomOut();
        }
    }
}
