using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navion_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 1. Inicializamos el motor de la interfaz (arriba)
            await webView21.EnsureCoreWebView2Async(null);

            // 2. Cargamos tu archivo HTML (asegúrate de que esté en la carpeta del proyecto)
            string rutaHtml = System.IO.Path.Combine(Application.StartupPath, "index.html");

            if (System.IO.File.Exists(rutaHtml))
            {
                webView21.CoreWebView2.Navigate("file:///" + rutaHtml);
            }
            else
            {
                // Por si acaso no encuentra el archivo, para que no lo veas vacío
                webView21.CoreWebView2.NavigateToString("<h1 style='background:linear-gradient(to right, #4facfe, #00f2fe); color:white; padding:10px;'>Navion UI Lista</h1>");
            }

            // 3. Escuchamos los clics que vienen del HTML
            webView21.WebMessageReceived += (s, args) => {
                string mensaje = args.TryGetWebMessageAsString();

                if (mensaje.StartsWith("nav:"))
                {
                    string url = mensaje.Replace("nav:", "");
                    // Aquí usamos el de abajo para navegar
                    webViewBrowser1.Navigate(url.Contains(".") ? (url.StartsWith("http") ? url : "https://" + url) : "https://www.google.com/search?q=" + url);
                }
            };
        }
    }
}
