namespace NavegadorJael
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAtras = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIr = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(14, 57);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(56, 31);
            this.buttonAtras.TabIndex = 0;
            this.buttonAtras.Text = "⬅";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.White;
            this.txtUrl.Location = new System.Drawing.Point(85, 20);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(715, 26);
            this.txtUrl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonIr);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.buttonAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // buttonIr
            // 
            this.buttonIr.Location = new System.Drawing.Point(4, 16);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(75, 35);
            this.buttonIr.TabIndex = 2;
            this.buttonIr.Text = "Ir";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.button2_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 100);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(800, 350);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            this.webView21.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView21_SourceChanged);
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Navion ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonIr;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

