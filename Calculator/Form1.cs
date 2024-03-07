using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public char Action { get; set; }//действие(+-*/)
		public double Result { get; set; } = 0;// общая сумма
		public double CurrentResult { get; set; } = 0;//текущее число

		public Form1()
		{
			InitializeComponent();
		}

		private void button_One_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 1;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Two_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 2;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Three_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 3;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Four_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 4;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Five_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 5;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Six_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 6;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Seven_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 7;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Eight_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 8;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Nine_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10 + 9;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Null_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * 10;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Delete_All_Click(object sender, EventArgs e)
		{
			Result = 0;
			CurrentResult = 0;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Sum_Click(object sender, EventArgs e)
		{
			Action = '+';
			Result = CurrentResult;
			CurrentResult = 0;
			label1.Text = CurrentResult.ToString();

		}

		private void button_Substraction_Click(object sender, EventArgs e)
		{
			Action = '-';
			Result = CurrentResult;
			CurrentResult = 0;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Multiplication_Click(object sender, EventArgs e)
		{
			Action = '*';
			Result = CurrentResult;
			CurrentResult = 0;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Division_Click(object sender, EventArgs e)
		{
			Action = '/';
			Result = CurrentResult;
			CurrentResult = 0;
			label1.Text = CurrentResult.ToString();
		}

		private void button_Point_Click(object sender, EventArgs e)
		{

		}

		private void button_Equal_Click(object sender, EventArgs e)
		{
			Calculate();
			label1.Text = Result.ToString();

			CurrentResult = 0;

			Action = ' ';
		}
		private void button_Delete_Click(object sender, EventArgs e)
		{
			CurrentResult = (int)CurrentResult / 10;
			label1 .Text = CurrentResult.ToString();
		}

		private void Calculate()
		{
			//логика выполнения действия
		}

		private void button_Inversion_Click(object sender, EventArgs e)
		{
			CurrentResult = CurrentResult * -1;
			Result = CurrentResult;
			label1.Text = Result.ToString();
		}

		private void button_Squared_Click(object sender, EventArgs e)
		{
			//CurrentResult = CurrentResult * CurrentResult;
			CurrentResult = Math.Pow(CurrentResult, 2);
			Result = CurrentResult;
			label1.Text = Result.ToString();
		}

		private void button_Sqrt_Click(object sender, EventArgs e)
		{
			CurrentResult = Math.Sqrt(CurrentResult);
			Result = CurrentResult;
			label1.Text = Result.ToString();
		}
	}
}
