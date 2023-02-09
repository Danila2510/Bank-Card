using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Kredit_Card
    {
        public string NomerKarty { get; set; } = null;
        public string Imya { get; set; } = null;
        public string Data { get; set; } = null;
        public int? CVV { get; set; } = null;
        public Kredit_Card() { }
        public Kredit_Card(string nomerKarty, string imya, string data, int? cvv)
        {
            NomerKarty = nomerKarty;
            Imya =  imya;
            Data = data;
            CVV = cvv;
        }

        public override string ToString()
        {
            return $"\n NomerKarty {NomerKarty}\n Polnoуе Imya {Imya}\n Data {Data}\n CVV {CVV}\n";
        }
    }
}