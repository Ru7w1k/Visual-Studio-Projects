using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSQL
{
    public static class SQLUtil
    {
        [SqlFunction]
        public static string AppendHello(string message)
        {
            return message + " Hello";
        }
    }
}
