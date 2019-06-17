using System;
using Xamarin.Forms;

namespace APIDemo.Behaviour
{
    public class ItemTextChangedToCommandBehaviour:Behavior<Entry>
    {
        public ItemTextChangedToCommandBehaviour()
        {
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += TextChangedBehaviour;
        }

        private void TextChangedBehaviour(object sender, TextChangedEventArgs e)
        {


        //    var tc = sender as Entry;
        //  char s = char.Parse( e.NewTextValue );
        //    if(char.IsDigit(s))
        //    {

        //    }
        //    else
        //    {
        //         tc.Text=  e.NewTextValue;

        //    }

        //    tc.TextColor = Color.AliceBlue;

     }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= TextChangedBehaviour;
        }
    }
}
