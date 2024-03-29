﻿using System;
using APIDemo.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          // MainPage = new NavigationPage( new DependencyInjectionPage());
            MainPage = new NavigationPage(new EmployeesView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
