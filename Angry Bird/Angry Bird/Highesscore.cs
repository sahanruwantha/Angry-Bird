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

namespace Angry_Bird
{
    public partial class Highesscore : Form
    {
        public Highesscore()
        {
            InitializeComponent();
        }

       // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2ASBBC1;Initial Catalog=angrybird;Integrated Security=True");


        private void Highesscore_Load(object sender, EventArgs e)
        {

        }

        private void high_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2ASBBC1;Initial Catalog=angrybird;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select score from highestscore", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                high.Text = reader["score"].ToString();
            }
        }
    }
}
