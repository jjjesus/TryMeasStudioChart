using NationalInstruments.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TryMeasStudioChart
{
    public class MainWindowViewModel
    {
        private ChartCollection<double> _chartData;
        public ChartCollection<double> ChartData
        {
            get { return _chartData; }
            set { _chartData = value; }
        }

        private readonly DispatcherTimer timer = new DispatcherTimer();
        private readonly Random rand = new Random();

        public MainWindowViewModel()
        {
            _chartData = new ChartCollection<double>(100);
            timer.Tick += OnTimerTick;
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            _chartData.Append(rand.NextDouble());
        }
    }
}
