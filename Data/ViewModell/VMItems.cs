using System.Collections;
using System.Collections.Generic;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categories> Categorys { get; set; }
        public int SelectCategory = 0;
    }
}
