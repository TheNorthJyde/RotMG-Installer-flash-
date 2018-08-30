using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
namespace RotMG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Process.Start(@"C:\Users\" + Environment.UserName + @"\Documents\Realm\flashplayer18_sa.exe", "https://www.realmofthemadgod.com/client");
        }
    }
}
