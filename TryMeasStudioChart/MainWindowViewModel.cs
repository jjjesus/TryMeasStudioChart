using NationalInstruments.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TryMeasStudioChart
{
    public class MainWindowViewModel
    {
        private ChartCollection<double>[] _chartData;
        public ChartCollection<double>[] ChartData
        {
            get { return _chartData; }
            set { _chartData = value; }
        }
        private Model _model;

        public MainWindowViewModel()
        {
            _model = new Model(this);
            _chartData = new []
                {
                    new ChartCollection<double>(100),
                    new ChartCollection<double>(100),
                };
        }

        public int FindChartIndex(int id)
        {
            if (id == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void AppendToChartData(int ix, double value)
        {
            _chartData[ix].Append(value);
        }
    }
}
