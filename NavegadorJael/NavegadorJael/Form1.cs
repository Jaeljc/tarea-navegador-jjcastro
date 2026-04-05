using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorJael
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Mtor de busqueda
            if (webView21 != null && webView21.CoreWebView2 == null)
            {
                await webView21.EnsureCoreWebView2Async(null);
            }

            string url = txtUrl.Text;

            if (!url.StartsWith("http"))
            {
                url = "https://" + url;
            }

            try
            {
                webView21.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al navegar: " + ex.Message);
            }

        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            // Actualiza la barra con la URL
            txtUrl.Text = webView21.Source.ToString();
        }
    }
}
