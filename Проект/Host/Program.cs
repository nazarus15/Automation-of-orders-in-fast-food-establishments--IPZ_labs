using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Server_part;


namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Server_part.Service1)))
            {

                Service1 server = new Service1();
                host.Open();
                Console.WriteLine("Хост cтартував\n");
                //Console.WriteLine(server.Message());
                Console.ReadLine();

            }
        }
    }
}
