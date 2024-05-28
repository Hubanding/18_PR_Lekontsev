using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_леконцев.Models
{
    public class TicketsClass
    {
        public int price { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public TicketsClass() { }
        public TicketsClass(int price, string from, string to, DateTime startTime, DateTime endTime)
        {
            this.price = price;
            this.from = from;
            this.to = to;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}

