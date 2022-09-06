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
                Console.WriteLine("1. To Insert the Data in Data Base \n2. Retrive the data in database\n3. Update salary\n4. Delete data\n5. Get Data in Range");
                Console.WriteLine("Enter the Above Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeeModel model = new EmployeeModel();
                        model.EmployeeName = "Terrisa";
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
                    case 3:
                        EmployeeModel model1 = new EmployeeModel();
                        model1.EmployeeName = "Mohan";
                        model1.BasicPay = 15001;
                        repo.UpdateEmp(model1);
                        break;
                    case 4:
                        EmployeeModel model2 = new EmployeeModel();

                        repo.DeleteEmployee(1);
                        break;
                    case 5:
                         repo.GetDataInDateRange();
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