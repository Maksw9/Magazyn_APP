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
using System.Configuration;

namespace Magazyn1._0
{
    public partial class ShowMoreDialog : MetroFramework.Forms.MetroForm
    {
        public string id;
        public ShowMoreDialog(string ID)
        {
            InitializeComponent();
            this.id = ID;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MagzynConnectionString"].ToString()))
            {

                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE Id =  @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                idTextBox.Text = reader["Id"].ToString();
                                nameTextBox.Text = reader["Nazwa"].ToString();
                                producerTextBox.Text = reader["Producent"].ToString();
                                aleyTextBox.Text = reader["Aleja"].ToString();
                                boxTextBox.Text = reader["Box"].ToString();
                                positionTextBox.Text = reader["Pozycja"].ToString();
                                amountTextBox.Text = reader["Ilość"].ToString();
                                typeTextBox.Text = reader["Typ"].ToString();
                                modelTextBox.Text = reader["Model"].ToString();
                                sizeTextBox.Text = reader["Rozmiar"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazynDataSet);

        }

        private void ShowMoreDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.magazynDataSet.Table);

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            idTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            producerTextBox.Enabled = true;
            aleyTextBox.Enabled = true;
            boxTextBox.Enabled = true;
            positionTextBox.Enabled = true;
            amountTextBox.Enabled = true;
            typeTextBox.Enabled = true;
            modelTextBox.Enabled = true;
            sizeTextBox.Enabled = true;
        }
    }
}
