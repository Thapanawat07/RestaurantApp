using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Restaurant
    {
   

        public Restaurant(int v1, string v2, string v3, double v4)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Rating = Rating;
        }

        // กำหนด Property สำหรับเก็บข้อมูล รหัส, ชื่อ, ประเภท และคะแนน
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

     
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Hello SIT.1/1");
            Console.WriteLine("Week 2");

        


        }

    }
}
