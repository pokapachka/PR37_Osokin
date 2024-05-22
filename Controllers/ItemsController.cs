using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using ПР37_Осокин.Data.Interfaces;
using ПР37_Осокин.Data.Models;
using ПР37_Осокин.Data.ViewModell;

namespace ПР37_Осокин.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategorys IAllCategorys;
        VMItems VMItems = new VMItems();
        public ItemsController(IItems IAllItems, ICategorys IAllCategorys)
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
        }
        public ViewResult List(int id = 0)
        {
            ViewBag.Title = "Страница с предметами";
            VMItems.Items = IAllItems.AllItems;
            VMItems.Categorys = IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
        }
        [HttpGet]
        public ViewResult Add()
        {
            IEnumerable<Categories> Categorys = IAllCategorys.AllCategorys;
            return View(Categorys);
        }
    }
}
