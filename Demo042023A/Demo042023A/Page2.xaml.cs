﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo042023A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync( new Page1());
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}