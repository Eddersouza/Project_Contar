using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.App
{
    public class AccountPayableApp
        : AccountPayableAppContract
    {
        public bool Add(
            string name,
            DateTime? dueDate,
            decimal amount,
            ref List<string> errors)
        {
            AccountPayable account = new AccountPayable(
                name, 
                dueDate.Value, 
                amount);

            return false;
        }
    }
}
