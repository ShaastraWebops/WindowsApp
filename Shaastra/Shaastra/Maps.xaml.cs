using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

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
            InstiMap.ZoomLevel = 16;

            //12.989009, 80.233648
            locations IITM_Places = new locations();
            IITM_Places.Items.Add(new locationData { Name = "Gajendra Circle", alt = 0, lati = 12.991532, longi = 80.233686, Point = new Geopoint(new BasicGeoposition()) });
            IITM_Places.Items.Add(new locationData { Name = "Central Library", alt = 0, lati = 12.990691, longi = 80.233804, Point = new Geopoint(new BasicGeoposition()) });
            IITM_Places.Items.Add(new locationData { Name = "OAT", alt = 0, lati = 12.989009, longi = 80.233648, Point = new Geopoint(new BasicGeoposition()) });
            IITM_Places.setPoints();
            Places.DataContext = IITM_Places;
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridView GV = sender as GridView;
            string item = GV.SelectedItem.GetType().ToString();
            locationData ldt = (locationData)GV.SelectedItem;

            InstiMap.Center = ldt.Point;
            InstiMap.ZoomLevel = 18;
        }


    }
}
