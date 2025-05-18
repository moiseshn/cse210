using System.Collections.Generic;
using System.Net;
public class Entry
{
    public List<string> _entries = new List<string>();

    public void DisplayEntries()
    {
        foreach (string i in _entries)
        {
            Console.WriteLine(i);
        }
    }

    public string GetIPAddress()
    {
        IPHostEntry host;
        string localIp = "?";
        host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList)
        {
            if (ip.AddressFamily.ToString() == "InterNetwork")
            {
                localIp = ip.ToString();
                // Console.WriteLine(localIp);
            }
        }
        return localIp;
    }
}