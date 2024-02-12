using lab1.Classes;
using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace lab2
{
    public class HomeController : Controller
    {
        public ViewResult Test(string name, string surname)
        {
            ViewBag.Title = "MyCafe";
            ViewBag.CafeName = "MyCafe";
            ViewBag.Greeting = "Привет, " + name + " " + surname;

            ViewBag.Spisok = new List<string>() {"Один", "Два", "Три" };
            return View();
        }
        public ViewResult Index()
        {
            ViewBag.Title = "MyCafe";
            ViewBag.CafeName = "MyCafe";
            return View();
        }
        [HttpGet]
        public ViewResult DrinkForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }
        [HttpPost]
        public ViewResult DrinkForm(DrinkData drinkData)
        {
            if (ModelState.IsValid)
            {
                switch (drinkData.DrinkTypeEn)
                {
                    case DrinkType.Tea:
                        drinkData.beverage = new Tea(); break;
                    case DrinkType.Juice:
                        drinkData.beverage = new Juice(); break;
                    case DrinkType.Coffee:
                        drinkData.beverage = new Coffee(); break;
                    case DrinkType.Alcohol:
                        drinkData.beverage = new Alcohol(); break;
                }
                drinkData.beverage = new Sugar(drinkData.beverage, drinkData.Sugar);
                drinkData.beverage = new Milk(drinkData.beverage, drinkData.Milk);
                ViewBag.Title = "Bill";
                ViewBag.Cost = drinkData.beverage.cost();
                return View("Bill", drinkData);
            }
            else
            {
                return View();
            }
        }
    }
}