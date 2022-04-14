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
    public partial class Form4 : Form
    {
        public object AllowUserToAddRows { get; private set; }
        public object False { get; private set; }
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user128_db;persist security info=True;user id=user128_db;password=user128;MultipleActiveResultSets=True;App=EntityFramework";
        string sql = "SELECT * FROM Афиша";
        public Form4()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet16.Афиша' table. You can move, or remove it, as needed.
            this.афишаTableAdapter.Fill(this.dataSet16.Афиша);
            this.BackColor = System.Drawing.Color.White;
            button1.Text = "Выход";
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что вы хотите выйти из системы",
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("Афиша", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ticketsleft", SqlDbType.Int, 50, "Ticketsleft"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date, 50, "Date"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 50, "Description"));
                adapter.Update(ds);
            }
        }
    }
}
