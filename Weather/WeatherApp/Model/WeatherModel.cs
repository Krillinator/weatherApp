using System;
using System.ComponentModel;
namespace WeatherApp.Model
{
    public class WeatherModel
    {
        
    }

    public class Weather : INotifyPropertyChanged
    {
        private string condition;

        public string Condition
        {
            get { return condition; }

            set { if (condition != value)
                {
                    condition = value;
                    RaisePropertyChanged("Condition");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
