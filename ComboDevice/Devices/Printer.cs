using System;

namespace ComboDevice.Devices {
    public class Printer : Device {
        public override void ProcessDoc(string document) {
            Console.WriteLine($"Scanner processando {document}");
        }

        public string Print() {
            return "Resultado da Impressão";
        }
    }
}
