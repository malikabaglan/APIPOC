using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using APIDemo.Model;
using APIDemo.Service;
using APIDemo.View;
using Xamarin.Forms;

namespace APIDemo.ViewModel
{
    public class EmployeesViewModel:INotifyPropertyChanged
    {





        public INavigation navigation { get; set; }
        public EmployeesViewModel(INavigation _navigation)
        {
            navigation = _navigation;
            IsBusy = true;
            GetEmployees();
        }
        
        EmployeesService employeesService = new EmployeesService();


        private async void GetEmployees()
        {
            EmployeeList= await employeesService.getEmployee();
            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        } 
        private List<Employees> employeeList;
        public List<Employees> EmployeeList
        {
            get
            {
                return employeeList;
            }

            set
            {
                employeeList = value;
                OnPropertyChanged();
            }
        }


        private bool isBusy;
        public  bool IsBusy
        {
            get
            {
                return isBusy;
            }

            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public Command ResrefhCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    GetEmployees();
           IsBusy = false;



                });
            }
        }






        public Command NavigateTo
        {
            get
            {
                return new Command(async () =>
                {
                     navigation.PushAsync(new AddEditEmployee());


                });
            }




        }





        public Command<Employees> NavigatetoEdit
        {
            get
            {
                return new Command<Employees>(async (emp) =>
                {
                    navigation.PushAsync(new AddEditEmployee(emp));


                });
            }




        }






 

    }
}
