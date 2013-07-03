﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Bonobo.Git.Server.App_GlobalResources;

namespace Bonobo.Git.Server.Models
{
    public class GlobalSettingsModel
    {
        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_AllowAnonymousPush")]
        public bool AllowAnonymousPush { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_AllowAnonymousRegistration")]
        public bool AllowAnonymousRegistration { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_AllowUserRepositoryCreation")]
        public bool AllowUserRepositoryCreation { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Validation_Required")]
        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_RepositoryPath")]
        public string RepositoryPath { get; set; }

        // Attribute for the Active Directory Domain
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_ADDomain")]
        public string ADDomain { get; set; }

        // Attribute for the Active Directory service user
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_ADServiceUser")]
        public string ADServiceUser { get; set; }

        // Attribute for the Active Directory service user password
        // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
        [Display(ResourceType = typeof(Resources), Name = "Settings_Global_ADPassword")]
        public string ADServiceUserPassword { get; set; }
    }
}