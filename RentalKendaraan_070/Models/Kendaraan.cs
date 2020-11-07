using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_070.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage ="Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "Nomor polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }

        //hanya diisi angka
        [Required(ErrorMessage = "No STNK tidak boleh kosong!")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi angka")]
        public string Ketersediaan { get; set; }
    }
}
