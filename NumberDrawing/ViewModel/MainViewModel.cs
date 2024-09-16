using System.ComponentModel;
using System.Timers;
using System.Windows.Input;
using NumberDrawing.Model;


namespace NumberDrawing.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private MainModel _mainModel = new();

        private System.Timers.Timer _timer;
        private Random _random = new Random();

        public MainViewModel()
        {
            _timer = new System.Timers.Timer(60);
            _timer.Elapsed += OnTimerElapsed;
        }

        void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Resultvalue = _random.Next(Minvalue, Maxvalue + 1);
        }

        public int Minvalue
        {
            get => _mainModel.Minvalue;
            set
            {
                _mainModel.Minvalue = value;
                RaisePropertyChanged(nameof(Minvalue));
            }
        }
        public int Maxvalue
        {
            get => _mainModel.Maxvalue;
            set
            {
                _mainModel.Maxvalue = value;
                RaisePropertyChanged(nameof(Maxvalue));
            }
        }
        public int Resultvalue
        {
            get => _mainModel.Resultvalue;
            set
            {
                _mainModel.Resultvalue = value;
                RaisePropertyChanged(nameof(Resultvalue));
            }
        }
        public string ButtonContent
        {
            get => _mainModel.ButtonContent;
            set
            {
                _mainModel.ButtonContent = value;
                RaisePropertyChanged(nameof(ButtonContent));
            }
        }
        public bool IsDrawing
        {
            get => _mainModel.IsDrawing;
            set
            {
                _mainModel.IsDrawing = value;
                RaisePropertyChanged(nameof(IsDrawing));
            }
        }

        /// <summary>
        /// 抽号
        /// </summary>
        void Drawing()
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
        public ICommand DrawingCommand
        {
            get
            {
                return new MainCommand(Drawing, () => true);
            }
        }
    }
}
