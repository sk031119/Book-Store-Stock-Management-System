using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Stock_Management_System
{
    public static class EmployeeDB
    {
        private const string Dir = @"C:\Users\galaa\Downloads\Ari\C#\Files\";
        private const string Path = Dir + "Employees.csv";
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Employee employee = new Employee();
                employee.FName = columns[0];
                employee.LName = columns[1];
                employee.Username = columns[2];
                employee.Password = columns[3];
                employee.Role = (UserRole)Enum.Parse(typeof(UserRole), columns[4]);
                employees.Add(employee);
            }
            textIn.Close();
            return employees;
        }
        public static void SaveEmployees(List<Employee> employees)
        {
            StreamWriter textOut = new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Employee employee in employees)
            {
                textOut.Write(employee.FName + ",");
                textOut.Write(employee.LName + ",");
                textOut.Write(employee.Username + ",");
                textOut.Write(employee.Password + ",");
                textOut.WriteLine(employee.Role);
            }
            textOut.Close();
        }
    }
}
