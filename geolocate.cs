using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace geolocate
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Geolocator";
            Console.Write("Enter IP: ");
            string ip = Console.ReadLine();
            string url = $"https://ipinfo.io/{ip}json";

        }
    }
}