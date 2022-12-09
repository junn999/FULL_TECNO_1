using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FULL_TECNO_1.Models
{
    public class Mouses
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}
