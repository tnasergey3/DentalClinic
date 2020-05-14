using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Appointment
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Surname { get; set; }

        [Required(ErrorMessage = "Вы не указали своё имя")]
        [StringLength(50, ErrorMessage = "Имя не может привышать 20 символов")] 
        public string Name { get; set; }

        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Вы не ввели телефон!")] 
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Поле Email обязательно для заполнения")] 
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email адрес указан не правильно")] 
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        //[Required(ErrorMessage = "Напишите, пожалуйста, сообщение")] 
        public string Message { get; set; }

        [Required(ErrorMessage = "Введенная дата не корректна!")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Желаемая дата")]
        public DateTime DesiredDate { get; set; }

        public string Status { get; set; }
    }
}
