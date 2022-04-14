
namespace WindowsFormsApp28
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet13 = new WindowsFormsApp28.DataSet13();
            this.афишаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.афишаTableAdapter = new WindowsFormsApp28.DataSet13TableAdapters.АфишаTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet14 = new WindowsFormsApp28.DataSet14();
            this.афишаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.афишаTableAdapter1 = new WindowsFormsApp28.DataSet14TableAdapters.АфишаTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet15 = new WindowsFormsApp28.DataSet15();
            this.афишаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.афишаTableAdapter2 = new WindowsFormsApp28.DataSet15TableAdapters.АфишаTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsleftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet13";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // афишаBindingSource
            // 
            this.афишаBindingSource.DataMember = "Афиша";
            this.афишаBindingSource.DataSource = this.dataSet13;
            // 
            // афишаTableAdapter
            // 
            this.афишаTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataSet14
            // 
            this.dataSet14.DataSetName = "DataSet14";
            this.dataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // афишаBindingSource1
            // 
            this.афишаBindingSource1.DataMember = "Афиша";
            this.афишаBindingSource1.DataSource = this.dataSet14;
            // 
            // афишаTableAdapter1
            // 
            this.афишаTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ticketsleftDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.афишаBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet15";
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // афишаBindingSource2
            // 
            this.афишаBindingSource2.DataMember = "Афиша";
            this.афишаBindingSource2.DataSource = this.dataSet15;
            // 
            // афишаTableAdapter2
            // 
            this.афишаTableAdapter2.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ticketsleftDataGridViewTextBoxColumn
            // 
            this.ticketsleftDataGridViewTextBoxColumn.DataPropertyName = "Ticketsleft";
            this.ticketsleftDataGridViewTextBoxColumn.HeaderText = "Ticketsleft";
            this.ticketsleftDataGridViewTextBoxColumn.Name = "ticketsleftDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 197);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посетитель";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.афишаBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DataSet13 dataSet13;
        private System.Windows.Forms.BindingSource афишаBindingSource;
        private DataSet13TableAdapters.АфишаTableAdapter афишаTableAdapter;
        private System.Windows.Forms.Button button2;
        private DataSet14 dataSet14;
        private System.Windows.Forms.BindingSource афишаBindingSource1;
        private DataSet14TableAdapters.АфишаTableAdapter афишаTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet15 dataSet15;
        private System.Windows.Forms.BindingSource афишаBindingSource2;
        private DataSet15TableAdapters.АфишаTableAdapter афишаTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsleftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}