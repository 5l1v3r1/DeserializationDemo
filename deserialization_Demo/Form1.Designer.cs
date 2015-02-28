namespace deserialization_Demo
{
    partial class Form1
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
            this.btnLoadPerson = new System.Windows.Forms.Button();
            this.btnLoadAdmin = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnSettup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadPerson
            // 
            this.btnLoadPerson.Location = new System.Drawing.Point(13, 13);
            this.btnLoadPerson.Name = "btnLoadPerson";
            this.btnLoadPerson.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPerson.TabIndex = 0;
            this.btnLoadPerson.Text = "Load Person";
            this.btnLoadPerson.UseVisualStyleBackColor = true;
            this.btnLoadPerson.Click += new System.EventHandler(this.btnLoadPerson_Click);
            // 
            // btnLoadAdmin
            // 
            this.btnLoadAdmin.Location = new System.Drawing.Point(13, 43);
            this.btnLoadAdmin.Name = "btnLoadAdmin";
            this.btnLoadAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAdmin.TabIndex = 1;
            this.btnLoadAdmin.Text = "Load Admin";
            this.btnLoadAdmin.UseVisualStyleBackColor = true;
            this.btnLoadAdmin.Click += new System.EventHandler(this.btnLoadAdmin_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.ForeColor = System.Drawing.Color.Red;
            this.lblOut.Location = new System.Drawing.Point(13, 85);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 2;
            // 
            // btnSettup
            // 
            this.btnSettup.Location = new System.Drawing.Point(95, 13);
            this.btnSettup.Name = "btnSettup";
            this.btnSettup.Size = new System.Drawing.Size(75, 23);
            this.btnSettup.TabIndex = 3;
            this.btnSettup.Text = "Settup";
            this.btnSettup.UseVisualStyleBackColor = true;
            this.btnSettup.Click += new System.EventHandler(this.btnSettup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.btnSettup);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnLoadAdmin);
            this.Controls.Add(this.btnLoadPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPerson;
        private System.Windows.Forms.Button btnLoadAdmin;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnSettup;
    }
}

