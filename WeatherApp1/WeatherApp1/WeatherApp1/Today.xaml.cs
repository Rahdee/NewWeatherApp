﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowPage : ContentPage
    {
        public NowPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

    }
}