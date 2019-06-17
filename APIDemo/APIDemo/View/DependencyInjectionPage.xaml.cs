using System;
using System.Collections.Generic;
using APIDemo.DependencyInjection;
using Xamarin.Forms;

namespace APIDemo.View
{
    public partial class DependencyInjectionPage : ContentPage
    {
        public DependencyInjectionPage()
        {
            InitializeComponent();
            var msg = DependencyService.Get<IMessage>().getMessage();
            //lblMsg.Text = msg;
        }
    }
}
