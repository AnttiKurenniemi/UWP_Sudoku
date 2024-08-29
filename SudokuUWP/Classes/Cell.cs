using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace SudokuUWP.Classes
{
    public enum CellState { Normal, Error, Hint }

    public class Cell : INotifyPropertyChanged
    {
        private int? _value = null;
        public int? Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value != value)
                {
                    if (value == 0)
                        _value = null;
                    else
                        _value = value;
                    NotifyPropertyChanged("Value");
                }
            }
        }

        private CellState _state = CellState.Normal;
        public CellState State
        {
            get
            {
                return _state;
            }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    NotifyPropertyChanged("FontColor"); // "FontColor" is the property where the binding in the grid is set 
                    NotifyPropertyChanged("BackgroundColor");
                }
            }
        }

        private bool _selected = false;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (_selected != value)
                {
                    _selected = value;
                    NotifyPropertyChanged("Selected");
                    NotifyPropertyChanged("BackgroundColor");
                }
            }
        }

        /// <summary>
        /// Solved means background color highlight - full row or block solved
        /// </summary>
        private bool _solved = false;
        public bool Solved
        {
            get
            {
                return _solved;
            }
            set
            {
                if (_solved != value)
                {
                    _solved = value;
                    NotifyPropertyChanged("Solved");
                    NotifyPropertyChanged("BackgroundColor");
                }
            }
        }


        private bool _digitSolved = false;
        public bool DigitSolved
        {
            get
            {
                return _digitSolved;
            }
            set
            {
                if (_digitSolved != value)
                {
                    _digitSolved = value;
                    NotifyPropertyChanged("DigitSolved");
                    NotifyPropertyChanged("FontColor");
                }
            }
        }



        private bool _given = false;
        public bool Given
        {
            get
            {
                return _given;
            }
            set
            {
                if (_given != value)
                {
                    _given = value;
                    NotifyPropertyChanged("Given");
                    NotifyPropertyChanged("FontColor");
                }
            }
        }


        private bool _sameValue = false;
        public bool SameValue
        {
            get
            {
                return _sameValue;
            }
            set
            {
                if (_sameValue != value)
                {
                    _sameValue = value;
                    NotifyPropertyChanged("SameValue");
                    NotifyPropertyChanged("FontColor");
                }
            }
        }


        public Brush BackgroundColor
        {
            get
            {
                if (_selected)
                    return new SolidColorBrush(Colors.SkyBlue);
                else if (_solved)
                    return new SolidColorBrush(Colors.PaleGreen);
                else
                    return new SolidColorBrush(Colors.Transparent);
            }
        }

        /// <summary>
        /// This property is just to bind the font color in the grid, to the internal "State" value
        /// </summary>
        public Brush FontColor
        {
            get
            {
                if (_state == CellState.Error)
                    return new SolidColorBrush(Colors.Red);

                else if (_digitSolved)
                    return new SolidColorBrush(Colors.DarkOliveGreen);

                else if (_state == CellState.Hint)
                    return new SolidColorBrush(Colors.Green);

                else if (_sameValue)
                    return new SolidColorBrush(Colors.Blue);

                else if (_given)
                    return new SolidColorBrush(Colors.Gray);

                else  // == normal
                    return new SolidColorBrush(Colors.Black);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public void Clear()
        {
            Value = null;
            State = CellState.Normal;
            Given = false;
            Solved = false;
            DigitSolved = false;
            SameValue = false;
        }
    }
}
