using System;
using System.Collections.Generic;
using APIDemo.Model;
using APIDemo.ViewModel;
using Xamarin.Forms;

namespace APIDemo.View
{
    public partial class AddEditEmployee : ContentPage
    {
        public AddEditEmployee()
        {

            AddEditEmpViewModel addEditEmpViewModel = new AddEditEmpViewModel(this.Navigation );

            InitializeComponent();
            this.BindingContext = addEditEmpViewModel;
        }

       


        public AddEditEmployee(Employees employees)
        {

            AddEditEmpViewModel addEditEmpViewModel = new AddEditEmpViewModel(this.Navigation);
            addEditEmpViewModel.SelectedEmployees = employees;

            InitializeComponent();
            this.BindingContext = addEditEmpViewModel;
        }
    }
}
