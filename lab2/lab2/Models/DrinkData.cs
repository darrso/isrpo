using lab1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public enum DrinkType
    {
        Tea,
        Coffee,
        Juice,
        Alcohol
    }
    public class DrinkData
    {
        public DrinkType DrinkTypeEn { get; set; }
        public Beverage beverage;
        [Required(ErrorMessage = "Не забудьте ввести количество молока!")]
        public int Milk { get; set; }
        [Required(ErrorMessage = "Не забудьте ввести количество сахара!")]
        public int Sugar { get; set; }
    }
}