using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            fillChart();
            fillPieChart();
        }

        #region Fill Charts
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
            List<string> months = new List<string>() {
            "Jan-Feb",
            "Mar-Apr",
            "May-Jun",
            "Jul-Aug",
            "Sep-Oct",
            "Nov-Dec"
            };


            Random rnd = new Random();
            LiveCharts.SeriesCollection sers = new LiveCharts.SeriesCollection();
            for (int i = 0; i < 6; i++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rnd.NextDouble(), 2) };
                ser.Title = months[i];
                ser.DataLabels = true;
                sers.Add(ser);
            }
            pChartSales.Series = sers;

        }
        #endregion
        #region Hover Animations Dashboard Buttons
        #region Today Sales Hover

        private void bunifuGradientPanel1_MouseHover(object sender, EventArgs e)
        {
            imageBtnTodaySales.ZoomIn();
            panelTodaySales.BackColor = Color.FromArgb(92, 173, 255);

        }

        private void bunifuGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            imageBtnTodaySales.ZoomOut();
            panelTodaySales.BackColor = Color.FromArgb(92, 173, 255);
        }
        #endregion
        #region Last Sales Hover
        private void bunifuGradientPanel2_MouseHover(object sender, EventArgs e)
        {
            imageBtnLastSales.ZoomIn();
            panelLastSales.BackColor = Color.FromArgb(92, 173, 255);

        }

        private void bunifuGradientPanel2_MouseLeave(object sender, EventArgs e)
        {
            imageBtnLastSales.ZoomOut();
            panelLastSales.BackColor = Color.FromArgb(92, 173, 255);
        }
        #endregion
        #region Total Sales Hover
        private void bunifuGradientPanel3_MouseHover(object sender, EventArgs e)
        {
            imageBtnTotalSales.ZoomIn();
            panelTotalSales.BackColor = Color.FromArgb(92, 173, 255);
        }

        private void bunifuGradientPanel3_MouseLeave(object sender, EventArgs e)
        {
            imageBtnTotalSales.ZoomOut();
            panelTotalSales.BackColor = Color.FromArgb(92, 173, 255);
        }
        #endregion
        #region Recent Sales Hover
        private void bunifuGradientPanel7_MouseHover(object sender, EventArgs e)
        {
            imageBtnRecentPurchase.ZoomIn();
            panelRecentPurchase.BackColor = Color.FromArgb(92, 173, 255);
        }

        private void bunifuGradientPanel7_MouseLeave(object sender, EventArgs e)
        {
            imageBtnRecentPurchase.ZoomOut();
            panelRecentPurchase.BackColor = Color.FromArgb(92, 173, 255);
        }
        #endregion
        #region Stock Hover
        private void panelStockonHand_MouseHover(object sender, EventArgs e)
        {
            imageBtnStock.ZoomIn();
            panelStockonHand.BackColor = Color.FromArgb(92, 173, 255);
        }

        private void panelStockonHand_MouseLeave(object sender, EventArgs e)
        {
            imageBtnStock.ZoomOut();
            panelStockonHand.BackColor = Color.FromArgb(92, 173, 255);
        }

        #endregion
        #region Critical Stocks Hover
        private void panelCriticalItems_MouseHover(object sender, EventArgs e)
        {
            imageBtnCriticalStock.ZoomIn();
            panelCriticalItems.BackColor = Color.FromArgb(92, 173, 255);
        }

        private void panelCriticalItems_MouseLeave(object sender, EventArgs e)
        {
            imageBtnCriticalStock.ZoomOut();
            panelCriticalItems.BackColor = Color.FromArgb(92, 173, 255);
        }
        #endregion
        #endregion 
    }
}
