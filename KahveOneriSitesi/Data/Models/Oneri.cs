using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Data.Models
{
    public class Oneri
    {
        [Key]
        public int OneriID { get; set; }
        public string OneriAd { get; set; }
        public string OnerenAdSoyad { get; set; }
        public string OneriMalzeme { get; set; }
        public string OneriTarif { get; set; }
        public string OneriResim { get; set; }
        public bool OneriTur { get; set; }
        public bool OneriDurum { get; set; }
        public int OneriBegeni { get; set; }

        public DateTime OneriTarih
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;
    }
}
