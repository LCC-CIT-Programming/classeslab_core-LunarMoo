using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {

            // TestProductConstructors();
            // TestProductToString();
            // TestProductPropertyGetters();
            // TestProductPropertySetters();
            TestCustomerConstructors();
            TestCustomerToString();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer(1, "Bob", "Miller", "bobMill@gmail.com", "5411234567");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, bob, miller  " + c2.ToString());
            Console.WriteLine();
        }
        static void TestCustomerToString()
        {
            Customer c1 = new Customer(1, "Bob", "This is a test product", "bobMill@gmail.com", "5411234567");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, Bob, Miller, This is a test product, 5411234567 " + c1.ToString());
            Console.WriteLine("Expecting 1, Bob, Miller, This is a test product, 5411234567 " + c1);
            Console.WriteLine();
        }
        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer(1, "Bob", "This is a test product", "bobMill@gmail.com", "5411234567");

            Console.WriteLine("Testing getters");
            Console.WriteLine("Id.  Expecting 1. " + c1.id);
            Console.WriteLine("firstName.  Expecting Bob. " + c1.firstName);
            Console.WriteLine("lastName.  Expecting This is a test product. " + c1.lastName);
            Console.WriteLine("email.  Expecting bobMill@gmail.com. " + c1.email);
            Console.WriteLine("phone.  Expecting 5411234567. " + c1.phone);
            Console.WriteLine();
        }
        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer(1, "Bob", "This is a test product", "bobMill@gmail.com", "5411234567");

            Console.WriteLine("Testing setters");
            c1.id = 1;
            c1.firstName = "Bob";
            c1.lastName = "Miller";
            c1.email = "bobMill@gmail.com";
            c1.phone = "5411234567";
            Console.WriteLine("Expecting 1, Bob, Miller,bobMill@gmail.com, 5411234567 " + c1);
            Console.WriteLine();
        }
        /*static void TestProductConstructors()
        {
            Product p1 = new Product();
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, T100, 100, This is a test product, 10 " + p2.ToString());
            Console.WriteLine();
        }*/

        /*static void TestProductToString()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1.ToString());
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1);
            Console.WriteLine();
        }*/

        /*static void TestProductPropertyGetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Id.  Expecting 1. " + p1.Id);
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.UnitPrice);
            Console.WriteLine("Quantity.  Expecting 10. " + p1.QuantityOnHand);
            Console.WriteLine();
        }*/

        /*static void TestProductPropertySetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing setters");
            p1.Id = 2;
            p1.Code = "T000";
            p1.Description = "First product";
            p1.UnitPrice = 200;
            p1.QuantityOnHand = 20;
            Console.WriteLine("Expecting 2, T000, 200, First product, 20 " + p1);
            Console.WriteLine();
        }*/
    }
}
