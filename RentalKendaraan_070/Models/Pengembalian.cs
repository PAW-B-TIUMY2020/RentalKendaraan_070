using System;
using System.Collections.Generic;

namespace RentalKendaraan_070.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? Denda { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
