using System;
using System.Xml.Linq;

namespace ComboDevice.Devices {
    public class ComboDev : Device, IScanner, IPrinter {
        public void Print(string document) {
            Console.WriteLine($"Multifunção imprimindo {document}");
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine($"Multifunção processando {document}");
        }

        public string Scan() {
            return $"Multifunção escaneando";
        }
    }
}
