namespace EmployeePayroll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee payroll");
            EmployeeRepo repo = new EmployeeRepo();




            bool check = true;

            while (check)
            {
                Console.WriteLine("1. To Insert the Data in Data Base \n2. Retrive the data in database");
                Console.WriteLine("Enter the Above Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeeModel model = new EmployeeModel();
                        model.EmployeeName = "Mohan";
                        model.PhoneNumber = "7898625487";
                        model.Address = "green valley";
                        model.Department = "CSE";
                        model.Gender = "M";
                        model.BasicPay = 152;
                        model.Deductions = 400;
                        model.TaxablePay = 140;
                        model.Tax = 1000;
                        model.NetPay = 130;
                        model.StartDate = DateTime.Now;
                        model.City = "Bhilai";
                        model.Country = "India";
                        repo.AddEmployee(model);
                        break;
                    case 2:
                         repo.GetAllEmployees();
                       
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter the Correct option");
                        break;
                }
            }

        }
    }
}
