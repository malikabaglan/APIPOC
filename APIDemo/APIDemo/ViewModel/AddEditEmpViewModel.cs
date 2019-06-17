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
    public class AddEditEmpViewModel: INotifyPropertyChanged
    {


    

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

        private Employees selectedmployees;
        public Employees SelectedEmployees
        {
            get
            {
                return selectedmployees;
            }

            set
            {
                selectedmployees = value;
                OnPropertyChanged();
            }
        }


        private bool isBusy;
        public bool IsBusy
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
        private string message;
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
                OnPropertyChanged();
            }
        }






        public Command AddEmp
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;

                    EmployeesService services = new EmployeesService();

                    var status = await services.AddEmployee(SelectedEmployees);
                    if (status)
                    {

                        Message = "Data Inserted Successfully ";
                    }
                    else
                    {

                        Message = "  Please try again later ";
                    }
                    IsBusy = false;



                });
            }
        }



        public Command UpdateEmp
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;

                    EmployeesService services = new EmployeesService();

                    var status = await services.UpdateEmployee(SelectedEmployees);
                    if (status)
                    {

                        Message = "Data Updated Successfully ";
                    }
                    else
                    {

                        Message = "  Please try again later ";
                    }
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













        public INavigation navigation { get; set; }

        public AddEditEmpViewModel(INavigation _navigation )
        {
            navigation = _navigation;

      
            SelectedEmployees = new Employees();
        }
    }


}
