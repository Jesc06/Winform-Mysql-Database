using System.Configuration;
using MySql.Data.MySqlClient;

namespace OOP_Laragon
{
    public partial class Form1 : Form
    {
        private string conString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "insert into data(name,lastname)values(@Name,@Lastname)";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name.Text);
                        cmd.Parameters.AddWithValue("@Lastname", Lastname.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully added");
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }
    }
}
