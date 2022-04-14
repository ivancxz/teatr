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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Логин";
            label2.Text = "Номер телефона";
            label3.Text = "Почта";
            label4.Text = "Пароль";
            label5.Text = "Повтор пароля";
            button1.Text = "Зарегестрироваться";
            button2.Text = "Авторизация";
            textBox4.UseSystemPasswordChar = true;
            textBox5.UseSystemPasswordChar = true;
            this.BackColor = System.Drawing.Color.White;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox3.Text == string.Empty) || (textBox4.Text == string.Empty) || (textBox5.Text == string.Empty))
            {
                MessageBox.Show("Проверьте, заполнены ли все поля!");

            }
            else if (!(textBox4.Text.Any(Char.IsLetter)))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну букву!");
            }
            else if (!(textBox4.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру!");
            }
            else if (textBox4.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен быть больше либо равен 6 символам!");
            }
            else if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Пароли должны совпадать!");
            }
            else
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user128_db;persist security info=True;user id=user128_db;password=user128;MultipleActiveResultSets=True;App=EntityFramework";
                SqlConnection myConnection = new SqlConnection(@connect);
                myConnection.Open();
                string sInsSql = "Insert into teatr(login,phone,mail,password,repassword) Values('{0}', '{1}', '{2}', '{3}','{4}')";
                string login = textBox1.Text;
                string phone = textBox2.Text;
                string mail = textBox3.Text;
                string password = textBox4.Text;
                string repassword = textBox5.Text;
                string sInsSotr = string.Format(sInsSql, login, phone, mail, password, repassword);
                SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
                cmdIns.ExecuteNonQuery();
                MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", login), "Сообщение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Hide();
        }
    }
}
