using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelBase2;

namespace DemoGeoLocation.Model
{
    public class AppLocation : PropertyChangedBase
    {
        public string latitude;
        public string longitude;
        public string accuracy;
        public string Latitude 
        { 
            get { return this.latitude; }
            set { this.latitude = value;
            OnPropertyChanged();
            } 
        }
        public string Longitude
        {
            get { return this.longitude; }
            set { this.longitude = value;
            OnPropertyChanged();
            }
        }
        public string Accuracy
        {
            get { return this.accuracy; }
            set { this.accuracy = value;
            OnPropertyChanged();
            }
        }

    }
}
