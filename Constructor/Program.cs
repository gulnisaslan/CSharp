using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Gülnisa",LastName="Aslan",City="Gaziantep"};
            Customer customer2 = new Customer ( 2, "Derin", "demirog", "ankara" );
            Console.WriteLine(customer2.FirstName);

            
        }
       static  void Method(int id,string firstname,string lastname,string city)
        {

        }
    }
    //default constructor
    class Customer
    {
        public Customer()
        {

        }
        //private int _id;
        //private string _firstname;
        //private string _lastName;
        //private string _city;
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            city = City;


            //_id = id;
            //_firstname = firstName;
            //_lastName = lastName;
            //_city = city;
        }//aslında bir metoddur 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
