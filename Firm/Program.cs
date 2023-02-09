namespace Firm
{
    internal class Program
    {
        static void Main()
        {
            IEmployeeIncludes employeeIncludes = new Employee();

            Console.WriteLine(employeeIncludes.EmployeeIncludes(new Director()));
            Console.WriteLine(employeeIncludes.EmployeeIncludes(new Accountant()));
            Console.WriteLine(employeeIncludes.EmployeeIncludes(new Worker()));
        }
    }
}