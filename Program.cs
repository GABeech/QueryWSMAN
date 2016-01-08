using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WSManAutomation;

using static System.Console;

namespace QueryWSMan
{
    class Program
    {
        private static void Main(string[] args)
        {
            string user = "USERNAME", password = "PASS";
            var schema = "http://schemas.dell.com/wbem/wscim/1/cim-schema/2/DCIM_SystemInteger?__cimnamespace=root/dcim+InstanceID=System.Embedded.1#ServerTopology.1#RackSlot";


            var wsman = new WSMan();
            var wsManFlags = wsman.SessionFlagCredUsernamePassword() | wsman.SessionFlagSkipCNCheck() |
                             wsman.SessionFlagSkipCACheck() | wsman.SessionFlagUseBasic() | wsman.SessionFlagUTF8();
            var wsManOpt = (IWSManConnectionOptions) wsman.CreateConnectionOptions();


            var wsManEndpoint = "https://co-web03-drac/wsman";
            wsManOpt.UserName = user;
            wsManOpt.Password = password;

            var wsManSession = (IWSManSession) wsman.CreateSession(wsManEndpoint, wsManFlags, wsManOpt);
            wsManSession.Timeout = 60000;
            try
            {
                if ((wsManSession.Identify()) == null)
                {
                    WriteLine("Not a WSMan Endpoint");
                    Environment.Exit(1);
                }

            }
            catch (UnauthorizedAccessException e)
            {
                WriteLine($"[Identify] : Not authroized.");
                //Console.WriteLine($"{ip}: {e.Message}\n{e.StackTrace}");
                Environment.Exit(1);
            }
            catch (COMException e)
            {
                WriteLine($"[Identify] : COM Exception.");
                //Console.WriteLine($"{ip}: {e.Message}\n{e.StackTrace}");
                Environment.Exit(1);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("could not connect"))
                {
                    WriteLine($"[Identify] : Count not connect.");
                    Environment.Exit(1);
                }
                WriteLine($"[Identify] : Error ({e.GetType()}):{e.Message}\n{e.StackTrace}");
                Environment.Exit(1);
            }

            try
            {
                var wsInstance = wsManSession.Get(schema);
                WriteLine(wsInstance);
                var s = new XmlSerializer(typeof(DCIM_SystemString));
                DCIM_SystemString obj = (DCIM_SystemString)s.Deserialize(new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(wsInstance))));
                WriteLine(obj.CurrentValue);
                ReadKey();

            }
            catch (Exception e)
            {
                WriteLine($"[Query] : Error ({e.GetType()}:{e.Message}\n{e.StackTrace}");
                ReadKey();
            }
            
            /*
            while (!wsInstance.AtEndOfStream())
            {
                var curItem = wsInstance.ReadItem();

                using (var r = XmlReader.Create(new StringReader(curItem.ToString())))
                {
                    var xd = XDocument.Load(r);
                    WriteLine(xd.Document);

                }
            }
            */
            

            Environment.Exit(0);
        }
    }
}
