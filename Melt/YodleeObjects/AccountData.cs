using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Melt.YodleeObjects
{
    public class AccountData
    {
        public string CONTAINER { get; set; }
        public string isManual { get; set; }
        public string isAsset { get; set; }
        public DateTime lastUpdated { get; set; }
        public Balance currentBalance { get; set; }
        public Balance availableBalance { get; set; }
        public Balance availableCredit { get; set; }
        public string displayedName { get; set; }
        public string id { get; set; }
        public Balance balance { get; set; }
        public string accountName { get; set; }
        public string accountNumber { get; set; }
        public string aggregationSource { get; set; }
        public Dataset dataset { get; set; }
        public string providerName { get; set; }
        public string accountStatus { get; set; }
        public string accountType { get; set; }
        public string providerId { get; set; }
        public string includeInNetWorth { get; set; }
        public DateTime createdDate { get; set; }
        public string providerAccountId { get; set; }
    }

    public struct Balance
    {
        public double amount { get; set; }
        public string currency { get; set; }
    }

    public struct Dataset
    {
        public DateTime lastUpdateAttempt { get; set; }
        public string updateEligibility { get; set; }
        public string name { get; set; }
        public DateTime lastUpdated { get; set; }
        public string additionalStatus { get; set; }
    }
}

