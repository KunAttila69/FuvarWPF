using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{

    internal class Fuvar
    {
        private string taxiId;
        private string startTime;
        private string length;
        private string distance;
        private string price;
        private string tip;
        private string payment;

        public string TaxiId { get => taxiId; set => taxiId = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string Length { get => length; set => length = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Price { get => price; set => price = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Payment { get => payment; set => payment = value; }

        public Fuvar(string taxiId, string startTime, string length, string distance, string price, string tip, string payment)
        {
            this.taxiId = taxiId;
            this.startTime = startTime;
            this.length = length;
            this.distance = distance;
            this.price = price;
            this.tip = tip;
            this.payment = payment;
        }
    }
}
