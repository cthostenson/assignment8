using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}
		async void ShowTermsPlease (object sender, EventArgs e)
		{
			await Navigation.PushAsync(new UpcomingAppointmentsPage());
		}
	}
}

