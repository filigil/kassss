using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand type = new MySqlCommand("SELECT * FROM type", con);
            MySqlDataAdapter tip = new MySqlDataAdapter(type);
            DataTable dt = new DataTable();
            tip.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "type_name";
            comboBox1.ValueMember = "id";
            MySqlCommand colonka = new MySqlCommand("SELECT * FROM colonka", con);
            MySqlDataAdapter number = new MySqlDataAdapter(colonka);
            DataTable cl = new DataTable();
            number.Fill(cl);
            comboBox2.DataSource = cl;
            comboBox2.DisplayMember = "number";
            comboBox2.ValueMember = "id";
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand cena = new MySqlCommand("SELECT * FROM ostatok WHERE id = 1", con);
            MySqlDataReader reader = cena.ExecuteReader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Connection.GetConnection();
                IblError.Visible = false;
                IblSucess.Visible = true;
            }
            catch (Exception)
            {
                IblSucess.Visible = false;
                IblError.Visible = true;
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand cena = new MySqlCommand("SELECT * FROM ostatok WHERE id = 1", con);
            MySqlDataReader reader = cena.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                var id1 = reader.GetInt32(0);
                var price = reader.GetString(1);
                textBox11.Text = price;
                reader.Close();

            }
            MySqlCommand cena2 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 2", con);
            MySqlDataReader reader2 = cena2.ExecuteReader();
            if (reader2.HasRows)
            {
                reader2.Read();
                var id1 = reader2.GetInt32(0);
                var price = reader2.GetString(1);
                textBox14.Text = price;
                reader2.Close();
            }
            MySqlCommand cena3 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 3", con);
            MySqlDataReader reader3 = cena3.ExecuteReader();
            if (reader3.HasRows)
            {
                reader3.Read();
                var id1 = reader3.GetInt32(0);
                var price = reader3.GetString(1);
                textBox13.Text = price;
                reader3.Close();
            }
            MySqlCommand cena4 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 4", con);
            MySqlDataReader reader4 = cena4.ExecuteReader();
            if (reader4.HasRows)
            {
                reader4.Read();
                var id1 = reader4.GetInt32(0);
                var price = reader4.GetString(1);
                textBox12.Text = price;
                reader4.Close();
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           MySqlConnection con = Connection.GetConnection();

            update_cena(1,Convert.ToDouble(textBox11.Text), con);
            update_cena(2, Convert.ToDouble(textBox14.Text), con);
            update_cena(3, Convert.ToDouble(textBox13.Text), con);
            update_cena(4, Convert.ToDouble(textBox12.Text), con);
            con.Close();
          

           MessageBox.Show("Цена успешно обновлена.");
        }
        private void update_cena(int id, double price, MySqlConnection con)
        {
            string updatecena92 = "UPDATE ostatok SET price = @price WHERE id = @id";
            MySqlCommand upcena92 = new MySqlCommand(updatecena92, con);
            upcena92.Parameters.Add(new MySqlParameter("@price", price  ));
            upcena92.Parameters.Add(new MySqlParameter("@id", id));
            upcena92.ExecuteNonQuery();
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue.ToString() == "1")
                {
                    double c = Convert.ToDouble(textBox11.Text);
                    double u = Convert.ToDouble(textBox7.Text);
                    double i = u * c;
                    textBox6.Text = i.ToString();
                    textBox5.Text = textBox6.Text.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "2")
                {
                    double c = Convert.ToDouble(textBox14.Text);
                    double u = Convert.ToDouble(textBox7.Text);
                    double i = u * c;
                    textBox6.Text = i.ToString();
                    textBox5.Text = textBox6.Text.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "3")
                {
                    double c = Convert.ToDouble(textBox13.Text);
                    double u = Convert.ToDouble(textBox7.Text);
                    double i = u * c;
                    textBox6.Text = i.ToString();
                    textBox5.Text = textBox6.Text.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "4")
                {
                    double c = Convert.ToDouble(textBox12.Text);
                    double u = Convert.ToDouble(textBox7.Text);
                    double i = u * c;
                    textBox6.Text = i.ToString();
                    textBox5.Text = textBox6.Text.ToString();
                }
            } 
            catch { };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand ost = new MySqlCommand("SELECT * FROM ostatok WHERE id = 1", con);
            MySqlDataReader readerost = ost.ExecuteReader();
            if (readerost.HasRows)
            {
                readerost.Read();
                var id1 = readerost.GetInt32(0);
                var ostatok = readerost.GetString(3);
                textBox1.Text = ostatok;
                readerost.Close();

            }
            MySqlCommand ost2 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 2", con);
            MySqlDataReader readerost2 = ost2.ExecuteReader();
            if (readerost2.HasRows)
            {
                readerost2.Read();
                var id1 = readerost2.GetInt32(0);
                var ostatok = readerost2.GetString(3);
                textBox2.Text = ostatok;
                readerost2.Close();
            }
            MySqlCommand ost3 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 3", con);
            MySqlDataReader readerost3 = ost3.ExecuteReader();
            if (readerost3.HasRows)
            {
                readerost3.Read();
                var id1 = readerost3.GetInt32(0);
                var ostatok = readerost3.GetString(3);
                textBox3.Text = ostatok;
                readerost3.Close();
            }
            MySqlCommand ost4 = new MySqlCommand("SELECT * FROM ostatok WHERE id = 4", con);
            MySqlDataReader readerost4 = ost4.ExecuteReader();
            if (readerost4.HasRows)
            {
                readerost4.Read();
                var id1 = readerost4.GetInt32(0);
                var ostatok = readerost4.GetString(3);
                textBox4.Text = ostatok;
                readerost4.Close();
            }
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var vidtopliva = "SELECT * FROM type";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand colonka = new MySqlCommand("SELECT * FROM colonka WHERE id = 1", con);
            MySqlDataReader reader = colonka.ExecuteReader();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {  try
            {
                if (comboBox1.SelectedValue.ToString() == "1")
                {
                    double k = Convert.ToDouble(textBox11.Text);
                    double j = Convert.ToDouble(textBox6.Text);
                    double p = j / k;
                    textBox7.Text = p.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "2")
                {
                    double k = Convert.ToDouble(textBox14.Text);
                    double j = Convert.ToDouble(textBox6.Text);
                    double p = j / k;
                    textBox7.Text = p.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "3")
                {
                    double k = Convert.ToDouble(textBox13.Text);
                    double j = Convert.ToDouble(textBox6.Text);
                    double p = j / k;
                    textBox7.Text = p.ToString();
                }
                if (comboBox1.SelectedValue.ToString() == "4")
                {
                    double k = Convert.ToDouble(textBox12.Text);
                    double j = Convert.ToDouble(textBox6.Text);
                    double p = j / k;
                    textBox7.Text = p.ToString();
                }
            } catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "1")
            {
                string m = Convert.ToString(textBox7.Text);
                string g = Convert.ToString(comboBox2.Text);
                string j = Convert.ToString(textBox1.Text);
                string p = Convert.ToString(textBox6.Text);
                string o = Convert.ToString(textBox5.Text);
                //m = label17.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = Connection.GetConnection();

            update_ost(1, Convert.ToDouble(textBox1.Text), con);
            update_ost(2, Convert.ToDouble(textBox2.Text), con);
            update_ost(3, Convert.ToDouble(textBox3.Text), con);
            update_ost(4, Convert.ToDouble(textBox4.Text), con);
            con.Close();


            MessageBox.Show("Остаток успешно обновлен.");
        }
        private void update_ost(int id, double ostatok, MySqlConnection con)
        {
            string updateost = "UPDATE ostatok SET ostatok = @ostatok WHERE id = @id";
            MySqlCommand upost = new MySqlCommand(updateost, con);
            upost.Parameters.Add(new MySqlParameter("@ostatok", ostatok  ));
            upost.Parameters.Add(new MySqlParameter("@id", id));
            upost.ExecuteNonQuery();
            
       
        }
    }


}
