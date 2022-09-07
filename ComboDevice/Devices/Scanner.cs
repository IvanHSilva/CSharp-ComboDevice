using System;

namespace ComboDevice.Devices {
    public class Scanner : Device {
        public override void ProcessDoc(string document) {
            Console.WriteLine($"Scanner processando {document}");
        }

        public string Scan() {
            return "Resultado do Escaneamento";
        }
    }
}
