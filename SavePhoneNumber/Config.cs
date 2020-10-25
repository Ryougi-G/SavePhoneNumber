using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace SavePhoneNumber
{
    class Config
    {
        public int accountNumber {
            get
            {
                return accounts.Count;
            }
        }
        public List<Account> accounts;
        public int timeToExcuteTasks;
        public bool useProxy;
        public WebProxy Proxy;
        public Config(List<Account> acts,int timeToExcuteTasks)
        {
            accounts = acts;
            this.timeToExcuteTasks = timeToExcuteTasks;
            useProxy = false;
        }
        public Config(List<Account> acts, int timeToExcuteTasks,WebProxy proxy)
        {
            accounts = acts;
            this.timeToExcuteTasks = timeToExcuteTasks;
            useProxy = true ;
            proxy = Proxy;
        }
    }
    class Account
    {
        public string username;
        public string password;
        public int taskNumber;
        public List<TNTask> Tasks;
        public Account(string UserName,string Password,List<TNTask> tasks)
        {
            username = UserName;
            password = Password;
            Tasks = tasks;
        }
    }
    class TNTask
    {
        public string targetNumber;
        public List<string> messages;
        public TNTask(string targetNum,List<string> msg)
        {
            targetNumber = targetNum;
            messages = msg;
        }
    }
    public class ConfigReader
    {
        static Config ReadConfig(string FilePos) 
        {
            if (!File.Exists(FilePos))
            {
                throw new FileNotFoundException("Config File Doesn't exist");
            }
            string[] FileStr = File.ReadAllLines(FilePos);

        }
    }
}
