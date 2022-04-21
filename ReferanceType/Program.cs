using System;

namespace ReferanceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferanceType();
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = "1234567891223";

            Employee employee = new Employee();
            employee.FirstName = "veli";

            // new Customer = new Employee; bunlar şartlı türler olup birbirlerine tayin edilemezler

            Person person3 = customer;

            // Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            Console.WriteLine();
        }

        private static void ReferanceType()
        {
            //int decimal enum = value types
            //array List class interfaceler =referance types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı 1: " + sayi1);

            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50 };

            numbers1 = numbers2;
            numbers2[0] = 1000;
            Console.WriteLine("numbers1[0] " + numbers1[0]);
            //grabe collector
        }
    }
    class Person//base classtır(temel sınıf)
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber  { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
