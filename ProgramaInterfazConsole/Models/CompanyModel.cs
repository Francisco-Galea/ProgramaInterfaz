using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaInterfazConsole.Interfaces;

namespace ProgramaInterfazConsole.Models
{
    public abstract class CompanyModel
    {
        public abstract List<IEmployee> getEmployees();
        public void CreateSoftware()
        {
            List<IEmployee> employees = getEmployees();
            foreach(var employee in employees)
            {
                employee.DoWork();
            }
        }        
    }
}
