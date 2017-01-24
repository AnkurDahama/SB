using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double  Price { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public Item(int id, string name, string image, double price, string location, string category)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
            Location = location;
            Category = category;
        }
        public Item()
        {
   
        }
    }
    

}
