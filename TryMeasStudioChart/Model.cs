using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TryMeasStudioChart
{
    public class Model
    {
        private readonly DispatcherTimer _timer;
        private readonly Random _rand;
        private MainWindowViewModel _vm;

        public Model(MainWindowViewModel vm)
        {
            _vm = vm;
            _rand = new Random();
            _timer = new DispatcherTimer();
            _timer.Tick += OnTimerTick;
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            _vm.AppendToChartData("tIn", _rand.NextDouble());
            _vm.AppendToChartData("tOut", _rand.NextDouble());
        }
    }
}
