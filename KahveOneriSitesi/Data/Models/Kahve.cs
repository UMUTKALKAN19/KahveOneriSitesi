using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Data.Models
{
    public class Kahve
    {
        [Key]
        public int KahveID { get; set; }
        public string KahveAd { get; set; }
        public string KahveMalzeme { get; set; }
        public string KahveTarif { get; set; }
        public string KahveResim { get; set; }
        public bool KahveTur { get; set; }

        public DateTime KahveTarih
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

        public List<Yorum> Yorumlar { get; set; }
    }
}
