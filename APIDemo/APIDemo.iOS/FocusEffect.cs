using System;
using APIDemo.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(FocusEffect), nameof(FocusEffect))]
namespace APIDemo.iOS
{
    public class FocusEffect: PlatformEffect
    {

        UIColor backgroundColor;

        protected override void OnAttached()



        {
            try
            {
                backgroundColor = UIColor.Green;
                Control.BackgroundColor = backgroundColor;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }


        }



        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }




        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
