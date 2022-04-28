using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            con.ConnectionString="Data Source=.;Initial Catalog=tush;Integrated Security=True;Pooling=False";
            InitializeComponent();
            display();
        
        }

     
        private void display()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from stud90", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into stud90 values(@sid,@sname,@smob)", con);
            cmd.Parameters.AddWithValue("@sid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@sname", (textBox2.Text));
            cmd.Parameters.AddWithValue("@smob", (textBox3.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted");
            textBox1.Text = ""; 
            textBox2.Text = "";
            textBox3.Text = "";
            con.Close();
            display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tushDataSet1.stud90' table. You can move, or remove it, as needed.
            this.stud90TableAdapter1.Fill(this.tushDataSet1.stud90);
            // TODO: This line of code loads data into the 'tushDataSet.stud90' table. You can move, or remove it, as needed.
            this.stud90TableAdapter.Fill(this.tushDataSet.stud90);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update stud90 set sname=@sname,smob=@smob where sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@sname", (textBox2.Text));
            cmd.Parameters.AddWithValue("@smob", (textBox3.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record updated");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            con.Close();
            display();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from stud90 where sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", Convert.ToInt32(textBox1.Text));
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record updated");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            con.Close();
            display();
        }
    }
}
