using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ПР37_Осокин.Data.Common;
using ПР37_Осокин.Data.Interfaces;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.DataBase
{
    public class DBCategory : ICategorys
    {
        public IEnumerable<Categories> AllCategorys
        {
            get
            {
                List<Categories> categorys = new List<Categories>();
                MySqlConnection MySqlConnection = Connection.MySqlOpen();
                MySqlDataReader CategorysData = Connection.MySqlQuery("select * from Shop.Categorys order by Name;", MySqlConnection);
                while (CategorysData.Read())
                {
                    categorys.Add(new Categories()
                    { 
                        Id = CategorysData.IsDBNull(0) ? -1 : CategorysData.GetInt32(0),
                        Name = CategorysData.IsDBNull(1) ? null : CategorysData.GetString(1),
                        Description = CategorysData.IsDBNull(2) ? null : CategorysData.GetString(2),
                    }
                    );
                }
                return categorys;
            }
        }

    }
}
