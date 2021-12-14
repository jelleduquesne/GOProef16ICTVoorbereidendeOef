namespace GOProef16ICTVoorbereidendeOef
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
            this.btnAddButton = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(12, 12);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(78, 23);
            this.btnAddButton.TabIndex = 7;
            this.btnAddButton.Text = "Add Buttons";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.checkBox2);
            this.pnlButtons.Controls.Add(this.checkBox1);
            this.pnlButtons.Location = new System.Drawing.Point(80, 67);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(368, 275);
            this.pnlButtons.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox2.Location = new System.Drawing.Point(109, 231);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 23);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(17, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tweede form openen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Toon tekstje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.pnlButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

