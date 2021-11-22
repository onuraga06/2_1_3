using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sayi = 0;

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			sayi = Convert.ToInt32(textBox1.Text);
			if (sayi == 0)
			{
				MessageBox.Show("Sıfırdan Farklı Değer Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			for (int i = 1; i < sayi; i++)
			{
				

				if (sayi%i==0 && sayi/i>=i)
				{
					
					listBox1.Items.Add(i + "*" + sayi / i+"="+sayi);
					
				}
			}
			textBox1.Text = "0";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			textBox1.Text = "0";
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(this, new EventArgs());
			}
			if (e.KeyCode == Keys.Delete)
			{
				button2_Click(this, new EventArgs());
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = "0";
		}
	}
}
