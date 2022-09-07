using System;

namespace ComboDevice.Devices {
    public class Printer : Device, IPrinter {

        public override void ProcessDoc(string document) {
            Console.WriteLine($"Impressora processando {document}");
        }

        public void Print(string document) {
            Console.WriteLine($"Impressora imprimindo {document}");
        }
    }
}
