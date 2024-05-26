using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaInterfazConsole.Interfaces;

namespace ProgramaInterfazConsole.Models
{
    public class OutSourcingCompany : CompanyModel
    {
        public override List<IEmployee> getEmployees()
        {
            return new List<IEmployee> { new ProgrammerModel(), new TesterModel() };
        }
    }
}
