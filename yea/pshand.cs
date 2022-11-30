using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace yea
{
    public static class pshand
    {
        private static PowerShell ps = PowerShell.Create();

        public static string Command(string command)
        {

            string output = string.Empty;
            ps.AddScript(command);


            PSDataCollection<PSObject> outputCollection = new();
            ps.AddCommand("Out-String");

            IAsyncResult result = ps.BeginInvoke<PSObject, PSObject>(null, outputCollection); 

            ps.EndInvoke(result);

            StringBuilder sb = new StringBuilder();
            foreach(var outputItem in outputCollection)
            {
                sb.AppendLine(outputItem.BaseObject.ToString());

            }
            ps.Commands.Clear();

            return sb.ToString().Trim();


        }




    }
}
