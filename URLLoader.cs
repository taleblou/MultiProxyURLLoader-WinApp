using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LoadRandom
{
    public partial class URLLoader : Form
    {

        private string proxy;
        private string url;
        private int time;
        private ChromiumWebBrowser chromeBrowser;  
        private Timer proxyChangeTimer;
      

        private void InitializeChromium()
        {
            try
            {
                var settings = new CefSettings();
                Cef.Initialize(settings);
            }
            catch (Exception e) { }
            chromeBrowser = new ChromiumWebBrowser(this.url);
            chromeBrowser.IsBrowserInitializedChanged += OnBrowserInitializedChanged;
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
        private void OnBrowserInitializedChanged(object sender, EventArgs e)
        {
            if (chromeBrowser.IsBrowserInitialized)
            {
               
                ChangeProxy(this.proxy);
            }
        }

        private void ChangeProxy(string proxyAddress)
        {
            var requestContext = chromeBrowser.GetBrowser().GetHost().RequestContext;
            var proxySettings = new Dictionary<string, object>
            {
                ["mode"] = "fixed_servers",
                ["server"] = proxyAddress
            };

            bool success = requestContext.SetPreference("proxy", proxySettings, out string errorMessage);
            if (!success)
            {
                MessageBox.Show("Error setting proxy: " + errorMessage);
            }
        }
        public URLLoader(string url, string proxy, int time)
        {
            this.url = url;
            this.proxy = proxy;
            this.time = time;
            InitializeComponent();
            InitializeChromium();
            StartProxyChangeTimer();

        } 
        private void StartProxyChangeTimer()
        {
            proxyChangeTimer = new Timer();
            proxyChangeTimer.Interval = this.time *1000; 
            proxyChangeTimer.Tick += ProxyChangeTimer_Tick;
            proxyChangeTimer.Start();
        }

        private void ProxyChangeTimer_Tick(object sender, EventArgs e)
        {
            this.Close(); 

        }

        private void URLLoader_Load(object sender, EventArgs e)
        {

        }
    }
}
