using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavePhoneNumber
{
    class Config
    {
        public int accountNumber;
        public List<Account> accounts;
        public bool useProxy;
        public string proxyIP;
        public string proxyPort;
    }
    class Account
    {
        public int username;
        public int password;
        public int taskNumber;
        public List<string> taskFiles;
    }
    class TNTask
    {
        string targetNumber;
    }
}
