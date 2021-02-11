﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrevisaoTempoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Weather> Weathers { get => WeatherData(); }

        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>
            {
                new Weather { Temp = "22", Date = "Domingo 14", Icon = "weather.png" },
                new Weather { Temp = "21", Date = "Segunda 15", Icon = "weather.png" },
                new Weather { Temp = "20", Date = "Terça 16", Icon = "weather.png" },
                new Weather { Temp = "12", Date = "Quarta 17", Icon = "weather.png" },
                new Weather { Temp = "17", Date = "Quinta 18", Icon = "weather.png" },
                new Weather { Temp = "20", Date = "Sexta 19", Icon = "weather.png" },
                new Weather { Temp = "20", Date = "Sábado 20", Icon = "weather.png" }
            };

            return tempList;
        }


        public class Weather
        {
            public string Temp { get; set; }
            public string Date { get; set; }
            public string Icon { get; set; }
        }

    }
}
