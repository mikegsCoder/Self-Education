using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public interface IVisitor
    {
        void VisitPersonAcc(Person acc);

        void VisitCompanyAcc(Company acc);
    }
}
