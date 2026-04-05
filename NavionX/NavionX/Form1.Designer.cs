namespace NavionX
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.webViewUI = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.webViewBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewUI)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.webViewUI);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1690, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // webViewUI
            // 
            this.webViewUI.AllowExternalDrop = true;
            this.webViewUI.CreationProperties = null;
            this.webViewUI.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewUI.Location = new System.Drawing.Point(0, 0);
            this.webViewUI.Name = "webViewUI";
            this.webViewUI.Size = new System.Drawing.Size(1690, 55);
            this.webViewUI.TabIndex = 0;
            this.webViewUI.ZoomFactor = 1D;
            this.webViewUI.Click += new System.EventHandler(this.webViewUI_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.webViewBrowser);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 55);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1690, 883);
            this.panelContainer.TabIndex = 1;
            // 
            // webViewBrowser
            // 
            this.webViewBrowser.AllowExternalDrop = true;
            this.webViewBrowser.CreationProperties = null;
            this.webViewBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewBrowser.Location = new System.Drawing.Point(0, 0);
            this.webViewBrowser.Name = "webViewBrowser";
            this.webViewBrowser.Size = new System.Drawing.Size(1690, 883);
            this.webViewBrowser.TabIndex = 0;
            this.webViewBrowser.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 938);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewUI)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContainer;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewUI;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewBrowser;
    }
}

