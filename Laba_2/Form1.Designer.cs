
namespace Laba_2
{
    partial class MainForm
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Size = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LightIntensity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XLight = new System.Windows.Forms.NumericUpDown();
            this.YLight = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ZLight = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.pickColor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SpecPower = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecPower)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(500, 500);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нутация";
            // 
            // Y
            // 
            this.Y.DecimalPlaces = 2;
            this.Y.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.Y.Location = new System.Drawing.Point(281, 24);
            this.Y.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Y.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(120, 20);
            this.Y.TabIndex = 4;
            this.Y.ValueChanged += new System.EventHandler(this.Y_ValueChanged);
            // 
            // X
            // 
            this.X.DecimalPlaces = 2;
            this.X.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.X.Location = new System.Drawing.Point(3, 24);
            this.X.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.X.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(120, 20);
            this.X.TabIndex = 3;
            this.X.ValueChanged += new System.EventHandler(this.X_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прецессия";
            // 
            // Height
            // 
            this.Height.DecimalPlaces = 1;
            this.Height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Height.Location = new System.Drawing.Point(7, 23);
            this.Height.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 20);
            this.Height.TabIndex = 7;
            this.Height.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Height.ValueChanged += new System.EventHandler(this.Height_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Радиус основания";
            // 
            // Radius
            // 
            this.Radius.DecimalPlaces = 1;
            this.Radius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Radius.Location = new System.Drawing.Point(280, 23);
            this.Radius.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Radius.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            65536});
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(120, 20);
            this.Radius.TabIndex = 10;
            this.Radius.Value = new decimal(new int[] {
            17,
            0,
            0,
            65536});
            this.Radius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(530, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 205);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Size);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.X);
            this.tabPage1.Controls.Add(this.Y);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Камера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Radius);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Height);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Цилиндр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(3, 89);
            this.Size.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(120, 20);
            this.Size.TabIndex = 7;
            this.Size.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Size.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Приближение";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SpecPower);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.pickColor);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.ZLight);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.YLight);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.XLight);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.LightIntensity);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(408, 179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Освещение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интенсивность освещения";
            // 
            // LightIntensity
            // 
            this.LightIntensity.DecimalPlaces = 2;
            this.LightIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LightIntensity.Location = new System.Drawing.Point(6, 25);
            this.LightIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LightIntensity.Name = "LightIntensity";
            this.LightIntensity.Size = new System.Drawing.Size(399, 20);
            this.LightIntensity.TabIndex = 3;
            this.LightIntensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.LightIntensity.ValueChanged += new System.EventHandler(this.LightIntensity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Направление света";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Компонента Х";
            // 
            // XLight
            // 
            this.XLight.Location = new System.Drawing.Point(9, 86);
            this.XLight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.XLight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.XLight.Name = "XLight";
            this.XLight.Size = new System.Drawing.Size(120, 20);
            this.XLight.TabIndex = 6;
            this.XLight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.XLight.ValueChanged += new System.EventHandler(this.XLight_ValueChanged);
            // 
            // YLight
            // 
            this.YLight.Location = new System.Drawing.Point(151, 86);
            this.YLight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.YLight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.YLight.Name = "YLight";
            this.YLight.Size = new System.Drawing.Size(120, 20);
            this.YLight.TabIndex = 8;
            this.YLight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.YLight.ValueChanged += new System.EventHandler(this.YLight_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Компонента Y";
            // 
            // ZLight
            // 
            this.ZLight.Location = new System.Drawing.Point(285, 86);
            this.ZLight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ZLight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.ZLight.Name = "ZLight";
            this.ZLight.Size = new System.Drawing.Size(120, 20);
            this.ZLight.TabIndex = 10;
            this.ZLight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ZLight.ValueChanged += new System.EventHandler(this.ZLight_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Компонента Z";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Цвет света:";
            // 
            // pickColor
            // 
            this.pickColor.Location = new System.Drawing.Point(9, 139);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(75, 23);
            this.pickColor.TabIndex = 12;
            this.pickColor.Text = "Выбрать";
            this.pickColor.UseVisualStyleBackColor = true;
            this.pickColor.Click += new System.EventHandler(this.pickColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Затухание блика";
            // 
            // SpecPower
            // 
            this.SpecPower.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpecPower.Location = new System.Drawing.Point(285, 141);
            this.SpecPower.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.SpecPower.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpecPower.Name = "SpecPower";
            this.SpecPower.Size = new System.Drawing.Size(120, 20);
            this.SpecPower.TabIndex = 14;
            this.SpecPower.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpecPower.ValueChanged += new System.EventHandler(this.SpecPower_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.canvas);
            this.Name = "MainForm";
            this.Text = "Моделирование трёхмерного изображения";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecPower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Radius;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Size;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LightIntensity;
        private System.Windows.Forms.NumericUpDown ZLight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown YLight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown XLight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pickColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown SpecPower;
        private System.Windows.Forms.Label label12;
    }
}

