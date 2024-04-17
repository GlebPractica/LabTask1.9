namespace Task
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
            this.BttnAddEquil = new System.Windows.Forms.Button();
            this.BttnAddRight = new System.Windows.Forms.Button();
            this.BttnAddIsos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BttnAboutTr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnAddEquil
            // 
            this.BttnAddEquil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAddEquil.Location = new System.Drawing.Point(12, 12);
            this.BttnAddEquil.Name = "BttnAddEquil";
            this.BttnAddEquil.Size = new System.Drawing.Size(460, 55);
            this.BttnAddEquil.TabIndex = 0;
            this.BttnAddEquil.Text = "Добавить значения для равностороннего треугольника";
            this.BttnAddEquil.UseVisualStyleBackColor = true;
            this.BttnAddEquil.Click += new System.EventHandler(this.BttnAddEquil_Click);
            // 
            // BttnAddRight
            // 
            this.BttnAddRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAddRight.Location = new System.Drawing.Point(12, 73);
            this.BttnAddRight.Name = "BttnAddRight";
            this.BttnAddRight.Size = new System.Drawing.Size(460, 55);
            this.BttnAddRight.TabIndex = 1;
            this.BttnAddRight.Text = "Добавить значения для прямоугольного треугольника";
            this.BttnAddRight.UseVisualStyleBackColor = true;
            this.BttnAddRight.Click += new System.EventHandler(this.BttnAddRight_Click);
            // 
            // BttnAddIsos
            // 
            this.BttnAddIsos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnAddIsos.Location = new System.Drawing.Point(12, 134);
            this.BttnAddIsos.Name = "BttnAddIsos";
            this.BttnAddIsos.Size = new System.Drawing.Size(460, 55);
            this.BttnAddIsos.TabIndex = 2;
            this.BttnAddIsos.Text = "Добавить значения для равнобедренного треугольника";
            this.BttnAddIsos.UseVisualStyleBackColor = true;
            this.BttnAddIsos.Click += new System.EventHandler(this.BttnAddIsos_Click);
            // 
            // listBox1
            // 
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(13, 253);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(459, 152);
            this.listBox1.TabIndex = 3;
            this.listBox1.UseTabStops = false;
            // 
            // BttnAboutTr
            // 
            this.BttnAboutTr.Location = new System.Drawing.Point(249, 224);
            this.BttnAboutTr.Name = "BttnAboutTr";
            this.BttnAboutTr.Size = new System.Drawing.Size(223, 23);
            this.BttnAboutTr.TabIndex = 4;
            this.BttnAboutTr.Text = "Вывести характеристики треугольников";
            this.BttnAboutTr.UseVisualStyleBackColor = true;
            this.BttnAboutTr.Click += new System.EventHandler(this.BttnAboutTr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вывод общей площади";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttnAboutTr);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttnAddIsos);
            this.Controls.Add(this.BttnAddRight);
            this.Controls.Add(this.BttnAddEquil);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnAddEquil;
        private System.Windows.Forms.Button BttnAddRight;
        private System.Windows.Forms.Button BttnAddIsos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BttnAboutTr;
        private System.Windows.Forms.Button button1;
    }
}

