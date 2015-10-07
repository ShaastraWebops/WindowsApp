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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Shaastra
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class eventDescription : Page
    {
        eventDetails myEvents = new eventDetails();

        public eventDescription()
        {
            this.InitializeComponent();
            myEvents.Items.Add(new eventData
            {
                Name = "My Event",
                Day = "Day 1 || Sat || 5:30 pm",
                Venue = "CLT",
                Reg = "Pre-Registered",
                ImgSource = "/EventDescription/trial.jpg",
                About = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Event = "Naruto was serialized in Weekly Shonen Jump magazine from the 43rd issue of 1999 to the 50th issue of 2014.The space activity started with a modest beginning in India in the year 1963 by launching a tiny rocket Nike Apache from the shore of Thumba in the city of Thiruvananthapuram. It was the vision of Dr Vikram Sarabhai  to utilise the advanced technologies for the wellbeing of mankind and  development of society. The space technology has  unique abilities to provide the synoptic view of our natural resources and also to reach   communication to places which are far and remote.",
            });
            Description.DataContext = myEvents;
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
    }
}
