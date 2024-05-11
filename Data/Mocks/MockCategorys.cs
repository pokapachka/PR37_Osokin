using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ПР37_Осокин.Data.Interfaces;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.Mocks
{
    public class MockCategorys : ICategorys
    {
        public IEnumerable<Categories> AllCategorys
        {
            get
            {
                return new List<Categories> {
                    new Categories
                    {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновые печи - электроприбор..."
                    },
                    new Categories
                    {
                        Id = 1,
                        Name = "Мультиварки",
                        Description = "Мультиварка - многофункциональный электроприбор..."
                    }
                };
            }
        }
    }
}
