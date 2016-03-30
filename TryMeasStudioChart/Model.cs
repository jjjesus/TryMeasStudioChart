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
            double data0 = _rand.NextDouble();
            double data1 = _rand.NextDouble();

            int ix0 = _vm.FindChartIndex(0);
            int ix1 = _vm.FindChartIndex(1);

            _vm.AppendToChartData(ix0, data0);
            _vm.AppendToChartData(ix1, data1);
        }
    }
}
