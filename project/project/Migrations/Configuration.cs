using System.Data.Entity;
using System.Data.Entity.Migrations;
using project.Models;

namespace project.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<project.Models.Mydb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
        public class SeedContext : DropCreateDatabaseAlways<Mydb>
        {
            protected override void Seed(project.Models.Mydb context)
            {
                Mydb db = new Mydb();

                Admin ad = new Admin();

                ad.username = "Admin";
                ad.password = "qwerty";

                customer cu = new customer();

                cu.Name = "Hassan";
                cu.Username = "hassan";
                cu.Password = "hassan234";
                cu.Email = "HassanShahid1117@yahoo.com";


                Products p = new Products();
                p.Name = "Cube Wall Mount Shelves ";
                p.Discription = "Set of 3 - Cube Wall Mount Shelves - White";
                p.Price = 2999;
                Products p1 = new Products();

                p1.Name = "Iris Coffee Table";
                p1.Discription = "Nice and unique coffee table in dark brown color with metallic legs.";
                p1.Price = 3990;

                Products p2 = new Products();

                p2.Name = "Black Bean Bag Sofa ";
                p2.Discription = "This unique colored bean bag is the best product to be with.";
                p2.Price = 3799;

                db.Admin.Add(ad);
                db.SaveChanges();

                db.customer.Add(cu);
                db.SaveChanges();

                db.products.Add(p);
                db.SaveChanges();

                db.products.Add(p1);
                db.SaveChanges();

                db.products.Add(p2);
                db.SaveChanges();

                base.Seed(db);
            }

        }
    }

}
