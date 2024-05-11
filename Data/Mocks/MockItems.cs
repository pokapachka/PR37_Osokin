using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ПР37_Осокин.Data.Interfaces;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _category = new MockCategorys();
        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items(){
                    Id = 0,
                    Name = "Dexp MS-70",
                    Description = "Благодаря черному корпусу",
                    Img = "ssylka",
                    Price = 3699,
                    Category = _category.AllCategorys.Where(x => x.Id == 0).First() 
                    },

                    new Items(){
                    Id = 1,
                    Name = "Pepsi",
                    Description = "Благодаря черному корпусу",
                    Img = "ssylka",
                    Price = 150,
                    Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    },

                    new Items(){
                    Id = 2,
                    Name = "dfdf",
                    Description = "dfdf",
                    Img = "ssylka",
                    Price = 36,
                    Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    }
                };

            }
        }
    }
}
