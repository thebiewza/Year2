using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1__class

{
    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(string valueSize, string valueColor, float valuePrice, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valuePrice;
            image = valueImage;
        }
        public void ShowTshirt()
        {
            Console.WriteLine("size : {0}", this.size);
            Console.WriteLine("color : {0}", this.color);
            Console.WriteLine("image : {0}", this.image);
            Console.WriteLine("image : {0}", this.price);
            Console.WriteLine("-----------------------------------");

        }
    }
    class User
    {
        public string name;
        public string Email;
        public List<Tshirt> OrderTshirt;
        public List<address> UserAddress;

        public User(string valueName, string valueEmail)
        {
            name = valueName;
            Email = valueEmail;
            OrderTshirt = new List<Tshirt>();
            UserAddress = new List<address>();
        }

        public void TshirtOrder(Tshirt tshirt)
        {
            OrderTshirt.Add(tshirt);
        }
        public void UserAd(address address)
        {
            UserAddress.Add(address);
        }

        public void UserOutput()
        {
            Console.WriteLine("name : {0}", this.name);
            Console.WriteLine("email : {0}", this.Email);
        }
    }
    class address
    {
        public string street;
        public string city;
        public string zipCode;
        public address(string valueStreet, string valueCity, string valueZipcode)
        {
            street = valueStreet;
            city = valueCity;
            zipCode = valueZipcode;
        }
        
        public void AddressOutput()
        {
            Console.WriteLine("131 / 75. {0}, {1}, {2}", this.street, this.city, this.zipCode);
        }
    }
    class ShoppingCart
    {
        public List<Tshirt> OrderTshirt;
        public List<address> Address;

        public ShoppingCart()
        {
            OrderTshirt = new List<Tshirt>();
            Address = new List<address>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tshirt orderA = new Tshirt("L", "Red", 500f, "Red is so cute");
            Tshirt orderB = new Tshirt("M", "Black", 750f, "Black is the BEST!! ");
            Tshirt orderC = new Tshirt("S", "Green", 625f, "Natural Green");

            User Jame = new User("Jame", "jame@gmail.com");

            address JameAddress = new address("Phutthamonthon Road", "Nakhon Pathom", "10180");

            Jame.TshirtOrder(orderA);
            Jame.TshirtOrder(orderB);
            Jame.TshirtOrder(orderC);
            orderA.ShowTshirt();
            orderB.ShowTshirt();
            orderC.ShowTshirt();
            Jame.UserOutput();
            Jame.UserAd(JameAddress);
            JameAddress.AddressOutput();

            Console.WriteLine("Total price : {0} THB.", orderA.price + orderB.price + orderC.price);

            Console.ReadLine();
        }
    }
}
