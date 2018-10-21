using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melt.YodleeObjects;
using System.Data.SqlClient;

namespace Melt.Data
{
    public class Procs
    {
        private ISqlAccess access;

        public Procs(ISqlAccess sqlAccess)
        {
             access = sqlAccess;
        }
        public void InsertUserAccount(Account accountData, string userId)
        {            
            foreach (AccountData account in accountData.account)
            {                
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("UserID", userId));
                parameters.Add(new SqlParameter("ProviderName", account.providerName));
                parameters.Add(new SqlParameter("CurrentBalance", account.currentBalance.amount));
                parameters.Add(new SqlParameter("AvailableCredit", account.availableCredit.amount));
                parameters.Add(new SqlParameter("AccountType", account.accountType));
                parameters.Add(new SqlParameter("AccountNumber", account.accountNumber));
                parameters.Add(new SqlParameter("AccountName", account.accountName));
                parameters.Add(new SqlParameter("LoginName", account.providerAccountId));

                access.ExecuteNonQuery("dbo.UserAccount_Set", parameters);
            }
        }
    }
}
