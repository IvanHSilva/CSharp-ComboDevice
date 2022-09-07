using System;

namespace ComboDevice.Devices {
    public class Scanner : Device, IScanner {
        public override void ProcessDoc(string document) {
            Console.WriteLine($"Scanner processando {document}");
        }

        public string Scan() {
            return "Escaneamento concluído!";
        }
    }
}
