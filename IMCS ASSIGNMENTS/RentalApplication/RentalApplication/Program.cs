using RentalApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApplication
{
    class accept
    {


        public string name,Lname,address;
        public long phoneNumber;
        
        public void Acceptdetails()
        {
            Console.WriteLine("please Enter the First name");
            name = Console.ReadLine();
            Console.WriteLine("please Enter the last name");
            Lname = Console.ReadLine();
            Console.WriteLine("please Enter the phone number");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter the address");
            address = Console.ReadLine();
        }
    }
    class print
    {
       public void printdetails()
        {
            accept a = new accept();
            a.Acceptdetails();
            Console.Out.WriteLine("Your name is " + a.name);
            Console.WriteLine("Your name is " + a.Lname);
            Console.WriteLine("Your name is " + a.phoneNumber);
            Console.WriteLine("Your name is " + a.address);
        }
    }
        class Program
    { 
          public static void Main(string[] args)
        {
             print p = new print();
            p.printdetails();
            Console.ReadLine();

  //      }
  //  }


  //class Application {
  //      private Applicant currentApplicant;
  //      private int applicationId;

   
  //      public Application(int applicationId, Applicant pradeep)
  //      {
  //          this.applicationId = applicationId;
  //          this.currentApplicant = pradeep;
  //      }

  //      public int ApplicationId { get; set; }

  //      public Applicant RentalApplicant { get; set; }

  //      public string GetStatus()
  //      {
  //          int applicationId = 0;

  //          return string.Empty;
        }

    }

    public class Applicant
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long SSN { get; set; }

        public string EMail { get; set; }
    }
}

namespace TestNameSpace
{

    class TestClass {

        private Application currentApplication;

        public void TestMethod()
        {
            Applicant pradeep = new Applicant();
            currentApplication = new Application(2356, pradeep);
            int appId = currentApplication.ApplicationId;
           Applicant currentApplicant = currentApplication.RentalApplicant;

           long currentSSN = currentApplicant.SSN;
            currentApplication.GetStatus();
        }

    }

}