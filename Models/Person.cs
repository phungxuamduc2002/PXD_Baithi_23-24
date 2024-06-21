using System.ComponentModel.DataAnnotations;

namespace PXDBaiThi_23_24.Models
{
    public class Person 
    {
        [Key]
        public string Ten {set ; get;}
        public string Msv {set ; get;}
        public string DiaChi {set ; get;}
    }
}