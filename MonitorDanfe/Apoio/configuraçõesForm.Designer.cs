namespace MonitorDanfe.Apoio
{
    partial class ConfiguraçõesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguraçõesForm));
            this.PastaEntradatextBox = new System.Windows.Forms.TextBox();
            this.PastaEntradabutton = new System.Windows.Forms.Button();
            this.PastaSaidabutton = new System.Windows.Forms.Button();
            this.PastaSaidatextBox = new System.Windows.Forms.TextBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PastaEntradatextBox
            // 
            this.PastaEntradatextBox.Location = new System.Drawing.Point(12, 25);
            this.PastaEntradatextBox.Name = "PastaEntradatextBox";
            this.PastaEntradatextBox.ReadOnly = true;
            this.PastaEntradatextBox.Size = new System.Drawing.Size(211, 20);
            this.PastaEntradatextBox.TabIndex = 0;
            // 
            // PastaEntradabutton
            // 
            this.PastaEntradabutton.FlatAppearance.BorderSize = 0;
            this.PastaEntradabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastaEntradabutton.Location = new System.Drawing.Point(229, 22);
            this.PastaEntradabutton.Name = "PastaEntradabutton";
            this.PastaEntradabutton.Size = new System.Drawing.Size(50, 23);
            this.PastaEntradabutton.TabIndex = 1;
            this.PastaEntradabutton.Text = "...";
            this.PastaEntradabutton.UseVisualStyleBackColor = true;
            this.PastaEntradabutton.Click += new System.EventHandler(this.PastaEntradabutton_Click);
            // 
            // PastaSaidabutton
            // 
            this.PastaSaidabutton.FlatAppearance.BorderSize = 0;
            this.PastaSaidabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastaSaidabutton.Location = new System.Drawing.Point(229, 68);
            this.PastaSaidabutton.Name = "PastaSaidabutton";
            this.PastaSaidabutton.Size = new System.Drawing.Size(50, 23);
            this.PastaSaidabutton.TabIndex = 3;
            this.PastaSaidabutton.Text = "...";
            this.PastaSaidabutton.UseVisualStyleBackColor = true;
            this.PastaSaidabutton.Click += new System.EventHandler(this.PastaSaidabutton_Click);
            // 
            // PastaSaidatextBox
            // 
            this.PastaSaidatextBox.Location = new System.Drawing.Point(12, 71);
            this.PastaSaidatextBox.Name = "PastaSaidatextBox";
            this.PastaSaidatextBox.ReadOnly = true;
            this.PastaSaidatextBox.Size = new System.Drawing.Size(211, 20);
            this.PastaSaidatextBox.TabIndex = 2;
            // 
            // SalvarButton
            // 
            this.SalvarButton.FlatAppearance.BorderSize = 0;
            this.SalvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarButton.Location = new System.Drawing.Point(207, 100);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(72, 23);
            this.SalvarButton.TabIndex = 4;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pasta onde estão os XML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pasta onde serão salvo as DANFE";
            // 
            // configuraçõesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.PastaSaidabutton);
            this.Controls.Add(this.PastaSaidatextBox);
            this.Controls.Add(this.PastaEntradabutton);
            this.Controls.Add(this.PastaEntradatextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "configuraçõesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuraçõesForm";
            this.Load += new System.EventHandler(this.ConfiguraçõesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PastaEntradatextBox;
        private System.Windows.Forms.Button PastaEntradabutton;
        private System.Windows.Forms.Button PastaSaidabutton;
        private System.Windows.Forms.TextBox PastaSaidatextBox;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}