using System;
using System.Collections.Generic;

namespace _program
{
    class Customer
    {
        public string CustomerName;
        public string CustomerID;
        public int Age;
        public string Gender;
        public string Password;
    }
    class Bank
    {
        public static void Main(String[] args)
        {
            List<Customer> customerList = new List<Customer>();
            
            int Next = 0;
            do
            {
                List<Customer> customerWithdraw = new List<Customer>();
                List<Customer> customerDeposit = new List<Customer>();
                List<Customer> customerPassword = new List<Customer>();
    
             Console.WriteLine(" Press 1 for Create Account");
            Console.WriteLine(" Press 2 for Withdraw Amount");
            Console.WriteLine(" Press 3 for Deposit Amount");
            Console.WriteLine(" Press 4 for Change Password");
                int App = Convert.ToInt32(Console.ReadLine());
                switch (App)
                {
                    case 1:
                        //Calling CreateCustomer function
                        CreateCustomer(customerList);
                        break;
                    case 2:
                        //Calling WithdrawAmount function
                        WithdrawAmount(customerList);
                        break;
                    case 3:
                        //Calling DepositAmount function
                        DepositAmount(customerList);
                        break;
                    case 4:
                        //Calling ChangePassoword function
                        ChangePassword(customerList);
                        break;
                    default:
                        Console.WriteLine("Not Listed Above");
                        break;
                }
                Console.WriteLine("Do you want to continue this program...Press 5");
                Next = Convert.ToInt32(Console.ReadLine());
            } while (Next == 5);
        }
        //This is a CreateCustomer function
        private static void CreateCustomer(List<Customer> customerList)
        {
            Customer NewCustomer = new Customer();
            Console.WriteLine("Enter Your Name : ");
            NewCustomer.CustomerName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your ID : ");
            NewCustomer.CustomerID =Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            NewCustomer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is Your Gender : ");
            NewCustomer.Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Password : ");
            NewCustomer.Password = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Customer Name : " + NewCustomer.CustomerName);
            Console.WriteLine("Customer ID : " + NewCustomer.CustomerID);
            Console.WriteLine("Age : " + NewCustomer.Age);
            Console.WriteLine("Gender : " + NewCustomer.Gender);
            Console.WriteLine("Password : " + NewCustomer.Password);
            customerList.Add(NewCustomer);   
                Console.WriteLine("The List Of Customer : " + customerList.Count);
        }
        //This is a WithdrawAmount function
        private static void WithdrawAmount(List<Customer> customerList)
        {
            
            int balance = 2000;
            int withdraw = 0;
            string custid= " ";
            Console.WriteLine("Enter Withdraw Your Amount :");
            withdraw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Customer ID :");
            custid = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].CustomerID == custid)
                {
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient Balance...");
                        Console.WriteLine("Your Current Balance Is :" + balance);
                    }
                    else if (withdraw > 1000 && withdraw <= balance)
                    {
                        Console.WriteLine("Collect Your Cash...");
                        balance = balance - withdraw;
                        Console.WriteLine("Your Current Amount Is : " + balance);
                    }
                }
                
            }
            Console.WriteLine("Thank You..." + custid);
        }
        //This is a DepositAmount function
        public static void DepositAmount(List<Customer> customerList)
        {
            int balance = 2000;
            int deposit;
            string custid = "";
            Console.WriteLine("Enter You Deposit Amount :");
            deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Customer ID :");
            custid = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].CustomerID == custid)
                {
                    balance = balance + deposit;
                    Console.WriteLine("Your Amount Has Been Deposited Successfully : " + balance);
                }
                else
                {
                   balance = balance + deposit;
                    Console.WriteLine("Your Balance Amount Is : " + balance);
                }
            }
            Console.WriteLine("Thank You..." + custid);

        }

        public static void ChangePassword(List<Customer> customerList)
        {

            string Oldpassword = "";
            string Newpassword = "";
            string custid="";
            bool isCorrect = false;

            Console.WriteLine("Change Your Password : ");
            Console.WriteLine("Enter Your Customer ID :");
            custid = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Old Password :");
            Oldpassword = Console.ReadLine();

            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].CustomerID == custid && customerList[i].Password == Oldpassword && customerList[i].Password != Newpassword)

                {

                    Console.WriteLine("Enter Your New Password :");
                    Newpassword = Convert.ToString(Console.ReadLine());
                    isCorrect = ValidatePassword(customerList[i], Newpassword);                  
                }
                else if (customerList[i].CustomerID != custid && customerList[i].Password == Oldpassword)
                {

                    Console.WriteLine("Enter The Valid ID !!");
                }
                else if (customerList[i].CustomerID == custid && customerList[i].Password != Oldpassword)
                {
                    Console.WriteLine("Enter The Valid Password !!");
                }
            }
        }
        private static bool ValidatePassword(Customer customer , string Newpassword)
        {

            if (customer.Password != Newpassword)
            {
                Console.WriteLine("Your Password Has Successfully Changed...");
                Console.WriteLine("Thank You..!!");
                return false;
            }
            else
            {
                Console.WriteLine("Your New Password as Same as Old Password !!!");
                return true;
            }
        }
    }

}




