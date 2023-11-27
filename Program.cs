using System;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        
        ModifyProxySettings();

        Console.WriteLine("Proxy settings modified. Press any key to exit.");
        Console.ReadKey();
    }

    static void ModifyProxySettings()
    {
        
        using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true))
        {
            if (registryKey != null)
            {
                // Set the ProxyEnable value to 1 to enable the proxy.
                registryKey.SetValue("ProxyEnable", 1);

                // Optionally, set other proxy-related values as needed.
                // registryKey.SetValue("ProxyServer", "http://yourproxyserver:port");
            }
        }
    }
}
