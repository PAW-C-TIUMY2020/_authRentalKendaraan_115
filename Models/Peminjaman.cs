using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal Wajib Diisi")]
        public DateTime? TglPeminjaman { get; set; }
        [Required(ErrorMessage = " Nama Kendaraan Wajib Diisi")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Customer Wajib Diisi")]
        public int? IdCustomer { get; set; }
        [Required(ErrorMessage = "Jaminan Wajib Diisi")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya Wajib Diisi")]
        public int? Biaya { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
