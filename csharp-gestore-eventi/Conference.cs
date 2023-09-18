using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Conference : Event
    {
        public string Speaker { get; private set; }
        public int Price { get; private set; }
        public Conference(string title, DateTime date, int maxSeats, string speaker, int price) : base(title, date, maxSeats)
        {
            Speaker = speaker;
            Price = price;
        }

        public string FormattedDate()
        {
            return Date.ToString("yyyy-MM-dd HH':'mm'");
        }

        public string FormattedPrice()
        {
            return Price.ToString("0.00");
        }

        public override string ToString()
        {
            return $"{FormattedDate()} - {Title} - {Speaker} - {FormattedPrice()}";
        }
    }
}
