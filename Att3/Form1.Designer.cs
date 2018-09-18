namespace Att3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.InpMatrix_But = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Draw_Graph_But = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cycle_Box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Matrix
            // 
            this.DGV_Matrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Matrix.Location = new System.Drawing.Point(985, 12);
            this.DGV_Matrix.Name = "DGV_Matrix";
            this.DGV_Matrix.ReadOnly = true;
            this.DGV_Matrix.Size = new System.Drawing.Size(250, 250);
            this.DGV_Matrix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(966, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Загрузите из файла матрицу смежности";
            // 
            // InpMatrix_But
            // 
            this.InpMatrix_But.AutoSize = true;
            this.InpMatrix_But.Location = new System.Drawing.Point(1022, 290);
            this.InpMatrix_But.Name = "InpMatrix_But";
            this.InpMatrix_But.Size = new System.Drawing.Size(179, 32);
            this.InpMatrix_But.TabIndex = 2;
            this.InpMatrix_But.Text = "Загрузить";
            this.InpMatrix_But.UseVisualStyleBackColor = true;
            this.InpMatrix_But.Click += new System.EventHandler(this.InpMatrix_But_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 731);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Draw_Graph_But
            // 
            this.Draw_Graph_But.Location = new System.Drawing.Point(1022, 343);
            this.Draw_Graph_But.Name = "Draw_Graph_But";
            this.Draw_Graph_But.Size = new System.Drawing.Size(179, 39);
            this.Draw_Graph_But.TabIndex = 4;
            this.Draw_Graph_But.Text = "Построить граф";
            this.Draw_Graph_But.UseVisualStyleBackColor = true;
            this.Draw_Graph_But.Click += new System.EventHandler(this.Draw_Graph_But_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1023, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти циклы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cycle_Box
            // 
            this.cycle_Box.Location = new System.Drawing.Point(1000, 464);
            this.cycle_Box.Multiline = true;
            this.cycle_Box.Name = "cycle_Box";
            this.cycle_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cycle_Box.Size = new System.Drawing.Size(221, 111);
            this.cycle_Box.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1034, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Найти кратчайший цикл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1000, 629);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 755);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cycle_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Draw_Graph_But);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InpMatrix_But);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Matrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InpMatrix_But;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Draw_Graph_But;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cycle_Box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

