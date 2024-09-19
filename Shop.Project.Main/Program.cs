using Shob.Project.Models.Entities;
using Shop.Project.DAL.Repositories;

namespace Shop.Project.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Repositories<Category> repositories1 = new Repositories<Category>();
            Repositories<Product> repositories2 = new Repositories<Product>();
            Repositories<Order> repositories3 = new Repositories<Order>();

            Category category1 = new Category() { Name = "Et mehusllari" };
            Category category2 = new Category() { Name = "Meyve Terevez" };

            Product product1 = new Product() { Name = "Toyuq Qanadi", Price = 10, CategoryId = 1 };
            Product product2 = new Product() { Name = "Quzu Qanadi", Price = 25, CategoryId = 1 };
            Product product3 = new Product() { Name = "Mal Qanadi", Price = 15, CategoryId = 1 };

            Product product4 = new Product() { Name = "Alma", Price = 4, CategoryId = 2 };
            Product product5 = new Product() { Name = "Heyva", Price = 0.1f, CategoryId = 2 };
            Product product6 = new Product() { Name = "Nar", Price = 10, CategoryId = 2 };


            Order order1 = new Order() { Adress = "Eve", Products = new List<Product>() { product1, product2, product3 } };
            Order order2 = new Order() { Adress = "Levi eve", Products = new List<Product>() { product4, product5, product6 } };



            //repositories1.Add(category1);
            //repositories1.Add(category2);

            //repositories2.Add(product1);
            //repositories2.Add(product2);
            //repositories2.Add(product3);
            //repositories2.Add(product4);
            //repositories2.Add(product5);
            //repositories2.Add(product6);

            //repositories3.Add(order1);
            //repositories3.Add(order2);





            //repositories2.SaveChange();
            //repositories3.SaveChange();


            //repositories1.Delete(2);
            //repositories2.Delete(5);



            var products = repositories2.GetAll().ToList();
            foreach (var product in products)
                Console.WriteLine(product);



            repositories2.SaveChange();
        }


    }
}

