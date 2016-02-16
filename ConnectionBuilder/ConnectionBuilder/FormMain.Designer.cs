namespace ConnectionBuilder
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.textBoxProvider = new System.Windows.Forms.TextBox();
            this.buttonMakeString = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(615, 20);
            this.textBoxConnection.TabIndex = 0;
            // 
            // textBoxProvider
            // 
            this.textBoxProvider.Location = new System.Drawing.Point(12, 38);
            this.textBoxProvider.Name = "textBoxProvider";
            this.textBoxProvider.Size = new System.Drawing.Size(615, 20);
            this.textBoxProvider.TabIndex = 1;
            // 
            // buttonMakeString
            // 
            this.buttonMakeString.Location = new System.Drawing.Point(12, 77);
            this.buttonMakeString.Name = "buttonMakeString";
            this.buttonMakeString.Size = new System.Drawing.Size(341, 23);
            this.buttonMakeString.TabIndex = 2;
            this.buttonMakeString.Text = "Make Connection String";
            this.buttonMakeString.UseVisualStyleBackColor = true;
            this.buttonMakeString.Click += new System.EventHandler(this.buttonMakeString_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 106);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(341, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Test Connection String";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 187);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonMakeString);
            this.Controls.Add(this.textBoxProvider);
            this.Controls.Add(this.textBoxConnection);
            this.Name = "FormMain";
            this.Text = "Connection String Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.TextBox textBoxProvider;
        private System.Windows.Forms.Button buttonMakeString;
        private System.Windows.Forms.Button buttonConnect;
    }
}

