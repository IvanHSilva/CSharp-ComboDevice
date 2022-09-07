using System;

namespace ComboDevice.Devices {
    public class Printer : Device {

        public override void ProcessDoc(string document) {
            Console.WriteLine($"Impressora processando {document}");
        }

        public string Print(string document) {
            return $"Impressora imprimindo {document}";
        }
    }
}
