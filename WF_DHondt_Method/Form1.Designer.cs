namespace WF_DHondt_Method
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
            this.tb_NumberOfParties = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NumberOfMandates = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_GetMandatesOfEachParty = new System.Windows.Forms.Button();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NumberOfParties
            // 
            this.tb_NumberOfParties.Location = new System.Drawing.Point(34, 35);
            this.tb_NumberOfParties.Name = "tb_NumberOfParties";
            this.tb_NumberOfParties.Size = new System.Drawing.Size(147, 20);
            this.tb_NumberOfParties.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumberOfParties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NumberOfMandates";
            // 
            // tb_NumberOfMandates
            // 
            this.tb_NumberOfMandates.Location = new System.Drawing.Point(34, 90);
            this.tb_NumberOfMandates.Name = "tb_NumberOfMandates";
            this.tb_NumberOfMandates.Size = new System.Drawing.Size(147, 20);
            this.tb_NumberOfMandates.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_GetMandatesOfEachParty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_NumberOfParties);
            this.groupBox1.Controls.Add(this.tb_NumberOfMandates);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // bt_GetMandatesOfEachParty
            // 
            this.bt_GetMandatesOfEachParty.Location = new System.Drawing.Point(34, 127);
            this.bt_GetMandatesOfEachParty.Name = "bt_GetMandatesOfEachParty";
            this.bt_GetMandatesOfEachParty.Size = new System.Drawing.Size(147, 23);
            this.bt_GetMandatesOfEachParty.TabIndex = 4;
            this.bt_GetMandatesOfEachParty.Text = "GetVotesOfEachParty";
            this.bt_GetMandatesOfEachParty.UseVisualStyleBackColor = true;
            this.bt_GetMandatesOfEachParty.Click += new System.EventHandler(this.bt_GetMandatesOfEachParty_Click);
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(6, 25);
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Output.Size = new System.Drawing.Size(227, 149);
            this.tb_Output.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Output);
            this.groupBox2.Location = new System.Drawing.Point(245, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NumberOfParties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NumberOfMandates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_GetMandatesOfEachParty;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

