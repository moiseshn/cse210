using System.Collections.Generic;
using System.Net;
public class Entry
{
    public List<string> _entriesList = new List<string>();
    public string _entry;
    public string _prompt;
    public string _date;
    public string _localIp;

    //  Constructors
    public Entry()
    {

    }

    // Methods
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }
    public string GetPrompt()
    {
        Prompt myPrompt = new Prompt();
        string _prompt = myPrompt.RandomPrompt();
        Console.WriteLine(_prompt);
        return _prompt;
    }
    public string GetEntry()
    {
        Console.Write("> ");
        _entry = Console.ReadLine();
        return _entry;
    }
    public string GetIPAddress()
    {
        IPHostEntry host;
        string _localIp = "?";
        host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList)
        {
            if (ip.AddressFamily.ToString() == "InterNetwork")
            {
                _localIp = ip.ToString();
                // Console.WriteLine(localIp);
            }
        }
        return _localIp;
    }
    public List<string> EntryToList(string date, string prompt, string entry, string localIp)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
        _localIp = localIp;
        _entriesList.Add($"{date}~{prompt}~{entry}~{localIp}");
        // return $"Date: {date} - {prompt} {entry}";
        return _entriesList;
    }
    public void ShowEntries()
    {
        foreach (string i in _entriesList)
        {
            string[] parts = i.Split("~");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            string localIp = parts[3];

            Console.WriteLine($"Date: {date}, Prompt: {prompt}, Entry: {entry}, Local IP: {localIp}");
        }
    }
}