using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Jenis Kendaraan Wajib Diisi!")]
        public string NamaJenisKendaraan { get; set; }

        public ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
