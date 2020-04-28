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

        [Required(ErrorMessage = "Вы не указали своё имя")]
        //[Required(ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "YouDidNotSpecifyYourName")]

        [StringLength(20, ErrorMessage = "Имя не может привышать 20 символов")] 
        //[StringLength(20, ErrorMessageResourceType = typeof(Resources.Resource),
        // ErrorMessageResourceName = "NameCannotExceed20Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вы не ввели телефон!")] 
        //[Required(ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "YouHaveNotEnteredThePhone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле Email обязательно для заполнения")] 
        //[Required(ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "EmailFieldIsRequired")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email адрес указан не правильно")] 
        //[RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "EmailAddressIsNotCorrect")]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Напишите, пожалуйста, сообщение")] 
        //[Required(ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "PleaseWriteMessage")]
        public string Message { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources.Resource),
        //    ErrorMessageResourceName = "TheFieldDesiredDateIsRequired")]
        [Required(ErrorMessage = "Введенная дата не корректна!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Желаемая дата")]
        public DateTime DesiredDate { get; set; }

        //public DateTime DesiredTime { get; set; }
        public string Status { get; set; }
    }
}
