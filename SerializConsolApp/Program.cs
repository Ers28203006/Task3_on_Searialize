using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC>pc = new List<PC>();
            pc.Add(new PC("HP", "QW123QW123", "ZX123ZX123", "10.16.48.11"));
            pc.Add(new PC("Samsung", "QW777QW777", "ZX777ZX777", "10.16.48.12"));
            pc.Add(new PC("Accer", "QW222QW222", "ZX222ZX222", "10.16.48.13"));
            pc.Add(new PC("Asus", "QW111QW111", "ZX111ZX111", "10.16.48.14"));

            //foreach (var comp in pc)
            //{
            //    comp.PCInclude();
            //}

            //foreach (var comp in pc)
            //{
            //    comp.PCReset();
            //}
            
            //foreach (var comp in pc)
            //{
            //    comp.PCShutdown();
            //}

            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs=new FileStream(@"E:\\listSerial.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, pc);
            }
            
            Console.ReadLine();
        }
    }
}
