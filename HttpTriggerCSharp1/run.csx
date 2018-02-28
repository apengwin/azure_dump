using System.Net;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Diagnostics;


public static string[] GetPhysicalAddresses()
{
    var result = new List<string>();
    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
    foreach (NetworkInterface adapter in interfaces)
    {
        PhysicalAddress address = adapter.GetPhysicalAddress();
        byte[] bytes = address.GetAddressBytes();
        if (bytes.Length == 0) continue;

        var mac = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            mac.Append(bytes[i].ToString("X2"));
            if (i != bytes.Length - 1) mac.Append("-");
        }

        result.Add(mac.ToString());
    }
    return result.ToArray();
}

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    //log.Info("C# HTTP trigger function processed a request.");

    // parse query parameter
    //System.Threading.Thread.Sleep(30 * 1000);
    string TEMP = @"D:\local\Temp";
    string PYTHON_MODULE_PATH = System.IO.Path.Combine(TEMP, "modules");
    string CONDA_PYTHON_PATH = @"D:\home\site\wwwroot\conda\Miniconda2";
    string PYTHON = System.IO.Path.Combine(CONDA_PYTHON_PATH, "python");

    //p.StartInfo.Arguments = "D:\\home\\site\\wwwroot\\gojira\\run.py";
        Process p = new Process();
        p.StartInfo.FileName = PYTHON;
        p.StartInfo.Arguments = "D:\\home\\site\\wwwroot\\ohohohoho\\run.py";
        p.Start();
        p.WaitForExit();
    return req.CreateResponse(HttpStatusCode.OK, "succ " + string.Join(",", GetPhysicalAddresses()));
}