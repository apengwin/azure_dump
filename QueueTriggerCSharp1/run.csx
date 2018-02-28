using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
public static void Run(string mySbMsg, string funcfile, string datafile, out string outputfile,
    out string statusfile, TraceWriter log)
{
    string CONDA_PYTHON_PATH = @"D:\home\site\wwwroot\conda\Miniconda2";
    string PYTHON = System.IO.Path.Combine(CONDA_PYTHON_PATH, "python");
    Process p = new Process();
    p.StartInfo.FileName = PYTHON;
    p.StartInfo.Arguments = "D:\\home\\site\\wwwroot\\ohohohoho\\run.py";
    //p.Start();
  //  p.WaitForExit();
//    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
 //   String sMacAddress = string.Empty;
 /*
    foreach (NetworkInterface adapter in nics)
    {
        if (sMacAddress == String.Empty)// only return MAC Address from first card  
        {
            IPInterfaceProperties properties = adapter.GetIPProperties();
            sMacAddress = adapter.GetPhysicalAddress().ToString();
        }
    }
*/
    outputfile = "foo";
    statusfile = "foo";
    log.Info($"C# Queue Done ");
}
