using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sortika
{
    public partial class MainPage : ContentPage
    {


        private List<ProjectChartData> chartData;
        public List<ProjectChartData> ChartData
        {
            get { return chartData; }
            set { chartData = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();

         
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = this;

            PopulateChartData();
        }


        private void PopulateChartData()
        {
            try
            {

                var chartdata = new List<ProjectChartData>();

                chartdata.Add(new ProjectChartData() { Description = "Fixed Income", Amount = 13 });
                chartdata.Add(new ProjectChartData() { Description = "NSE", Amount = 15 });
                chartdata.Add(new ProjectChartData() { Description = "Crypto-currencies", Amount = 40 });
                chartdata.Add(new ProjectChartData() { Description = "Commodities", Amount = 22 });
                chartdata.Add(new ProjectChartData() { Description = "High Yeild Funds", Amount = 10 });

                ChartData = chartdata;

            }
            catch (Exception ex)
            {

            }
        }
    }


    public class ProjectChartData
    {
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
