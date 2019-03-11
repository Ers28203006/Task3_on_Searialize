using System;
using System.Threading;

namespace ClassLib
{
        [Serializable]
    public class PC
    {
        public PC() { }

        public PC(string pcName, string sn, string mac, string ip)
        {
            PCName = pcName;
            SerialNumber = sn;
            MACAddress = mac;
            IPAdress = ip;
        }

        public string PCName { get; set; }
        public string SerialNumber { get; set; }
        public string MACAddress { get; set; }
        public string IPAdress { get; set; }

        public void PCShow()
        {
            Console.WriteLine("Имя компьютера: {0}", PCName);
            Console.WriteLine("серийный номер: {0}", SerialNumber);
            Console.WriteLine("МАС-адрес: {0}", MACAddress);
            Console.WriteLine("IP-адрес: {0}", IPAdress);
            Console.WriteLine("********************************");
        }
        public void PCShutdown()
        {
            PCShow();
            Console.WriteLine("Нажми любую кнопку чтоб компьютер отключился");
            Console.Read();
            Console.Clear();
            Console.WriteLine("Завершение работы...");
            Thread.Sleep(1000);
        }

        public void PCReset()
        {
            PCShow();
            Console.WriteLine("Нажми любую кнопку чтоб перезагрузить компьютер");
            Console.Read();
            Console.Clear();
            Console.WriteLine("Перезагрузка...");
            Thread.Sleep(1000);
            PCShow();
        }

        public void PCInclude()
        {
            Console.WriteLine("Включение...");
            Thread.Sleep(1000);
            PCShow();
        }

    }
}
