using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
         
        }

        async void closeModal()
        {
            await Navigation.PopModalAsync();
        }

    }
}
