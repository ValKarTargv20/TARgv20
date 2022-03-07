using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TARgv20
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button box_btn = new Button
            {
                Text = "BoxView",
                BackgroundColor = Color.Aquamarine
            };
            StackLayout st = new StackLayout
            {
                Children = { box_btn }
            };
            st.BackgroundColor = Color.Black;
            Content = st;
        }
        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Box_Page());
        }
    }
}
