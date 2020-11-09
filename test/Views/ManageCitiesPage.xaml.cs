using System;
using System.Collections.Generic;
using test.ViewModels;
using test.Views;
using Xamarin.Forms;

namespace test.Views
{
    public partial class ManageCitiesPage : ContentPage
    {
        
        public ManageCitiesPage()
        {
            InitializeComponent();

            BindingContext = new ManageCitiesViewModel();
        }
        public void plusButtonClick(object sender, EventArgs e)
        {

            Navigation.PushAsync(new SearchViewPage());
        }
    }
}
