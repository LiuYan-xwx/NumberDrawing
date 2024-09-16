using NumberDrawing.Model;
using System.ComponentModel;
using System.Timers;
using System.Windows.Input;
using System.Windows.Threading;

namespace NumberDrawing.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly MainModel _mainModel = new();
        private readonly Random _random = new();

        private readonly DispatcherTimer _timer;

        public MainViewModel()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(40);
            _timer.Tick += OnTimerElapsed;
        }

        private void OnTimerElapsed(object? sender, EventArgs e)
        {
          Resultvalue = _random.Next(Minvalue, Maxvalue + 1);

        }



        public int Minvalue
        {
            get => _mainModel.Minvalue;
            set
            {
                if (_mainModel.Minvalue != value)
                {
                    _mainModel.Minvalue = value;
                    RaisePropertyChanged(nameof(Minvalue));
                }
            }
        }
        public int Maxvalue
        {
            get => _mainModel.Maxvalue;
            set
            {
                if (_mainModel.Maxvalue != value)
                {
                    _mainModel.Maxvalue = value;
                    RaisePropertyChanged(nameof(Maxvalue));
                }
            }
        }
        public int Resultvalue
        {
            get => _mainModel.Resultvalue;
            set
            {
                if (_mainModel.Resultvalue != value)
                {
                    _mainModel.Resultvalue = value;
                    RaisePropertyChanged(nameof(Resultvalue));
                }
            }
        }
        public string ButtonContent
        {
            get => _mainModel.ButtonContent;
            set
            {
                if (_mainModel.ButtonContent != value)
                {
                    _mainModel.ButtonContent = value;
                    RaisePropertyChanged(nameof(ButtonContent));
                }
            }
        }
        public bool IsDrawing
        {
            get => _mainModel.IsDrawing;
            set
            {
                if (_mainModel.IsDrawing != value)
                {
                    _mainModel.IsDrawing = value;
                    RaisePropertyChanged(nameof(IsDrawing));
                }
            }
        }

        /// <summary>
        /// 抽号
        /// </summary>
        private void Drawing()
        {
            if (IsDrawing)
            {
                ButtonContent = "开始抽号";
                IsDrawing = false;
                _timer.Stop();
            }
            else
            {
                ButtonContent = "停止抽号";
                IsDrawing = true;
                _timer.Start();
            }
        }
        public ICommand DrawingCommand => new MainCommand(Drawing, () => true);
    }
}