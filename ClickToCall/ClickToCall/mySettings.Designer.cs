namespace ClickToCall
{
    partial class mySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mySettings));
            this.DOMAIN_TXT = new System.Windows.Forms.TextBox();
            this.SRC_TXT = new System.Windows.Forms.TextBox();
            this.API_KEY_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.startOnBoot = new System.Windows.Forms.CheckBox();
            this.autoAnswer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DOMAIN_TXT
            // 
            this.DOMAIN_TXT.Location = new System.Drawing.Point(147, 23);
            this.DOMAIN_TXT.Name = "DOMAIN_TXT";
            this.DOMAIN_TXT.Size = new System.Drawing.Size(100, 20);
            this.DOMAIN_TXT.TabIndex = 0;
            // 
            // SRC_TXT
            // 
            this.SRC_TXT.Location = new System.Drawing.Point(147, 49);
            this.SRC_TXT.Name = "SRC_TXT";
            this.SRC_TXT.Size = new System.Drawing.Size(100, 20);
            this.SRC_TXT.TabIndex = 1;
            // 
            // API_KEY_TXT
            // 
            this.API_KEY_TXT.Location = new System.Drawing.Point(147, 76);
            this.API_KEY_TXT.Name = "API_KEY_TXT";
            this.API_KEY_TXT.Size = new System.Drawing.Size(100, 20);
            this.API_KEY_TXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domain Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Extension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startOnBoot
            // 
            this.startOnBoot.AutoSize = true;
            this.startOnBoot.Location = new System.Drawing.Point(147, 103);
            this.startOnBoot.Name = "startOnBoot";
            this.startOnBoot.Size = new System.Drawing.Size(90, 17);
            this.startOnBoot.TabIndex = 7;
            this.startOnBoot.Text = "Start On Boot";
            this.startOnBoot.UseVisualStyleBackColor = true;
            // 
            // autoAnswer
            // 
            this.autoAnswer.AutoSize = true;
            this.autoAnswer.Location = new System.Drawing.Point(147, 127);
            this.autoAnswer.Name = "autoAnswer";
            this.autoAnswer.Size = new System.Drawing.Size(86, 17);
            this.autoAnswer.TabIndex = 8;
            this.autoAnswer.Text = "Auto Answer";
            this.autoAnswer.UseVisualStyleBackColor = true;
            // 
            // mySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.autoAnswer);
            this.Controls.Add(this.startOnBoot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.API_KEY_TXT);
            this.Controls.Add(this.SRC_TXT);
            this.Controls.Add(this.DOMAIN_TXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mySettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DOMAIN_TXT;
        private System.Windows.Forms.TextBox SRC_TXT;
        private System.Windows.Forms.TextBox API_KEY_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox startOnBoot;
        private System.Windows.Forms.CheckBox autoAnswer;
    }
}