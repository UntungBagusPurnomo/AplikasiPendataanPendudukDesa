using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace TestService
{
    public class User
    {
        public int id_user;
        public int nama;
        public int userName;
        public int password;

        public void AddUser()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Admin
    {
        public int id_admin;
        public int nama;
        public int userName;
        public int password;

        public void AddAdmin()
        {
            throw new System.NotImplementedException();
        }
    }
}