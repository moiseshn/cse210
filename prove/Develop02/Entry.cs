using System.Collections.Generic;
using System.Net;
public class Entry
{
    // public List<string> _entries = new List<string>();
    private string _entries;
    private string _prompts;
    private string _dates;

    //  Constructors
    public Entry()
    {

    }

    // Methods
    public string GetPrompt()
    {
        Prompt myPrompt = new Prompt();
        string pickedPrompt = myPrompt.RandomPrompt();
        Console.WriteLine(pickedPrompt); // It's needed to print it ????????????
        return pickedPrompt;
    }
        public string GetEntry()
    {
        _entries = Console.ReadLine();
        return _entries;
    }
        public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _dates = theCurrentTime.ToShortDateString();
        return _dates;
    }
    public string DisplayEntries()
    {
        // foreach (string i in _entries)
        // {
        //     Console.WriteLine(i);
        // }
        string completeRegistry = ($"Date: {_dates} - {_prompts} {_entries}");
        return completeRegistry;
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