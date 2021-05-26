using System;
using System.Collections.Generic;
using System.Text;

namespace FCMS.BL
{
    public class Usrs
    {
        private string _UsersName = "MHARK";
        public string UsersName
        {
            get
            {
                return _UsersName;
            }
        }
        private string _UsersPassword = "12345";
        public string UsersPassword
        {
            get
            {
                return _UsersPassword;
            }
        }
        private string _UsersId = "123";
        public string UsersId
        {
            get
            {
                return _UsersId;
            }
        }
    }
}
 public class Users
    {
        public string username;
        public string password;
        private readonly int id;
        public Users(string username, string password, int id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
        }
}
public class Summary
{
    public string Name;
    public double Absent;

    public string getData()
    {
        return this.Name + " has a absent of " + this.Absent;
    }
}
public class List
{
    public string Name1;
    public string Name2;
    public string Name3;
    public string getData()
    {    
        return this.Name1 + this.Name2 + this.Name3;
    }
}