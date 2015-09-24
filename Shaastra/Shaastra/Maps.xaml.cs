using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Shaastra
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Maps : Page
    {
        public Maps()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            setCentreToIITM();
        }

        private void setCentreToIITM()
        {
            BasicGeoposition IITM_pos;
            IITM_pos.Altitude = 0;
            IITM_pos.Latitude = 12.992575;
            IITM_pos.Longitude = 80.236867;
            Geopoint IITM = new Geopoint(IITM_pos);
            InstiMap.Center = IITM;
            InstiMap.ZoomLevel = 15;


            locations IITM_Places = new locations();
            IITM_Places.Items.Add(new locationData { Name = "Gajendra Circle", Serial = "0", alt = 0, lati = 45, longi = 30, Point = new Geopoint(new BasicGeoposition()) });
            Places.DataContext = IITM_Places;
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
