using ComboDevice.Devices;
using System;

namespace ComboDevice {
    internal class Program {
        static void Main(string[] args) {
            
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("Carta.doc");
            p.Print("Carta.doc");
            Console.WriteLine();

            Scanner s = new Scanner() { SerialNumber = 1920 };
            s.ProcessDoc("Photo.jpg");
            Console.WriteLine(s.Scan());
            Console.WriteLine();

            ComboDev cd = new ComboDev() { SerialNumber = 540 };
            cd.ProcessDoc("Trabalho.doc");
            cd.Print("Trabalho.doc");
            Console.WriteLine(cd.Scan());
            Console.WriteLine();
        }
    }
}
