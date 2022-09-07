using ComboDevice.Devices;
using System;
using System.Collections.Generic;

namespace ComboDevice {
    internal class Program {
        static void Main(string[] args) {
            
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("Carta.doc");
            Console.WriteLine(p.Print("Carta.doc"));

            Scanner s = new Scanner() { SerialNumber = 1920 };
            s.ProcessDoc("Photo.jpg");
            Console.WriteLine(s.Scan());
        }
    }
}
