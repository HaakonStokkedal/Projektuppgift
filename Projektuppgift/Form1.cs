using System.Data;

namespace Projektuppgift
{
    public partial class Kontaktboken : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;

        public Kontaktboken()
        {
            InitializeComponent();
            label1.Text = "Välkommen till kontaktboken!!!";
            label1.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sluta pilla!!!", "SLUTA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textAdress.Text = "";
            textMail.Text = "";
            textBirth.Text = "";
            textPhone.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Kontaktboken_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("Namn");
            contacts.Columns.Add("Telefonnummer");
            contacts.Columns.Add("Adress");
            contacts.Columns.Add("Mail");
            contacts.Columns.Add("Födelsedatum");

            dataGridView1.DataSource = contacts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textName.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            textAdress.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            textMail.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
            textBirth.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[4].ToString();
            textPhone.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textName.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            textAdress.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            textMail.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
            textBirth.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[4].ToString();
            textPhone.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Namn"] = textName.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Telefonnummer"] = textPhone.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Adress"] = textAdress.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Mail"] = textMail.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Födelsedatum"] = textBirth.Text;
            }
            else
            {
                contacts.Rows.Add(textName.Text, textPhone.Text, textAdress.Text, textMail.Text, textBirth.Text);
            }

            textName.Text = "";
            textAdress.Text = "";
            textMail.Text = "";
            textBirth.Text = "";
            textPhone.Text = "";
            editing = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 1)
            {
                try
                {
                    contacts.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Du måste markera en kontakt!");
                }
            }
            else
            {
                MessageBox.Show("Det finns ingen kontakt att ta bort!", "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked)
            {
                BackColor = Color.Green;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
            {
                BackColor = Color.Blue;
            }
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked)
            {
                BackColor = Color.Red;
            }
        }

        private void radioVit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhite.Checked)
            {
                BackColor = Color.White;
            }
        }
    }
}