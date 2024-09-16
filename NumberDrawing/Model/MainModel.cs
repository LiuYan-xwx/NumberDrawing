using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDrawing.Model
{
    public class MainModel
    {
        private int _minvalue = 1;
        private int _maxvalue = 50;
        private int _resultvalue;
        private string _buttonContent = "开始抽号";
        private bool _isDrawing = false;
        public int Minvalue
        {
            get => _minvalue;
            set
            {
                _minvalue = value;
            }
        }
        public int Maxvalue
        {
            get => _maxvalue;
            set
            {
                _maxvalue = value;
            }
        }
        public int Resultvalue
        {
            get => _resultvalue;
            set
            {
                _resultvalue = value;
            }
        }
        public string ButtonContent
        {
            get => _buttonContent;
            set
            {
                _buttonContent = value;
            }
        }
        public bool IsDrawing
        {
            get => _isDrawing;
            set
            {
                _isDrawing = value;
            }
        }
    }
}
