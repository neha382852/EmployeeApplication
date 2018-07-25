using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static Employee []employee;
        static void Main(string[] args)
        {
            
            string exit = "1";
            Console.WriteLine("Enter no of employees to be added");
            int no = int.Parse(Console.ReadLine());
            employee = new Employee[no];
            for(int i=0;i< no && exit.Equals("1") && !exit.Equals("exit");i++)
            { 
                employee[i] = new Employee();
                
                employee[i].add_employee();
                Console.WriteLine("Do you want to exit 1:type 1 to continue 2: type exit to exit ");
                
                exit = Console.ReadLine();
            }
            
        }
    }
}
