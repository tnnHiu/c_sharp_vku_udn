using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.Exercise_3
{


    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string[]? Colors { get; set; }
        public int Brand { get; set; }
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;

        }
        public override string ToString()
             => $"{Id,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors!)}";


        public static void ProductPrice400()
        {
            //var result = from product
            //             in products
            //                 //where product.Price == 400 
            //             select product.Name
            //             ;

            //----------------------------------------------------------------

            //var result = from product in products
            //             select new
            //             {
            //                 name = product.Name!.ToUpper(),
            //                 color = string.Join(",", product.Colors!)
            //             };

            //----------------------------------------------------------------

            //var result = from product in products
            //             where product.Price >= 500
            //             where product.Name!.StartsWith("Giường")
            //             select product;
            //----------------------------------------------------------------

            //var result = from product in products
            //             from color in product.Colors!
            //             where product.Price < 500
            //             where color == "Vàng"
            //             select product;
            //----------------------------------------------------------------

            //var result = from prodcut in products
            //             where prodcut.Price <= 300
            //             orderby prodcut.Price descending
            //             select prodcut;
            //----------------------------------------------------------------

            //var result = from product in products
            //             where product.Price >= 400 && product.Price <= 500
            //             group product by product.Price;
            //----------------------------------------------------------------

            //var result = from product in products
            //             where product.Price >= 400 && product.Price <= 500
            //             group product by product.Price into gr
            //             orderby gr.Key descending
            //             select gr;
            //----------------------------------------------------------------
            //var result = from product in products
            //             group product by product.Price into gr
            //             let count = gr.Count()
            //             select new
            //             {
            //                 price = gr.Key,
            //                 number_product = count
            //             };
            //----------------------------------------------------------------

            //var result = from product in products
            //             join brand in brands on product.Brand equals brand.Id
            //             select new
            //             {
            //                 name = product.Name,
            //                 brand = brand.Name,
            //                 price = product.Price,
            //             };
            //----------------------------------------------------------------
            var result = from product in products
                         join brand in brands on product.Brand equals brand.Id into t
                         from brand in t.DefaultIfEmpty()
                         select new
                         {
                             name = product.Name,
                             brand = (brand == null) ? "No-brand" : brand.Name,
                             price = product.Price,
                         };


            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ToString());
            //    //Console.WriteLine($"{product.name}  -  {product.color}");
            //}
            //----------------------------------------------------------------

            //foreach (var group in result)
            //{
            //    // Key là giá trị dùng để phân loại (nhóm): là giá
            //    Console.WriteLine(group.Key);
            //    foreach (Product product in group)
            //    {
            //        Console.WriteLine($"{product.Name} -- {product.Price}");
            //    }
            //}
            //----------------------------------------------------------------

            foreach (var item in result)
            {
                Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }

        }
        static List<Brand> brands = new List<Brand>()
            {
                new Brand{Id = 1, Name = "Công ty AAA"},
                new Brand{Id = 2, Name = "Công ty BBB"},
                new Brand{Id = 4, Name = "Công ty CCC"},
            };

        static List<Product> products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
    }


    public class Brand
    {
        public string? Name { get; set; }
        public int Id { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Product.ProductPrice400();
        }
    }
}
