using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace besCenter.Models
{
    public class BESOrtak
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Şirket { get; set; }
        public string SözleşmeDurumu { get; set; }
    }
}
