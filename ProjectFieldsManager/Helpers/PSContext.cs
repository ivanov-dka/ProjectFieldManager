using Microsoft.ProjectServer.Client;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Helpers
{
    public class PSContext : ProjectContext
    {
        private static bool _isOnline;
        public static bool IsOnline
        {
            get
            {
                if (String.IsNullOrEmpty(_domain))
                    return true;
                return false;
            }
            set
            {
                _isOnline = value;
            }
        }

        private static string _url;
        public static string PSUrl
        {
            get
            {
                if (String.IsNullOrEmpty(_url))
                    return ConfigurationManager.AppSettings["url"];
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        private static string _username;
        public static string UserName
        {
            get
            {
                if (String.IsNullOrEmpty(_username))
                    return ConfigurationManager.AppSettings["username"];
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private static string _password;
        public static string Password
        {
            get
            {
                if (String.IsNullOrEmpty(_password))
                    return ConfigurationManager.AppSettings["password"];
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        private static string _domain;
        public static string Domain
        {
            get
            {
                if (String.IsNullOrEmpty(_domain))
                    return ConfigurationManager.AppSettings["domain"];
                return _domain;
            }
            set
            {
                _domain = value;
            }
        }

        public PSContext() : base(PSUrl)
        {
            if (!IsOnline)
            {
                Credentials = new System.Net.NetworkCredential(UserName, Password, Domain);
            }
            else
            {
                var secure = new SecureString();
                foreach (char c in Password)
                {
                    secure.AppendChar(c);
                }

                Credentials = new SharePointOnlineCredentials(UserName, secure);
            }
        }        
    }
}
