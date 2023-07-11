using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public string AdminKadi { get; set; }
        [StringLength(20)]
        public string AdminSifre { get; set; }
    }
}
