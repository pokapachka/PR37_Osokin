using System.Collections.Generic;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
    }
}
