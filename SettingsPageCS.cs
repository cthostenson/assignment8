using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS ()
		{
			IconImageSource = "settings.png";
			Title = "Settings";
			var button = new Button
			{
				Text = "Terms and Conditions",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += ShowTermsPlease;

			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Settings go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					},
                    button
				}
			};
		}

		async void ShowTermsPlease (object sender, EventArgs e)
		{
			await Navigation.PushAsync(new UpcomingAppointmentsPage());
		}

	}


}
