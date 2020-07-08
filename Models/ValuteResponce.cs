using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValuteASPTest.Models
{
    public class ValuteResponse
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, Valutes> Valute { get; set; }
    }
}
