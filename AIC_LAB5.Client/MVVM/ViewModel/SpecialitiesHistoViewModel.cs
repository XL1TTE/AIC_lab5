using AIC_LAB5.Client.Commands;
using AIC_LAB5.Client.MVVM.View;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace AIC_LAB5.Client.MVVM.ViewModel
{
    public class SpecialitiesHistoViewModel : ViewModelBase<SpecialitiesHistoView>
    {

        private readonly EntityFramework_StudentRepository _studentRepository = new EntityFramework_StudentRepository();

        private ChartValues<int> _histValues = new ChartValues<int>();

        public ChartValues<int> HistData
        {
            get { return _histValues; }
            set { _histValues = value; OnPropertyChanged(); }
        }

        private List<string> _histLabels = new List<string>();

        public List<string> HistLabels
        {
            get { return _histLabels; }
            set { _histLabels = value; OnPropertyChanged(); }
        }

        private int _maxHistYValue;

        public int MaxHistYValue
        {
            get { return _maxHistYValue; }
            set { _maxHistYValue = value; OnPropertyChanged(); }
        }


        public RelayCommand UpdateHistDataCommand {  get; set; }

        public Func<double, string> HistValuesFormatter { get; set; } = value => Math.Round(value, 1).ToString();
        private void InitializeCommands()
        {
            UpdateHistDataCommand = new RelayCommand(o => { UpdateHistData(); }, o => true);
        }

        public SpecialitiesHistoViewModel() : base()
        {
            InitializeCommands();
            UpdateHistData();
        }

        private void UpdateHistData()
        {
            var data = _studentRepository.ReciveAll();

            var hist_data = data.GroupBy(s => s.Speciality)
                .Select(hist_data => new
                {
                    Speciality = hist_data.Key,
                    Count = hist_data.Count()
                }).ToList();

            HistLabels.Clear();
            HistData.Clear();

            MaxHistYValue = 0;

            foreach (var item in hist_data)
            {
                if(item.Count > MaxHistYValue) MaxHistYValue = item.Count;

                HistData.Add(item.Count);
                HistLabels.Add(item.Speciality);
            }

            MaxHistYValue += 5;
        }
    }
}
