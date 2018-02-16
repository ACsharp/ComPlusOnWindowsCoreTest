using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[assembly: ApplicationName("ServerApp")]
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(Value = false)]
[assembly: System.Reflection.AssemblyKeyFile("MyTestKey.snk")]
namespace ServerApp
{
    [Guid("C9D888F5-22C3-4F11-A6C4-1906E7482194")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("VisaHelloWorld.ServerApp2")]
    [ComponentAccessControl(false)]
    public class HelloWorldService : ServicedComponent
    {
        public string HelloWorld(string name)
        {
            return "Hello world from " + name;
        }
    }
}
