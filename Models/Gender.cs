using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_115.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }


        [RegularExpression("^[L/P]*$", ErrorMessage = "Gender Hanya Boleh Diisi dengan L/P")]
        [Required(ErrorMessage = "Gender Wajib Diisi!")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
