using System;
using APIDemo.Model;
using APIDemo.ViewModel;
using Xamarin.Forms;

namespace APIDemo.Behaviour
{
    public class ItemSelectedToCommandBehaviour : Behavior<ListView>
    {
        public ItemSelectedToCommandBehaviour()
        {
        }
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemTapped += Bindable_ItemSelected;
            
            
        }

        private void Bindable_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var lv = sender as ListView;
            var emp = lv.SelectedItem as Employees;

            var vm = lv.BindingContext as EmployeesViewModel;
            vm.NavigatetoEdit.Execute(emp);
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemTapped -= Bindable_ItemSelected;
        }
    }
}

