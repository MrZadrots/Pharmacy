using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage ="Длина имени не более 20 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не более 25 символов")]
        public string SurName { get; set; }

        [Display(Name = "Введите адресс")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адрес не более 35 символов")]
        public string adress { get; set; }
        
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required(ErrorMessage = "Длина телефона не более 11 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(45)]
        [Required(ErrorMessage = "Длина почты не более 45 символов")]
        public string email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        
        public List<OrderDetail> orderDetails { get; set; }
    }
}
