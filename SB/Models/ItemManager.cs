using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Models
{
    public class ItemManager
    {
        public static List<Item> ItemList = new List<Item>();
       
       public static List<Item> GetItem()
       {
            string path;
            SQLite.Net.SQLiteConnection conn;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
           /// conn.CreateTable<Item>();

            // var add = conn.Insert(new Item(5, "Test", "SampleImage", 12.4 , "Sample lOc"));
            var query = conn.Table<Item>();
            ItemList = new List<Item>();
            ItemList.Clear();
            foreach (var MyItem in query)
            {
                ItemList.Add(MyItem);
            }
            return ItemList;

       }

       

        public static void InitializeCategory( List<Category> CategoryList)
        {
            CategoryList.Add(new Category("All", "\uE1D8"));
            CategoryList.Add(new Category("Mobiles", "\uE13A"));
            CategoryList.Add(new Category("Household", "\uE726"));
            CategoryList.Add(new Category("Kitchen-Ware", "\uEE94"));
            CategoryList.Add(new Category("Cloths", "\uE790"));
            CategoryList.Add(new Category("Vehicles", "\uEA8B"));
            CategoryList.Add(new Category("Others", "\uEB42"));
        }
        public static void GetItemByCategory(List<Item> Items, string category)
        {

            ItemList = new List<Item>();
            ItemList.Clear();
            ItemList = GetItem();
            if(category == "All")
            {
                ItemList.ForEach(p=> Items.Add(p));
            } else
            {
                var Filtered = ItemList.Where(p => p.Category == category).ToList();
                Filtered.ForEach(p => Items.Add(p));
            }
           

        }
        public static bool AddItem(Item newitem)
        {
            string path;
            SQLite.Net.SQLiteConnection conn;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
           // conn.CreateTable<Item>();

             var add = conn.Insert(newitem);
            if(Convert.ToBoolean(add))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
   
}
