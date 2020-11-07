using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_070.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }
    }
}
