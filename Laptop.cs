using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    internal class Laptop
    {
        public Cart cart = new Cart();
        //public double Price { get; set; }
        //public string Name { get; set; }
        //public string Brand{ get; set; }


        #region Header
        public void Header()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("==============                  WELCOME TO ONLINE SHOP                 ======================");
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("=============================================================================================" + "\n\n");
            MainMenu();
        }
        #endregion

        #region Main Menu
        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> MAIN MENU\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter (1) for Laptop Shop");
            Console.WriteLine("Enter (2) for Laptop Accessories Shop");
            Console.WriteLine("Enter (3) to view cart");
            Console.WriteLine("Enter (0) to exit");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    Laptops();
                    break;
                case 3:
                    cart.ShoppingCart();
                    break;
                case 0:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!!");
                    MainMenu();
                    break;
            }


        }
        #endregion

        #region Laptops
        public void Laptops()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> BRAND OPTIONS\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter (1) for Lenovo");
            Console.WriteLine("Enter (2) for HP");
            Console.WriteLine("Enter (3) for Dell");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int bchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (bchoice)
            {
                case 1:
                    LenovoOptions();
                    break;
                case 2:
                    HPOptions();
                    break;
                case 3:
                    DellOptions();
                    break;
                case 0:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!\n");
                    Laptops();
                    break;
            }
        }

        #endregion

        #region Options
        public void LenovoOptions()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> SHOP OPTIONS\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter (1) for Lenovo Legion 1");
            Console.WriteLine("Enter (2) for Lenovo Yoga");
            Console.WriteLine("Enter (3) for Lenovo Yoga Pro");
            Console.WriteLine("Enter (0) to go back");
            Console.WriteLine("Enter (4) to exit shop");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    LenovoL1();
                    break;
                case 2:
                    LenovoY();
                    break;
                case 3:
                    LenovoYP();
                    break;
                case 4:
                    Exit();
                    MainMenu();
                    break;
                case 0:
                    Laptops();
                    break;
                default:
                    Console.WriteLine("Please select correct option\n");
                    LenovoOptions();
                    break;
            }
        }

        public void HPOptions()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> SHOP OPTIONS\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter (1) for HP EliteBook");
            Console.WriteLine("Enter (2) for HP Alder Lake");
            Console.WriteLine("Enter (3) for HP Raptor Lake");
            Console.WriteLine("Enter (0) to go back");
            Console.WriteLine("Enter (4) to exit shop");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lchoice)
            {
                case 1:
                    HPEliteBook();
                    break;
                case 2:
                    HPAlderLake();
                    break;
                case 3:
                    HPRaptorLake();
                    break;
                case 4:
                    Exit();
                    break;
                case 0:
                    Laptops();
                    break;
                default:
                    Console.WriteLine("Please select correct option\n");
                    HPOptions();
                    break;
            }
        }

        public void DellOptions()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> SHOP OPTIONS\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter (1) for Precision");
            Console.WriteLine("Enter (2) for Vostro");
            Console.WriteLine("Enter (3) for Alienware");
            Console.WriteLine("Enter (0) to go back");
            Console.WriteLine("Enter (4) to exit shop");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lchoice)
            {
                case 1:
                    Precision();
                    break;
                case 2:
                    Vostro();
                    break;
                case 3:
                    Alienware();
                    break;
                case 4:
                    Exit();
                    break;
                case 0:
                    Laptops();
                    break;
                default:
                    Console.WriteLine("Please select correct option\n");
                    DellOptions();
                    break;
            }
        }
        #endregion

        #region Lenovo Legion 1
        public  void LenovoL1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> LENOVO LEGION 1\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Lenovo Legion 1");
            Console.WriteLine("Unit Price       |       $ 450");
            Console.WriteLine("Brand Name       |       Lenovo");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int llchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (llchoice)
            {
                case 1:
                    cart.AddtoCartList("Lenovo Legion 1",450, "Lenovo");
                    Laptops();
                    break;
                case 0:
                    LenovoOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    LenovoL1();
                    break;
            }
        }
        #endregion

        #region Lenovo Yoga
        public void LenovoY()
        {
            //ArrayList lenovo = new ArrayList();
            //lenovo.Add(new Laptop { Name = "Lenovo Yoga", Price = 224999, Brand = "Lenovo" });      
            //lenovo.Add(new Laptop { Name = "Lenovo 1", Price = 653, Brand = "Lenovo" });      
            //lenovo.Add(new Laptop { Name = "Lenovo 2", Price = 543, Brand = "Lenovo" });      
            //lenovo.Add(new Laptop { Name = "Lenovo 3", Price = 245, Brand = "Lenovo" });      
            //foreach (var item in lenovo)
            //{
            //    Console.WriteLine("----------------------------------------------------------");
            //    Console.WriteLine($"{item.ToString()}");
            //    Console.WriteLine("----------------------------------------------------------");
            //}
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> LENOVO YOGA\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Lenovo Yoga");
            Console.WriteLine("Unit Price       |       $ 640");
            Console.WriteLine("Brand Name       |       Lenovo");
            Console.WriteLine("----------------------------------------------------------");
           
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lychoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lychoice)
            {
                case 1:
                    cart.AddtoCartList("Lenovo Yoga", 640, "Lenovo");
                    Laptops();
                    break;
                case 0:
                    LenovoOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    LenovoY();
                    break;
            }
        }

        #endregion

        #region Lenovo Yoga Pro
        public void LenovoYP()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> LENOVO YOGA PRO\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Lenovo Yoga Pro");
            Console.WriteLine("Unit Price       |       $ 750");
            Console.WriteLine("Brand Name       |       Lenovo");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lypchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lypchoice)
            {
                case 1:
                    cart.AddtoCartList("Lenovo Yoga Pro", 750, "Lenovo");
                    Laptops();
                    break;
                case 0:
                    LenovoOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    LenovoYP();
                    break;
            }
        }

        #endregion

        #region HP EliteBook
        public void HPEliteBook()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> HP ELITEBOOK\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       HP EliteBook");
            Console.WriteLine("Unit Price       |       $ 450");
            Console.WriteLine("Brand Name       |       HP");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int llchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (llchoice)
            {
                case 1:
                    cart.AddtoCartList("HP EliteBook", 450, "HP");
                    Laptops();
                    break;
                case 0:
                    HPOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    HPEliteBook();
                    break;
            }
        }
        #endregion

        #region HP Alder Lake
        public void HPAlderLake()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> HP ALDER LAKE\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       HP Alder Lake");
            Console.WriteLine("Unit Price       |       $ 500");
            Console.WriteLine("Brand Name       |       HP");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lychoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lychoice)
            {
                case 1:
                    cart.AddtoCartList("HP Alder Lake", 500, "HP");
                    Laptops();
                    break;
                case 0:
                    HPOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    HPAlderLake();
                    break;
            }
        }

        #endregion

        #region HP Raptor Lake
        public  void HPRaptorLake()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> HP RAPTOR LAKE\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       HP Raptor Lake");
            Console.WriteLine("Unit Price       |       $ 502");
            Console.WriteLine("Brand Name       |       HP");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lypchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lypchoice)
            {
                case 1:
                    cart.AddtoCartList("HP Raptor Lake", 502, "HP");
                    Laptops();
                    break;
                case 0:
                    HPOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    HPRaptorLake();
                    break;
            }
        }

        #endregion

        #region Precision
        public void Precision()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> PRECISION\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Precision");
            Console.WriteLine("Unit Price       |       $ 470");
            Console.WriteLine("Brand Name       |       Dell");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int llchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (llchoice)
            {
                case 1:
                    cart.AddtoCartList("Precision", 470, "Dell");
                    Laptops();
                    break;
                case 0:
                    DellOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    Precision();
                    break;
            }
        }
        #endregion

        #region Vostro
        public void Vostro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> VOSTRO\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Vostro");
            Console.WriteLine("Unit Price       |       $ 540");
            Console.WriteLine("Brand Name       |       Dell");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lychoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lychoice)
            {
                case 1:
                    cart.AddtoCartList("Vostro", 540, "Dell");
                    Laptops();
                    break;
                case 0:
                    DellOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    Vostro();
                    break;
            }
        }

        #endregion

        #region Alienware
        public  void Alienware()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> ALIENWARE\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Name             |       Alienware");
            Console.WriteLine("Unit Price       |       $ 800");
            Console.WriteLine("Brand Name       |       Dell");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter (1) to add item to cart");
            Console.WriteLine("Enter (0) to go back");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please enter option: ");
            int lypchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (lypchoice)
            {
                case 1:
                    cart.AddtoCartList("Alienware", 800, "Dell");
                    Laptops();
                    break;
                case 0:
                    DellOptions();
                    break;
                default:
                    Console.WriteLine("Please select correct option...!");
                    Alienware();
                    break;
            }
        }

        #endregion

        #region Exit
        public void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================================================================================");
            Console.WriteLine("==========================               THANKS FOR SHOPPING              ========================");
            Console.WriteLine("==================================================================================================\n\n");

        }
        #endregion




    }
}
