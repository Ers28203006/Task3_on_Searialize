using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pc2 = new List<PC>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"E:\\listSerial.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                pc2 = (List<PC>)formatter.Deserialize(fs);
            }

            foreach (var p in pc2)
            {
                p.PCShow();
            }
            Console.ReadLine();


        }
    }
}
