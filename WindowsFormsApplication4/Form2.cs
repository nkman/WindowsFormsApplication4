﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            string address = "Data Source=NAIRITYA\\HACKSQL;Initial Catalog=nkman_todo_db;Integrated Security=True;Pooling=False";
            SqlConnection con = new SqlConnection(address);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM check_assignment_of_works", con);
            int total = (Int32)cmd.ExecuteScalar() + 1;
            SqlCommand coma = new SqlCommand("INSERT INTO check_assignment_of_works (Id,Work_Assigned,Status)" + " VALUES ('"+total+"','"+work.Text+"','No')",con);
            
            coma.ExecuteNonQuery();
            con.Close();
            return;
        }

        private void work_TextChanged(object sender, EventArgs e)
        {

        }
    }
}