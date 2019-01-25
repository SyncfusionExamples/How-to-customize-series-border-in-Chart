using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ChartControl PieChart1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
        public Form1()
        {
            BindingList<PortfolioShareList> portfolioShareList = new BindingList<PortfolioShareList>();

            portfolioShareList.Add(new PortfolioShareList("1999", 3));

            portfolioShareList.Add(new PortfolioShareList("2000", 7));

            portfolioShareList.Add(new PortfolioShareList("2001", 12));

            portfolioShareList.Add(new PortfolioShareList("2002", 18));

            portfolioShareList.Add(new PortfolioShareList("2003", 22));

            PieChart1.Width = 800;
            PieChart1.Height = 400;

            this.PieChart1.PrimaryXAxis.ValueType = ChartValueType.Category;

            this.Controls.Add(PieChart1);

            CategoryAxisDataBindModel dataSeriesModelSharesChart = new CategoryAxisDataBindModel(portfolioShareList);
            dataSeriesModelSharesChart.CategoryName = "SymbolEn";
            dataSeriesModelSharesChart.YNames = new string[] { "AvailableShareCount" };
            ChartSeries chartSeries = new ChartSeries("AvailableShareCount", ChartSeriesType.Column);
            chartSeries.CategoryModel = dataSeriesModelSharesChart;
            chartSeries.Style.Interior = new BrushInfo(Color.Green);
            chartSeries.Style.Border.Width = 1;
            chartSeries.Style.Border.Color = Color.Transparent;
            this.PieChart1.Series.Clear();
            this.PieChart1.Series.Add(chartSeries);
            this.PieChart1.PrimaryXAxis.ValueType = ChartValueType.Category;

        }
        public class PortfolioShareList
        {
            private string symbolEn;

            private double availableShareCount;

            public string SymbolEn
            {
                get { return symbolEn; }

                set { symbolEn = value; }
            }
            public double AvailableShareCount
            {
                get { return availableShareCount; }

                set { availableShareCount = value; }
            }

            public PortfolioShareList(string symbolEn, double availableShareCount)
            {
                this.SymbolEn = symbolEn;

                this.AvailableShareCount = availableShareCount;
            }
        }
    }
}
