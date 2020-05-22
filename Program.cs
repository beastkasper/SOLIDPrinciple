using System;
using System.Dynamic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
namespace SOLID_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Models d = new Models();
            //d.ModelName();
            //Employee empl = new Employee();
            //empl.Add();
            //EmployeeReport emRep = new EmployeeReport();
            //emRep.GenerateReport();

            //List<Employee> list = new List<Employee>();

            //list.Add(new JuniorEmployee());
            //list.Add(new SeniorEmployee());

            //foreach (Employee emp in list)
            //{
            //    emp.GetEmployeeDetails(985);
            //}
            ////}
        }


        //class Apple
        //{
        //    public string Brend { get; set; }
        //}

        //class Product
        //{
        //    public string MacBook{ get; set; }
        //    public string Iphone { get; set; }
        //}
        //class Models
        //{
        //    public void  ModelName()
        //    {
        //        Product P = new Product();
        //        Apple A = new Apple();
        //        A.Brend = "Apple";
        //        P.Iphone = "iphone S8";
        //        Console.WriteLine($"Brend Company: {A.Brend}");
        //        Console.WriteLine($"Model name: {P.Iphone}");
        //    }
        //}

        //public class IEmployeeReport
        //{
        //    // Метод для создания отчета
        //    public virtual void GenerateReport(Employee em)
        //    {
               
        //    }
        //}

        //public class EmployeeCSVReport : IEmployeeReport
        //{
        //    public override void GenerateReport(Employee em)
        //    {
                
        //    }
        //}

        //public class EmployeePDFReport : IEmployeeReport
        //{
        //    public override void GenerateReport(Employee em)
        //    {
               
        //    }
        }

    //public interface IEmployee
    //{
    //    string GetEmployeeDetails(int employeeId);
    //}

    //public interface IWork
    //{
    //    string GetWorkDetails(int employeeId);
    //}

    //public class SeniorEmployee : IWork, IEmployee
    //{
    //    public string GetWorkDetails(int employeeId)
    //    {
    //        return "Senior Work";
    //    }

    //    public string GetEmployeeDetails(int employeeId)
    //    {
    //        return "Senior Employee";
    //    }
    //}

    //public class JuniorEmployee : IEmployee
    //{
    //    public string GetEmployeeDetails(int employeeId)
    //    {
    //        return "Junior Employee";
    //    }
    //}

    //interface ICarsModels
    //{
    //    public string z5 { get; set; }
    //    public string corona { get; set; }
    //}

    //interface ICarsName
    //{

    //}

    //interface IcarsPrice
    //{

    //}

    //interface ICarsCountry
    //{

    //}

    public interface IMessenger
    {
        void Send();
    }

    public class Email : IMessenger
    {
        public void Send()
        {
            // код для отправки email-письма
        }
    }

    public class SMS : IMessenger
    {
        public void Send()
        {
            // код для отправки SMS
        }
    }

    // Уведомление
    public class Notification
    {
        private IMessenger _messenger;
        public Notification()
        {
            _messenger = new Email();
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }
}