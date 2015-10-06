using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.ApplicationInsights;
using Shaastra.Events;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Shaastra
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            TelemetryClient telemetryclient = new TelemetryClient();
            telemetryclient.TrackPageView("MainPage");
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

           

        }

        // **** please remove this when proper navigation buttons have been added
        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            Frame.Navigate(typeof(Maps));            
        }
        // for testing purpose only  ****
        private void Events_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (EventsCategory));
        }
    }
}
