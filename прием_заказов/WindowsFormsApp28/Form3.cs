using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet15.Афиша' table. You can move, or remove it, as needed.
            this.афишаTableAdapter2.Fill(this.dataSet15.Афиша);

            this.BackColor = System.Drawing.Color.White;
            button1.Text = "Выход";
            button2.Text = "Купить";
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Black;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var confirmResult =  MessageBox.Show("Вы уверены, что вы хотите выйти из системы",
                "-_-",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Form2 frm = new Form2();
                frm.Show();
                Hide();
                MessageBox.Show("Вы успешно вышли",
                "0_0");            
            }
            else
            {

            }
   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection ThisConnection = new SqlConnection("data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user128_db;persist security info=True;user id=user128_db;password=user128;MultipleActiveResultSets=True;App=EntityFramework");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            thisCommand.CommandText = @"update Афиша set Ticketsleft = Ticketsleft - 1 where Name ='" + textBox1.Text + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                
            }
            this.афишаTableAdapter2.Fill(this.dataSet15.Афиша);
            this.афишаTableAdapter2.Update(this.dataSet15.Афиша);
            thisReader.Close();
            ThisConnection.Close();


        }
    }
}
