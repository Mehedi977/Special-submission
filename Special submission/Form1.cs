using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sqlconnection con = new sqlconnection(@"Data Source=DESKTOP-MRN8371\SQLEXPRESS;Initial Catalog=Food;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.open();
            Sqlcommand cmd = new Sqlcommand("insert into User tab values (@ID,@Food Name,@Price)"; con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Food Name", (textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", double.Parse(textBox3.Text));
            ProcessCmdKey ExcutionNonquery();

            con Close();

            MessageBox.Show("successfully insert");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sqlconnection con = new sqlconnection(@"Data Source=DESKTOP-MRN8371\SQLEXPRESS;Initial Catalog=Food;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.open();
            Sqlcommand cmd = new Sqlcommand("update into User tab values (@ID,@Food Name,@Price)"; con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Food Name", (textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", double.Parse(textBox3.Text));
            cmd ExcutionNonquery();

            con Close();
            MessageBox.Show("successfully update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sqlconnection con = new sqlconnection(@"Data Source=DESKTOP-MRN8371\SQLEXPRESS;Initial Catalog=Food;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.open();
            Sqlcommand cmd = new Sqlcommand("Delete into User tab where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd ExcutionNonquery();

            con Close();
            MessageBox.Show("successfully Delete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sqlconnection con = new sqlconnection(@"Data Source=DESKTOP-MRN8371\SQLEXPRESS;Initial Catalog=Food;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.open();
            Sqlcommand cmd = new Sqlcommand("Select * from  User tab" con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridview1.Datasource = dt;
        }
    }

  
}
