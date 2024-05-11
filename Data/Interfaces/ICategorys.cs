using System.Collections;
using System.Collections.Generic;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.Interfaces
{
    public interface ICategorys
    {
        IEnumerable<Categories> AllCategorys { get; }
    }
}
