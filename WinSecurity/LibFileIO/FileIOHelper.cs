using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace LibFileIO
{
    //[FileIOPermissionAttribute(SecurityAction.Demand, ViewAccessControl = @"C:\", Unrestricted = false)]
    public class FileIOHelper
    {        
        public void WriteToFile(string fileName, string data)
        {
            FileIOPermission perm = new FileIOPermission(FileIOPermissionAccess.Read, @"C:\");
            perm.AddPathList(FileIOPermissionAccess.Read, @"D:\");
            perm.AddPathList(FileIOPermissionAccess.Write, @"D:\");
            perm.Demand();

            StreamWriter stream = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate));
            stream.WriteLine(data);
            stream.Close();
        }


    }
}
