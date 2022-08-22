using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public bool HeadingStatus { get; set; }
        public int CategoryID { get; set; } // İlişkili tablonun anahtar sütunu ile aynı isim veriliyor.(CategoryID > PrimaryKey)
        public virtual Category Category { get; set; } // İlişkili tablodaki ID alanı

        public int WriterID { get; set; } // İlişkili tablonun anahtar sütunu ile aynı isim veriliyor.(WriterID > PrimaryKey)
        public virtual Writer Writer { get; set; } // İlişkili tablodaki ID alanı

        public ICollection<Content> Contents { get; set; } // Content ile ilişki kuruluyor
    }
}
