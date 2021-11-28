using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi_Kartı_Takip
{
    class Verigoster
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string bankName { get; set; }
        public string productCategory { get; set; }
        public int numberOfInstallments { get; set; }
        public double installmentAmount { get; set; }
        public double aggregateAmount { get; set; }
        public DateTime addDate { get; set; }
        public string mailOrder { get; set; }

    }
}
