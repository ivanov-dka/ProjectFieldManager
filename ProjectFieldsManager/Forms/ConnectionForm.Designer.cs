namespace ProjectFieldsManager
{
    partial class ConnectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbOnPremise = new System.Windows.Forms.RadioButton();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lDomain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose how would like to connect to Project:";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(190, 342);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(135, 41);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Checked = true;
            this.rbOnline.Location = new System.Drawing.Point(80, 68);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(118, 21);
            this.rbOnline.TabIndex = 2;
            this.rbOnline.TabStop = true;
            this.rbOnline.Text = "Project Online";
            this.rbOnline.UseVisualStyleBackColor = true;
            this.rbOnline.CheckedChanged += new System.EventHandler(this.rbOnline_CheckedChanged);
            // 
            // rbOnPremise
            // 
            this.rbOnPremise.AutoSize = true;
            this.rbOnPremise.Location = new System.Drawing.Point(80, 108);
            this.rbOnPremise.Name = "rbOnPremise";
            this.rbOnPremise.Size = new System.Drawing.Size(147, 21);
            this.rbOnPremise.TabIndex = 3;
            this.rbOnPremise.Text = "Project OnPremise";
            this.rbOnPremise.UseVisualStyleBackColor = true;
            this.rbOnPremise.CheckedChanged += new System.EventHandler(this.rbOnPremise_CheckedChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(156, 204);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(253, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(156, 245);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(253, 22);
            this.tbPass.TabIndex = 5;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(156, 283);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(253, 22);
            this.tbDomain.TabIndex = 6;
            this.tbDomain.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // lDomain
            // 
            this.lDomain.AutoSize = true;
            this.lDomain.Location = new System.Drawing.Point(77, 283);
            this.lDomain.Name = "lDomain";
            this.lDomain.Size = new System.Drawing.Size(60, 17);
            this.lDomain.TabIndex = 9;
            this.lDomain.Text = "Domain:";
            this.lDomain.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "PWA url:";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(156, 166);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(253, 22);
            this.tbUrl.TabIndex = 10;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.rbOnPremise);
            this.Controls.Add(this.rbOnline);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionForm";
            this.Text = "Choose Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbOnPremise;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbPass;
    }
}

