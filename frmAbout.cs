using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinRibbon_4X
{
    /// <summary>
    /// Same layout as the other two About boxes: version, what this build contains, a paste-ready
    /// snapshot for bug reports, and the two support links.
    /// </summary>
    public partial class frmAbout : Form
    {
        private const string KoFiUrl = "https://ko-fi.com/dwainhsnickles";
        private const string PayPalUrl = "https://paypal.me/YTDPlatinum";

        private readonly string _snapshot;

        public frmAbout()
        {
            InitializeComponent();

            string ribbon = RibbonVersion();
            lblVersion.Text = "Version " + Application.ProductVersion;
            lblRibbon.Text = ribbon;

            _snapshot = string.Join(Environment.NewLine, new[]
            {
                "Ribbon library:   " + ribbon,
                "Runtime:          " + RuntimeInformation.FrameworkDescription,
                "OS:               " + RuntimeInformation.OSDescription.Trim(),
                "App folder:       " + AppContext.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar)
            });

            txtSnapshot.Text = _snapshot;
            lblLinkStatus.Text = string.Empty;
        }

        /// <summary>Version of the WinRibbon.dll this app was built against, read from the file beside it.</summary>
        private static string RibbonVersion()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "WinRibbon.dll");
                Version version = AssemblyName.GetAssemblyName(path).Version;
                return "WinRibbon.dll " + (version == null ? "unknown" : version.ToString());
            }
            catch (Exception ex)
            {
                return "WinRibbon.dll (unavailable: " + ex.GetType().Name + ")";
            }
        }

        /// <summary>
        /// One paste-ready block for a bug report: the app version, the ribbon build, the runtime,
        /// the OS and where this copy runs from.
        /// </summary>
        private void btnCopyDetails_Click(object sender, EventArgs e)
        {
            string text = "WinRibbon 4X " + Application.ProductVersion + Environment.NewLine + _snapshot;

            try
            {
                Clipboard.SetText(text);
                lblLinkStatus.ForeColor = Color.FromArgb(124, 199, 160);
                lblLinkStatus.Text = "Details copied to the clipboard.";
            }
            catch (Exception ex)
            {
                // Another process can hold the clipboard open; tell the user instead of throwing.
                lblLinkStatus.ForeColor = Color.FromArgb(238, 181, 92);
                lblLinkStatus.Text = "Could not copy: " + ex.Message;
            }
        }

        private void btnKoFi_Click(object sender, EventArgs e)
        {
            OpenUrl(KoFiUrl);
        }

        private void btnPayPal_Click(object sender, EventArgs e)
        {
            OpenUrl(PayPalUrl);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                lblLinkStatus.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblLinkStatus.ForeColor = Color.FromArgb(238, 181, 92);
                lblLinkStatus.Text = "Could not open the browser: " + ex.Message;
            }
        }
    }
}
