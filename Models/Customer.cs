using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage ="Nama Customer Wajib Diisi!")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage ="NIK Hanya Boleh Diisi dengan angka")]
        [Required(ErrorMessage = "NIK Wajib Diisi!")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Wajib Diisi!")]
        public string Alamat { get; set; }

        [MinLength(11, ErrorMessage ="No HP Tidak Boleh Kurang dari 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP Tidak Boleh Lebih dari 13 angka")]
        [Required(ErrorMessage ="No HP Wajib Diisi")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
