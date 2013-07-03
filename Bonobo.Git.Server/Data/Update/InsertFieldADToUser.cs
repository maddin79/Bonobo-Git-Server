using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Bonobo.Git.Server.Data.Update
{
    // This class updates the database table User with a boolean column 
    // AD = Active Directory, which indicates if the user authentication
    // is performed by an LDAP server.
    // Added by: Martin Drees, CDH-Computing www.cdh-computing.de
    public class InsertFieldADToUser : IUpdateScript
    {
        public string Command
        {
            get
            {
                return @"ALTER TABLE [User] ADD COLUMN [AD] BOOL NOT NULL DEFAULT 0;";
            }
        }

        // It is not possible in plain sql to determine if a column "AD" exists in the user table 
        // and when not to add this column. This precondition tests if the column "AD" exists and
        // returned "null" if not and "SELECT Count(*) = 0 FROM [User]" othwerwise.
        // Maybe someone finds a better solution :) .
        public string Precondition
        {
            get {
                string ret = null;

                using (var ctx = new BonoboGitServerContext())
                using (var connection = ctx.Database.Connection)
                using (var command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = @"SELECT * FROM [User] limit 1";
                    DbDataReader reader = command.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; ++i)
                    {
                        string name = reader.GetName(i);
                        if (name.ToUpper().Equals("AD"))
                        {
                            ret = @"SELECT Count(*) = 0 FROM [User]";
                            break;
                        }
                    }
                    reader.Close();
                }
                
                return ret;
            }
        }
    }
}