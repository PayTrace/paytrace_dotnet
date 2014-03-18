using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public static class Methods
    {
        public static string ProcessTransaction { get { return "ProcessTranx"; } }

        public static string CreateCustomer { get { return "CreateCustomer"; } }

        public static string AdjustAmount { get { return "AdjustAmount"; } }

        public static string ExportTransactions { get { return "ExportTranx"; } }

        public static string UpdateCustomer { get { return "UpdateCustomer"; } }
    }
}
