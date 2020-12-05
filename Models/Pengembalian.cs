using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "Tanggal Wajib Diisi")]
        public DateTime? TglPengembalian { get; set; }
        [Required(ErrorMessage = "ID Peminjaman Wajib Diisi")]
        public int? IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Kondisi Wajib Diisi")]
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda Wajib Diisi")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
