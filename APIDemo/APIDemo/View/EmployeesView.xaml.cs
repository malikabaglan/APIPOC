using System;
using System.Collections.Generic;
using APIDemo.Model;
using APIDemo.ViewModel;
using Xamarin.Forms;

namespace APIDemo.View
{
    public partial class EmployeesView : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var emp = e.Item as Employees;
            Navigation.PushAsync(new AddEditEmployee(emp));
        }

     

        EmployeesViewModel employeesViewModel;
        public EmployeesView()
        {
            InitializeComponent();
            EmployeesViewModel employeesViewModel = new EmployeesViewModel(this.Navigation);
            this.BindingContext = employeesViewModel;
           
        }

    }
}
