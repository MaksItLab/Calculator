namespace Calculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button_Sqrt = new System.Windows.Forms.Button();
			this.button_Squared = new System.Windows.Forms.Button();
			this.button_Delete_All = new System.Windows.Forms.Button();
			this.button_Delete = new System.Windows.Forms.Button();
			this.button_Sum = new System.Windows.Forms.Button();
			this.button_Seven = new System.Windows.Forms.Button();
			this.button_Four = new System.Windows.Forms.Button();
			this.button_One = new System.Windows.Forms.Button();
			this.button_Inversion = new System.Windows.Forms.Button();
			this.button_Division = new System.Windows.Forms.Button();
			this.button_Multiplication = new System.Windows.Forms.Button();
			this.button_Substraction = new System.Windows.Forms.Button();
			this.button_Nine = new System.Windows.Forms.Button();
			this.button_Eight = new System.Windows.Forms.Button();
			this.button_Six = new System.Windows.Forms.Button();
			this.button_Five = new System.Windows.Forms.Button();
			this.button_Three = new System.Windows.Forms.Button();
			this.button_Two = new System.Windows.Forms.Button();
			this.button_Equal = new System.Windows.Forms.Button();
			this.button_Point = new System.Windows.Forms.Button();
			this.button_Null = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(498, 158);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 38);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(62, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_Sqrt
			// 
			this.button_Sqrt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button_Sqrt.FlatAppearance.BorderSize = 2;
			this.button_Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Sqrt.Location = new System.Drawing.Point(13, 176);
			this.button_Sqrt.Name = "button_Sqrt";
			this.button_Sqrt.Size = new System.Drawing.Size(120, 75);
			this.button_Sqrt.TabIndex = 1;
			this.button_Sqrt.Text = "√x";
			this.button_Sqrt.UseVisualStyleBackColor = true;
			this.button_Sqrt.Click += new System.EventHandler(this.button_Sqrt_Click);
			// 
			// button_Squared
			// 
			this.button_Squared.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Squared.Location = new System.Drawing.Point(139, 176);
			this.button_Squared.Name = "button_Squared";
			this.button_Squared.Size = new System.Drawing.Size(120, 75);
			this.button_Squared.TabIndex = 2;
			this.button_Squared.Text = "x²";
			this.button_Squared.UseVisualStyleBackColor = true;
			this.button_Squared.Click += new System.EventHandler(this.button_Squared_Click);
			// 
			// button_Delete_All
			// 
			this.button_Delete_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Delete_All.Location = new System.Drawing.Point(265, 176);
			this.button_Delete_All.Name = "button_Delete_All";
			this.button_Delete_All.Size = new System.Drawing.Size(120, 75);
			this.button_Delete_All.TabIndex = 3;
			this.button_Delete_All.Text = "C";
			this.button_Delete_All.UseVisualStyleBackColor = true;
			this.button_Delete_All.Click += new System.EventHandler(this.button_Delete_All_Click);
			// 
			// button_Delete
			// 
			this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Delete.Location = new System.Drawing.Point(390, 176);
			this.button_Delete.Name = "button_Delete";
			this.button_Delete.Size = new System.Drawing.Size(120, 75);
			this.button_Delete.TabIndex = 4;
			this.button_Delete.Text = "←";
			this.button_Delete.UseVisualStyleBackColor = true;
			this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
			// 
			// button_Sum
			// 
			this.button_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Sum.Location = new System.Drawing.Point(13, 257);
			this.button_Sum.Name = "button_Sum";
			this.button_Sum.Size = new System.Drawing.Size(120, 75);
			this.button_Sum.TabIndex = 5;
			this.button_Sum.Text = "+";
			this.button_Sum.UseVisualStyleBackColor = true;
			this.button_Sum.Click += new System.EventHandler(this.button_Sum_Click);
			// 
			// button_Seven
			// 
			this.button_Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Seven.Location = new System.Drawing.Point(13, 338);
			this.button_Seven.Name = "button_Seven";
			this.button_Seven.Size = new System.Drawing.Size(120, 75);
			this.button_Seven.TabIndex = 6;
			this.button_Seven.Text = "7";
			this.button_Seven.UseVisualStyleBackColor = true;
			this.button_Seven.Click += new System.EventHandler(this.button_Seven_Click);
			// 
			// button_Four
			// 
			this.button_Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Four.Location = new System.Drawing.Point(13, 419);
			this.button_Four.Name = "button_Four";
			this.button_Four.Size = new System.Drawing.Size(120, 75);
			this.button_Four.TabIndex = 7;
			this.button_Four.Text = "4";
			this.button_Four.UseVisualStyleBackColor = true;
			this.button_Four.Click += new System.EventHandler(this.button_Four_Click);
			// 
			// button_One
			// 
			this.button_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_One.Location = new System.Drawing.Point(13, 500);
			this.button_One.Name = "button_One";
			this.button_One.Size = new System.Drawing.Size(120, 75);
			this.button_One.TabIndex = 8;
			this.button_One.Text = "1";
			this.button_One.UseVisualStyleBackColor = true;
			this.button_One.Click += new System.EventHandler(this.button_One_Click);
			// 
			// button_Inversion
			// 
			this.button_Inversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Inversion.Location = new System.Drawing.Point(13, 581);
			this.button_Inversion.Name = "button_Inversion";
			this.button_Inversion.Size = new System.Drawing.Size(120, 75);
			this.button_Inversion.TabIndex = 9;
			this.button_Inversion.Text = "+/-";
			this.button_Inversion.UseVisualStyleBackColor = true;
			this.button_Inversion.Click += new System.EventHandler(this.button_Inversion_Click);
			// 
			// button_Division
			// 
			this.button_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Division.Location = new System.Drawing.Point(390, 257);
			this.button_Division.Name = "button_Division";
			this.button_Division.Size = new System.Drawing.Size(120, 75);
			this.button_Division.TabIndex = 12;
			this.button_Division.Text = "/";
			this.button_Division.UseVisualStyleBackColor = true;
			this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
			// 
			// button_Multiplication
			// 
			this.button_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Multiplication.Location = new System.Drawing.Point(265, 257);
			this.button_Multiplication.Name = "button_Multiplication";
			this.button_Multiplication.Size = new System.Drawing.Size(120, 75);
			this.button_Multiplication.TabIndex = 11;
			this.button_Multiplication.Text = "x";
			this.button_Multiplication.UseVisualStyleBackColor = true;
			this.button_Multiplication.Click += new System.EventHandler(this.button_Multiplication_Click);
			// 
			// button_Substraction
			// 
			this.button_Substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Substraction.Location = new System.Drawing.Point(139, 257);
			this.button_Substraction.Name = "button_Substraction";
			this.button_Substraction.Size = new System.Drawing.Size(120, 75);
			this.button_Substraction.TabIndex = 10;
			this.button_Substraction.Text = "-";
			this.button_Substraction.UseVisualStyleBackColor = true;
			this.button_Substraction.Click += new System.EventHandler(this.button_Substraction_Click);
			// 
			// button_Nine
			// 
			this.button_Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Nine.Location = new System.Drawing.Point(265, 338);
			this.button_Nine.Name = "button_Nine";
			this.button_Nine.Size = new System.Drawing.Size(120, 75);
			this.button_Nine.TabIndex = 14;
			this.button_Nine.Text = "9";
			this.button_Nine.UseVisualStyleBackColor = true;
			this.button_Nine.Click += new System.EventHandler(this.button_Nine_Click);
			// 
			// button_Eight
			// 
			this.button_Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Eight.Location = new System.Drawing.Point(139, 338);
			this.button_Eight.Name = "button_Eight";
			this.button_Eight.Size = new System.Drawing.Size(120, 75);
			this.button_Eight.TabIndex = 13;
			this.button_Eight.Text = "8";
			this.button_Eight.UseVisualStyleBackColor = true;
			this.button_Eight.Click += new System.EventHandler(this.button_Eight_Click);
			// 
			// button_Six
			// 
			this.button_Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Six.Location = new System.Drawing.Point(265, 419);
			this.button_Six.Name = "button_Six";
			this.button_Six.Size = new System.Drawing.Size(120, 75);
			this.button_Six.TabIndex = 17;
			this.button_Six.Text = "6";
			this.button_Six.UseVisualStyleBackColor = true;
			this.button_Six.Click += new System.EventHandler(this.button_Six_Click);
			// 
			// button_Five
			// 
			this.button_Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Five.Location = new System.Drawing.Point(139, 419);
			this.button_Five.Name = "button_Five";
			this.button_Five.Size = new System.Drawing.Size(120, 75);
			this.button_Five.TabIndex = 16;
			this.button_Five.Text = "5";
			this.button_Five.UseVisualStyleBackColor = true;
			this.button_Five.Click += new System.EventHandler(this.button_Five_Click);
			// 
			// button_Three
			// 
			this.button_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Three.Location = new System.Drawing.Point(265, 500);
			this.button_Three.Name = "button_Three";
			this.button_Three.Size = new System.Drawing.Size(120, 75);
			this.button_Three.TabIndex = 20;
			this.button_Three.Text = "3";
			this.button_Three.UseVisualStyleBackColor = true;
			this.button_Three.Click += new System.EventHandler(this.button_Three_Click);
			// 
			// button_Two
			// 
			this.button_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Two.Location = new System.Drawing.Point(139, 500);
			this.button_Two.Name = "button_Two";
			this.button_Two.Size = new System.Drawing.Size(120, 75);
			this.button_Two.TabIndex = 19;
			this.button_Two.Text = "2";
			this.button_Two.UseVisualStyleBackColor = true;
			this.button_Two.Click += new System.EventHandler(this.button_Two_Click);
			// 
			// button_Equal
			// 
			this.button_Equal.BackColor = System.Drawing.Color.RoyalBlue;
			this.button_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Equal.Location = new System.Drawing.Point(390, 338);
			this.button_Equal.Name = "button_Equal";
			this.button_Equal.Size = new System.Drawing.Size(120, 318);
			this.button_Equal.TabIndex = 24;
			this.button_Equal.Text = "=";
			this.button_Equal.UseVisualStyleBackColor = false;
			this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
			// 
			// button_Point
			// 
			this.button_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Point.Location = new System.Drawing.Point(265, 581);
			this.button_Point.Name = "button_Point";
			this.button_Point.Size = new System.Drawing.Size(120, 75);
			this.button_Point.TabIndex = 23;
			this.button_Point.Text = ",";
			this.button_Point.UseVisualStyleBackColor = true;
			this.button_Point.Click += new System.EventHandler(this.button_Point_Click);
			// 
			// button_Null
			// 
			this.button_Null.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Null.Location = new System.Drawing.Point(139, 581);
			this.button_Null.Name = "button_Null";
			this.button_Null.Size = new System.Drawing.Size(120, 75);
			this.button_Null.TabIndex = 22;
			this.button_Null.Text = "0";
			this.button_Null.UseVisualStyleBackColor = true;
			this.button_Null.Click += new System.EventHandler(this.button_Null_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 668);
			this.Controls.Add(this.button_Equal);
			this.Controls.Add(this.button_Point);
			this.Controls.Add(this.button_Null);
			this.Controls.Add(this.button_Three);
			this.Controls.Add(this.button_Two);
			this.Controls.Add(this.button_Six);
			this.Controls.Add(this.button_Five);
			this.Controls.Add(this.button_Nine);
			this.Controls.Add(this.button_Eight);
			this.Controls.Add(this.button_Division);
			this.Controls.Add(this.button_Multiplication);
			this.Controls.Add(this.button_Substraction);
			this.Controls.Add(this.button_Inversion);
			this.Controls.Add(this.button_One);
			this.Controls.Add(this.button_Four);
			this.Controls.Add(this.button_Seven);
			this.Controls.Add(this.button_Sum);
			this.Controls.Add(this.button_Delete);
			this.Controls.Add(this.button_Delete_All);
			this.Controls.Add(this.button_Squared);
			this.Controls.Add(this.button_Sqrt);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Калькулятор";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Sqrt;
		private System.Windows.Forms.Button button_Squared;
		private System.Windows.Forms.Button button_Delete_All;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.Button button_Sum;
		private System.Windows.Forms.Button button_Seven;
		private System.Windows.Forms.Button button_Four;
		private System.Windows.Forms.Button button_One;
		private System.Windows.Forms.Button button_Inversion;
		private System.Windows.Forms.Button button_Division;
		private System.Windows.Forms.Button button_Multiplication;
		private System.Windows.Forms.Button button_Substraction;
		private System.Windows.Forms.Button button_Nine;
		private System.Windows.Forms.Button button_Eight;
		private System.Windows.Forms.Button button_Six;
		private System.Windows.Forms.Button button_Five;
		private System.Windows.Forms.Button button_Three;
		private System.Windows.Forms.Button button_Two;
		private System.Windows.Forms.Button button_Equal;
		private System.Windows.Forms.Button button_Point;
		private System.Windows.Forms.Button button_Null;
	}
}

