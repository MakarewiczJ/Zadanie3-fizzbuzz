using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie3.Models
{
    public class Class
    {
        [Required(ErrorMessage = "Pole FizzBuzz jest obowiązkowe"),Range(1,1000,ErrorMessage = "Podana wartość jest spoza zakresu. Wpisz liczbę od 1 do 1000.")]
        public int Liczba { get; set; }
        public string Wynik { get; set; }
    }
}
