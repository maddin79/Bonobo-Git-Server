using System;
using System.Web;
using System.Xml.Serialization;

namespace Bonobo.Git.Server.Configuration
{
    [XmlRootAttribute(ElementName = "Configuration", IsNullable = false)]
    public class UserConfiguration : ConfigurationEntry<UserConfiguration>
    {      
        public bool AllowAnonymousPush { get; set; }
        public string Repositories { get; set; }
        public bool AllowUserRepositoryCreation { get; set; }
        public bool AllowAnonymousRegistration { get; set; }

        // Attribute for the Active Directory Domain
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        public string ADDomain { get; set; }

        // Attribute for the Active Directory service user
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        public string ADServiceUser { get; set; }

        // Attribute for the Active Directory service user password
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        public string ADServiceUserPassword { get; set; }
        

        public static void Initialize()
        {
            if (IsInitialized())
                return;

            Current.Repositories = HttpContext.Current.Server.MapPath("~/App_Data/Repositories");
            Current.Save();
        }


        private static bool IsInitialized()
        {
            return !String.IsNullOrEmpty(Current.Repositories);
        }
    }
}