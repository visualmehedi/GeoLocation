using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGeoLocation.Model;
using Windows.Devices.Geolocation;

namespace DemoGeoLocation.ViewModel
{
    public class MainPageViewModel
    {
        private Geolocator geo;
        public AppLocation AppLocation { get; set; }

        public MainPageViewModel()
        {
            AppLocation = new AppLocation();
            geo = new Geolocator();
        }
        public async void UpdateLocation()
        {
            Geoposition pos = await geo.GetGeopositionAsync();
            AppLocation.Latitude = pos.Coordinate.Point.Position.Latitude.ToString();
            AppLocation.Longitude = pos.Coordinate.Point.Position.Longitude.ToString();
            AppLocation.Accuracy = pos.Coordinate.Accuracy.ToString();
        }
    }
}
