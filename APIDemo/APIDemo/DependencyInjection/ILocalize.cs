using System;
using System.Globalization;

namespace APIDemo.DependencyInjection
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        /// <summary>
        /// CurrentCulture and CurrentUICulture must be set in the platform project, 
        /// because the Thread object can't be accessed in a PCL.
        /// </summary>
        void SetLocale(CultureInfo ci); 



    }
}
