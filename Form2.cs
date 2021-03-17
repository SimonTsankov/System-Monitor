using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Form2 : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        public Form2()
        {
           
        
            InitializeComponent();
            long memKb;
            GetPhysicallyInstalledSystemMemory(out memKb);

            SpecsLabel.Text = getSpecs() + "Ram     :   "+ (memKb / 1024 / 1024)+"GB";
        }

        public static String getSpecs()
        {
            String result = "";
            Console.WriteLine("Started");
            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                scope = new ManagementScope("\\\\DESKTOP-SIMEON\\root\\OpenHardwareMonitor", options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery(@"SELECT * FROM Hardware WHERE NOT HardwareType  LIKE 'SuperIO' and NOT HardwareType LIKE 'HDD' and NOT HardwareType LIKE 'RAM'");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection querryCollection = searcher.Get();
                foreach (ManagementObject m in querryCollection)
                {
                    //result.Add(m["Name"].ToString(),m["Value"].ToString());
                    result += m["HardwareType"] +"   :   " +m["Name"]+"\n";
                }
            }
            catch
            {
                Console.WriteLine("shid");
            }
            return result;
        }
    }
}
