using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        public int Okulno {  get; set; }
        public string Ad { get; set; }
        public string Soyad {  get; set; }
    }
}
