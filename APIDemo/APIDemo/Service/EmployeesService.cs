using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIDemo.Model;
using APIDemo.RestClient;

namespace APIDemo.Service
{
    public class EmployeesService
    {


        public EmployeesService()
        {
        }


            List<Employees> listEmployee { get; set; }
         
            public async Task<List<Employees>> getEmployee()
            {

                listEmployee = new List<Employees>();

                RestClient<Employees> restClient = new RestClient<Employees>();
                try
                {
                    listEmployee = await restClient.GetAsync();

                }
                catch (Exception ex)
                {

                }
                return listEmployee;
            }


        public async Task<bool> AddEmployee(Employees employees)
        {
            RestClient<Employees> restClient = new RestClient<Employees>();

            bool status = await restClient.PostAsync(employees);


            return status;
        }


        public async Task<bool> UpdateEmployee(Employees employees)
        {
            RestClient<Employees> restClient = new RestClient<Employees>();

            bool status = await restClient.PutAsync(employees.ID,employees);


            return status;
        }





    }

    }
