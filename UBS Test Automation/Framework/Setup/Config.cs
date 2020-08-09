using System;
using System.Collections.Generic;
using System.Text;

namespace UBS_Test_Automation.Framework.Setup
{

    public class Config
    {
        public Users Users { get; set; }
        public Timeouts Timeouts { get; set; }
    }

    public class Users
    {
        public Validuser ValidUser { get; set; }
        public Invaliduser InvalidUser { get; set; }
    }

    public class Validuser
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Invaliduser
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Timeouts
    {
        public TimeSpan WaitForElementExists { get; set; }
        public TimeSpan WaitForElementToBeInteractable { get; set; }
    }

}
