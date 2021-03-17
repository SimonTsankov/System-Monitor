using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;
using System.Management;
using System.Runtime.InteropServices;

namespace Monitor

{

    public partial class Form1 : Form
    {

        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");

        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                String temp = "";
                Dictionary<string, int> temperatures = getTempsCPU();
                foreach (KeyValuePair<string, int> author in temperatures.OrderBy(key => key.Key))
                {
                    temp += author.Key + "  :   " + author.Value + "\n";        
                }
                CPULable.Text = temp;
            }
            catch (Exception)
            {
                Console.WriteLine("Shit");
                CPULable.Text = "error";
            }

            int usageCPU = (int)perfCPUCounter.NextValue();
            percentageCPUusage.Text = $"{usageCPU}  %";
            RamLable.Text = "RAM Available: " + (int)perfMemCounter.NextValue() + "   MB";
            UpTimeLabel.Text = "System up time: " + (int)perfSystemCounter.NextValue() / 60 / 60 + "  Hours";
            setPBar(usageCPU, ref pBarCPU);

            Dictionary<String, Decimal> usageGPU = getLoadGPU();
            String usages = "";
            foreach(KeyValuePair<string, Decimal> author in usageGPU)
            {
                usages += author.Key + "  :   " + Math.Round(author.Value,2) + " % \n";
            }
            GPULable.Text = usages;
            percantageGPUusage.Text = usageGPU["GPU Core"].ToString();
            setPBar(Decimal.ToInt32(usageGPU["GPU Core"]), ref GPUpBar);



        }


        public static Dictionary<String, int> getTempsCPU()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            Console.WriteLine("Started");
            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                scope = new ManagementScope("\\\\DESKTOP-SIMEON\\root\\OpenHardwareMonitor", options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery(@"SELECT Name, Value FROM Sensor WHERE Name LIKE 'CPU%'  and SensorType LIKE 'Temperature'");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection querryCollection = searcher.Get();
                foreach (ManagementObject m in querryCollection)
                {
                    result.Add(m["Name"].ToString(), Int32.Parse(m["Value"].ToString()));
                }
            }
            catch
            {
                Console.WriteLine("shid");
            }
            return result;
        }
        public static void setPBar(int usage, ref ProgressBar pBarCPU)
        {
            try
            {
                pBarCPU.SetState(1);
                if (usage > 40)
                {
                    pBarCPU.SetState(3);
                    if (usage > 80)
                        pBarCPU.SetState(2);
                }
                pBarCPU.Value = usage;
            }
            catch
            { }
        }

    

    public static Dictionary<String, Decimal> getLoadGPU() {
            Dictionary<string, Decimal> result = new Dictionary<string, Decimal>();     
            Console.WriteLine("Started");
            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                scope = new ManagementScope("\\\\DESKTOP-SIMEON\\root\\OpenHardwareMonitor", options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery(@"SELECT Value, Name, Index FROM  Sensor WHERE Name LIKE 'GPU%' and SensorType LIKE 'Load'");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection querryCollection = searcher.Get();
                foreach (ManagementObject m in querryCollection)
                {
                    result.Add(m["Name"].ToString(), Decimal.Parse(m["Value"].ToString()));
                }
            }
            catch
            {
                Console.WriteLine("shid");
            }
            return result;
        }

        private void SpecsButtton_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

    }
  
    public static class ModifyProgressBarColor
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
