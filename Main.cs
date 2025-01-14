using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace LoadRandom
{
    public partial class Main : Form
    {
        private URLLoader childForm;
        private string[] proxyList;
        private int proxyIndex = 0;
        private int count = 0;
        private Timer proxyChangeTimer;

        public Main()
        {
            InitializeComponent();
            LoadProxyListAsync();
           
        }
 

        private async Task LoadProxyListAsync()
        {
            string url_http = "https://raw.githubusercontent.com/mmpx12/proxy-list/refs/heads/master/http.txt";
            string debugDirectory_http = AppDomain.CurrentDomain.BaseDirectory;
            string filePath_http = Path.Combine(debugDirectory_http, "http.txt");

            string url_https = "https://raw.githubusercontent.com/mmpx12/proxy-list/refs/heads/master/https.txt";
            string debugDirectory_https = AppDomain.CurrentDomain.BaseDirectory;
            string filePath_https = Path.Combine(debugDirectory_https, "http.txt");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(url_http);
                    response.EnsureSuccessStatusCode();

                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                    File.WriteAllBytes(filePath_http, fileBytes);

                    response = await client.GetAsync(url_https);
                    response.EnsureSuccessStatusCode();

                    fileBytes = await response.Content.ReadAsByteArrayAsync();

                    File.WriteAllBytes(filePath_https, fileBytes);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            List<string> combinedProxyList = new List<string>();

            try
            {
                if (File.Exists("http.txt"))
                {
                    string[] proxyList1 = File.ReadAllLines("http.txt");
                    combinedProxyList.AddRange(proxyList1);
                }

                if (File.Exists("https.txt"))
                {
                    string[] proxyList2 = File.ReadAllLines("https.txt");
                    combinedProxyList.AddRange(proxyList2);
                }

                // Shuffle the combined list
                Random rng = new Random();
                int n = combinedProxyList.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    string value = combinedProxyList[k];
                    combinedProxyList[k] = combinedProxyList[n];
                    combinedProxyList[n] = value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading proxy lists: " + ex.Message);
            }
            try
            { 
                proxyList = combinedProxyList.ToArray();
                if (proxyList.Length<1)
                proxyList = File.ReadAllLines("temp.txt");

                Proxy_ProgressBar.Minimum = 0;
                Proxy_ProgressBar.Maximum = proxyList.Length;
                Proxy_ProgressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading proxy list: " + ex.Message);
            }
        }

        private void StartProxyChangeTimer()
        {
            proxyChangeTimer = new Timer();
            proxyChangeTimer.Interval = int.Parse(Duration_TextBox.Text)*1000; 
            proxyChangeTimer.Tick += ProxyChangeTimer_Tick;
            proxyChangeTimer.Start();
        }

        private void ProxyChangeTimer_Tick(object sender, EventArgs e)
        {
           
            if (proxyIndex >= proxyList.Length)
            {
                proxyIndex = 0;
            }

            MainAsync(); 
        }

        private void ChangeProxy(string proxyAddress)
        {
            ChromiumWebBrowser chromeBrowser=new ChromiumWebBrowser();
            Cef.Shutdown(); 
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("proxy-server", "https://" + proxyAddress);
            Cef.Initialize(settings);
            chromeBrowser.Load(chromeBrowser.Address); 
        }

        private string GetCurrentProxy()
        {
            if(proxyIndex> proxyList.Length)
            {
                proxyIndex = 0;
            }
            string str = proxyList[proxyIndex];
            proxyIndex++;

            return str;
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {

            Stop_Button.Enabled = true;
            Run_Button.Enabled = false;
            try
            {
                string urlstr = URL_TextBox.Text;
                MainAsync();

                StartProxyChangeTimer();
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show("Invalid URL format: " + ex.Message);
            }
        }
        public async Task MainAsync()
        {
            for (int i = 0; i < int.Parse(URLCount_TextBox.Text); ) {
                Proxy_ProgressBar.Value = proxyIndex;
                Run_label.Text = proxyIndex.ToString();
                string prx = GetCurrentProxy();
               
                var proxy = new WebProxy(prx);

                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = proxy,
                    UseProxy = true
                };
                using (HttpClient client = new HttpClient(httpClientHandler))
                {
                    try
                    {
                        var response = await client.GetAsync("https://taleblou.ir/");

                        if (response.IsSuccessStatusCode)
                        {
                            childForm = new URLLoader(URL_TextBox.Text, prx, int.Parse(Duration_TextBox.Text));

                            // childForm3.c = c3;
                            childForm.Show();
                            count++;
                            Success_label.Text = count.ToString();
                            i++;
                        }
                        else
                        {
                            Console.WriteLine($"Proxy failed with status code: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }



        }

        private void Stop_Button_Click(object sender, EventArgs e)
        { 
         
            Run_label.Text = "0";
            Success_label.Text = "0";
            proxyIndex = 0;
            proxyChangeTimer.Stop();
            Proxy_ProgressBar.Value = 0;
            Stop_Button.Enabled=false;
            Run_Button.Enabled=true;
        }
    }
}
