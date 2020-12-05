using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan Wajib Diisi!")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "No Polisi Wajib Diisi!")]
        public string NoPolisi { get; set; }

        [MaxLength(8, ErrorMessage = "No STNK Tidak Boleh Lebih dari 8 angka")]
        [Required(ErrorMessage = "No STNK Wajib Diisi")]
        public string NoStnk { get; set; }

        [Required(ErrorMessage = "Jenis Kendaraan Wajib Diisi")]
        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan Wajib Diisi")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
