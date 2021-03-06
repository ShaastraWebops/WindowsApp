﻿using System;
using System.Diagnostics;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Shaastra.Events
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EventsCategory : Page
    {
        public EventsCategory()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            EventsCategoryViewModel eventsCategoryViewModel = await EventsCategoryViewModel.CreateTaskAsync();
            EventsCategoryView.ItemsSource = eventsCategoryViewModel.Items;
            stopwatch.Stop();
            await new MessageDialog("Time elapsed = " + stopwatch.ElapsedMilliseconds).ShowAsync();
        }
    }
}
