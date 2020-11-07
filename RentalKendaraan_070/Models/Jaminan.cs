using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_070.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama jaminan tidak boleh kosng")]
        public string NamaJaminan { get; set; }
    }
}
