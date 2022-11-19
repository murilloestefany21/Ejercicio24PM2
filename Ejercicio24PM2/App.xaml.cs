﻿using Ejercicio24PM2.Controllers;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio24PM2
{
    public partial class App : Application
    {
        static VideoDB BaseDatos;

        public static VideoDB BaseDatosObject
        {
            get
            {
                if (BaseDatos == null)
                {
                    BaseDatos = new VideoDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VideosDB.db3"));
                }
                return BaseDatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
