using System;
using APIDemo.DependencyInjection;
using APIDemo.Droid.DependencyServices;
using Xamarin.Forms;

[assembly:Dependency(typeof(IMessage_Android))]
namespace APIDemo.Droid.DependencyServices
{
    public class IMessage_Android : IMessage
    {
        public IMessage_Android()
        {
        }

        public string getMessage()
        {
            return "I am from Android";
        }
    }
}
