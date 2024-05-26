using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaInterfazConsole.Interfaces;

namespace ProgramaInterfazConsole.Models
{
    public class GameDevCompany : CompanyModel
    {
        public override List<IEmployee> getEmployees()
        {
            return new List<IEmployee> { new DesignerModel(), new ProgrammerModel(), new TesterModel() };
        }
    }
}
