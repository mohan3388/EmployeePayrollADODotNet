namespace EmployeePayroll
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();
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
        }
    }
}