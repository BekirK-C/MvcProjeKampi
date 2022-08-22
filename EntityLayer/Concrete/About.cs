using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key] // Tüm sınıflarda tanımlanan ID'lerin key olarak atanması gerekir (Primary key)
        public int AboutID { get; set; }

        [StringLength(1000)] // Fazladan yer kaplamaması için karakter sınırı getiriyoruz. (İşlem hangi prop. üzerinde ise ona aittir)
        public string AboutDetails1 { get; set; }

        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
