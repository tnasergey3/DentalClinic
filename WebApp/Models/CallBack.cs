using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CallBack
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Вы не указали своё имя")]
        [StringLength(20, ErrorMessage = "Имя не может привышать 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вы не ввели телефон!")]
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
