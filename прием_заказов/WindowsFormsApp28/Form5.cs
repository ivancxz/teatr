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
    public partial class Form5 : Form
    {
        public object AllowUserToAddRows { get; private set; }
        public object False { get; private set; }
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user128_db;persist security info=True;user id=user128_db;password=user128;MultipleActiveResultSets=True;App=EntityFramework";
        string sql = "SELECT * FROM teatr";
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet17.teatr' table. You can move, or remove it, as needed.
            this.teatrTableAdapter.Fill(this.dataSet17.teatr);
            button1.Text = "Выход";
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
                adapter.InsertCommand = new SqlCommand("teatr", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar, 50, "login"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar, 50, "phone"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar, 50, "mail"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 50, "password"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@repassword", SqlDbType.VarChar, 50, "repassword"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 50, "status"));
                adapter.Update(ds);
            }
        }
    }
}
