namespace MonitorDanfe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.Processador = new System.ComponentModel.BackgroundWorker();
            this.Atualiza = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ForçarButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.GridNotas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.PesquisarTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalhesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.VizualizarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelTimer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 31);
            this.panel1.TabIndex = 1;
            // 
            // LabelTimer
            // 
            this.LabelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.Location = new System.Drawing.Point(0, 0);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(69, 31);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "0";
            this.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Processador
            // 
            this.Processador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Processador_DoWork);
            // 
            // Atualiza
            // 
            this.Atualiza.Interval = 1000;
            this.Atualiza.Tick += new System.EventHandler(this.Atualiza_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ForçarButton);
            this.panel2.Controls.Add(this.ConfigButton);
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 31);
            this.panel2.TabIndex = 4;
            // 
            // ForçarButton
            // 
            this.ForçarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForçarButton.FlatAppearance.BorderSize = 0;
            this.ForçarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForçarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForçarButton.Location = new System.Drawing.Point(0, 0);
            this.ForçarButton.Name = "ForçarButton";
            this.ForçarButton.Size = new System.Drawing.Size(120, 31);
            this.ForçarButton.TabIndex = 0;
            this.ForçarButton.Text = "Forçar Inicio";
            this.ForçarButton.UseVisualStyleBackColor = true;
            this.ForçarButton.Click += new System.EventHandler(this.ForçarButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfigButton.FlatAppearance.BorderSize = 0;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.Location = new System.Drawing.Point(120, 0);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(66, 31);
            this.ConfigButton.TabIndex = 2;
            this.ConfigButton.Text = "Config";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // GridNotas
            // 
            this.GridNotas.AllowUserToAddRows = false;
            this.GridNotas.AllowUserToDeleteRows = false;
            this.GridNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridNotas.AutoGenerateColumns = false;
            this.GridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.DataProcess,
            this.statusDataGridViewTextBoxColumn,
            this.detalhesDataGridViewTextBoxColumn});
            this.GridNotas.DataSource = this.notasBindingSource;
            this.GridNotas.Location = new System.Drawing.Point(7, 34);
            this.GridNotas.MultiSelect = false;
            this.GridNotas.Name = "GridNotas";
            this.GridNotas.ReadOnly = true;
            this.GridNotas.RowHeadersVisible = false;
            this.GridNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridNotas.Size = new System.Drawing.Size(489, 323);
            this.GridNotas.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PesquisarTextBox
            // 
            this.PesquisarTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PesquisarTextBox.Location = new System.Drawing.Point(75, 6);
            this.PesquisarTextBox.MaxLength = 25;
            this.PesquisarTextBox.Name = "PesquisarTextBox";
            this.PesquisarTextBox.Size = new System.Drawing.Size(137, 20);
            this.PesquisarTextBox.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.VizualizarButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(502, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 369);
            this.panel3.TabIndex = 11;
            // 
            // DataProcess
            // 
            this.DataProcess.DataPropertyName = "DataProcess";
            this.DataProcess.HeaderText = "Data";
            this.DataProcess.Name = "DataProcess";
            this.DataProcess.ReadOnly = true;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.BackgroundImage = global::MonitorDanfe.Properties.Resources.procurar16x16;
            this.PesquisarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PesquisarButton.FlatAppearance.BorderSize = 0;
            this.PesquisarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarButton.Location = new System.Drawing.Point(218, 6);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(30, 20);
            this.PesquisarButton.TabIndex = 10;
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 110;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalhesDataGridViewTextBoxColumn
            // 
            this.detalhesDataGridViewTextBoxColumn.DataPropertyName = "Detalhes";
            this.detalhesDataGridViewTextBoxColumn.HeaderText = "Detalhes";
            this.detalhesDataGridViewTextBoxColumn.Name = "detalhesDataGridViewTextBoxColumn";
            this.detalhesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataSource = typeof(Model.Notas);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MonitorDanfe.Properties.Resources.printer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Imprimir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VizualizarButton
            // 
            this.VizualizarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VizualizarButton.FlatAppearance.BorderSize = 0;
            this.VizualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VizualizarButton.Image = global::MonitorDanfe.Properties.Resources.visibility;
            this.VizualizarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VizualizarButton.Location = new System.Drawing.Point(0, 0);
            this.VizualizarButton.Name = "VizualizarButton";
            this.VizualizarButton.Size = new System.Drawing.Size(75, 44);
            this.VizualizarButton.TabIndex = 6;
            this.VizualizarButton.Text = "Visualizar";
            this.VizualizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VizualizarButton.UseVisualStyleBackColor = true;
            this.VizualizarButton.Click += new System.EventHandler(this.VizualizarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 369);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.PesquisarTextBox);
            this.Controls.Add(this.GridNotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monitor Danfe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTimer;
        private System.ComponentModel.BackgroundWorker Processador;
        private System.Windows.Forms.Timer Atualiza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ForçarButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.DataGridView GridNotas;
        private System.Windows.Forms.Button VizualizarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PesquisarTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalhesDataGridViewTextBoxColumn;
    }
}

