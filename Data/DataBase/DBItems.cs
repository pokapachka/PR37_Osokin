using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ПР37_Осокин.Data.Common;
using ПР37_Осокин.Data.Interfaces;
using ПР37_Осокин.Data.Models;

namespace ПР37_Осокин.Data.DataBase
{
    public class DBItems : IItems
    {
        public IEnumerable<Categories> Categorys = new DBCategory().AllCategorys;
        public IEnumerable<Items> AllItems
        {
            get
            {
                List<Items> items = new List<Items>();
                MySqlConnection mySqlConnection = Connection.MySqlOpen();
                MySqlDataReader ItemsData = Connection.MySqlQuery("select * from Shop.Items order by Name", mySqlConnection);
                while (ItemsData.Read())
                {
                    items.Add(new Items()
                    {
                        Id = ItemsData.IsDBNull(0) ? -1 : ItemsData.GetInt32(0),
                        Name = ItemsData.IsDBNull(1) ? "" : ItemsData.GetString(1),
                        Description = ItemsData.IsDBNull(2) ? "" : ItemsData.GetString(2),
                        Img = ItemsData.IsDBNull(3) ? "" : ItemsData.GetString(3),
                        Price = ItemsData.IsDBNull(4) ? -1 : ItemsData.GetInt32(4),
                        Category = ItemsData.IsDBNull(5) ? null : Categorys.Where(x => x.Id == ItemsData.GetInt32(5)).First()
                    });
                }
                mySqlConnection.Close();
                return items;
            }
        }
        public int Add(Items Item)
        {
            MySqlConnection MySqlConnection = Connection.MySqlOpen();
            Connection.MySqlQuery($"INSERT INTO items (Name, Description, Img, Price, IdCategory) VALUES ('{Item.Name}', '{Item.Description}', '{Item.Img}', {Item.Price}, {Item.Category.Id});", MySqlConnection);
            MySqlConnection.Close();
            int IdItem = -1;
            MySqlConnection = Connection.MySqlOpen();
            MySqlDataReader mySqlDataReaderItem = Connection.MySqlQuery($"SELECT Id FROM items where Name = '{Item.Name}' And Description = '{Item.Description}' And Price = {Item.Price} And IdCategory = {Item.Category.Id};", MySqlConnection);
            if (mySqlDataReaderItem.HasRows) 
            { 
                mySqlDataReaderItem.Read();
                IdItem = mySqlDataReaderItem.GetInt32(0);
            }
            MySqlConnection.Close();
            return IdItem;
        }
    }
}
