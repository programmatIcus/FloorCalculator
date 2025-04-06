using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace FloorAndCarpetApp
{
    public partial class FloorAndCarpet : Form
    {   
        private Customer _customer;

        ObservableCollection<Material> floorList = new ObservableCollection<Material>();
        private BindingSource bindingSource = new BindingSource();
        public FloorAndCarpet()
        {
            InitializeComponent();
            dgv01.CellClick += new DataGridViewCellEventHandler(dgv01_CellContentClick);
            InitializeFloorList();
            BindFloorListToDataGridView();
            txtBoxFirstName.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtBoxLastName.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtBoxCity.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtBoxAddress1.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_LetterAndNumber);
            txtBoxAddress2.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_LetterAndNumber);
            txtBoxZipCode.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_ZipCode);
            txtBoxPhoneNumber.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_PhoneNumber);
            txtBoxEmail.Leave += new EventHandler(TextBox_Leave_Email);
            txtWidth.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_Width);
            txtLength.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_Length);
        }

        private void InitializeFloorList()
        {
            {
                floorList.Add(new Material("Cherry", "Hardwood", 6.25m));
                floorList.Add(new Material("Oak", "Hardwood", 10.75m));
                floorList.Add(new Material("Walnut", "Hardwood", 8.49m));
                floorList.Add(new Material("Bamboo", "Hardwood", 10.00m));
                floorList.Add(new Material("Pine Laminate", "Laminate", 7.25m));
                floorList.Add(new Material("Oak Laminate", "Laminate", 7.50m));
                floorList.Add(new Material("Cherry Laminate", "Laminate", 7.75m));
                floorList.Add(new Material("Maple Laminate", "Laminate", 8.00m));
                floorList.Add(new Material("Linoleum Sheet", "Linoleum", 6.00m));
                floorList.Add(new Material("Linoleum Tile", "Linoleum", 6.25m));
                floorList.Add(new Material("Linoleum Plank", "Linoleum", 6.50m));
                floorList.Add(new Material("Glazed Ceramic Tile", "Tile", 6.75m));
                floorList.Add(new Material("Quarry Tile", "Tile", 10.00m));
                floorList.Add(new Material("Porcelain Tile", "Tile", 30.00m));
                floorList.Add(new Material("Terracotta Tile", "Tile", 25.00m));
                floorList.Add(new Material("Wool Carpet", "Carpet", 7.00m));
                floorList.Add(new Material("Nylon Carpet", "Carpet", 7.25m));
                floorList.Add(new Material("Acrylic Carpet", "Carpet", 7.50m));
                floorList.Add(new Material("Polyester Carpet", "Carpet", 7.70m));
                floorList.Add(new Material("Travertine", "Stone", 22.00m));
                floorList.Add(new Material("Marble", "Stone", 50.00m));
                floorList.Add(new Material("Granite", "Stone", 40.00m));
                floorList.Add(new Material("Slate", "Stone", 20.00m));
                floorList.Add(new Material("Vinyl Sheet", "Vinyl", 4.25m));
                floorList.Add(new Material("Vinyl Tile", "Vinyl", 4.50m));
                floorList.Add(new Material("WPC Vinyl", "Vinyl", 4.75m));
                floorList.Add(new Material("Hybrid Resilient Vinyl", "Vinyl", 5.00m));
            }
        }

        private void BindFloorListToDataGridView()
        {
            bindingSource.DataSource = floorList;
            dgv01.DataSource = bindingSource;
        }

        private void dgv01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure user did not click the header
            {
                DataGridViewRow row = dgv01.Rows[e.RowIndex]; // Grab the clicked row

                // Populate the text boxes
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtType.Text = row.Cells["Type"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   

            richTextBox1.Clear();

            // Check if the text boxes are empty
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtType.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please select a material from the list.");
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int width))
            {
                txtWidth.Text = String.Empty;
                MessageBox.Show("Please enter an integer.");
                txtWidth.Focus();
            }

            if (!int.TryParse(txtLength.Text, out int length))
            {
                txtLength.Text = String.Empty;
                MessageBox.Show("Please enter an integer.");
                txtLength.Focus();
            }

            width = Math.Abs(width);
            length = Math.Abs(length);

            decimal sqFt = width * length;

            if (sqFt > 5_000)
            {
                MessageBox.Show("The total square feet should not exceed 5,000 square feet.");
                return;
            }

            decimal sqYrd = sqFt / 9m;

            txtSqFt.Text = sqFt.ToString();
            txtSqYrd.Text = sqYrd.ToString("F2");

            if (decimal.TryParse(txtPrice.Text, out decimal pricePerSqFoot))
            {  
                decimal matCost = pricePerSqFoot * sqFt;
                txtMatCost.Text = matCost.ToString("C2"); // Format as currency
                txtPrice.Text = matCost.ToString("C2");

                // Calculate labor cost
                decimal laborCharge;
                decimal laborCost;
                if (radProfessional.Checked)
                { 
                    laborCharge = 30m;
                    laborCost = laborCharge * sqFt;
                    txtLaborCharge.Text = "$30.00 Per Square Foot";
                }
                else if (radSelfMotivated.Checked)
                {
                    laborCharge = 0m; // No charge for self-motivated installation
                    laborCost = 0;
                    txtLaborCharge.Text = "Self-Motivated Install";
                }
                else
                {
                    MessageBox.Show("Please select an installation type.");
                    return;
                }

                txtLaborCost.Text = laborCost.ToString("C2");

                // Calculate total estimate
                decimal totalEstimate = matCost + laborCost;
                txtTotalEstimate.Text = totalEstimate.ToString("C2");
            }

            string row = $"Name: {txtName.Text}\n" +
                         $"Type: {txtType.Text}\n" +
                         $"Price: {txtPrice.Text} In Material\n" +
                         $"Width: {txtWidth.Text} Feet\n" +
                         $"Length: {txtLength.Text} Feet\n" +
                         $"Square Feet: {txtSqFt.Text} Square Feet\n" +
                         $"Square Yards: {txtSqYrd.Text} Square Yards\n" +
                         $"Material Cost: {txtMatCost.Text}\n" +
                         $"Labor Charge: {txtLaborCharge.Text}\n" +
                         $"Labor Cost: {txtLaborCost.Text}\n" +
                         $"Total Estimate: {txtTotalEstimate.Text}\n";

            richTextBox1.AppendText(row + "\n\n");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var requiredFields = new List<TextBox>
            {
                txtBoxFirstName,
                txtBoxLastName,
                txtBoxAddress1,
                txtBoxCity,
                txtBoxZipCode,
                txtBoxPhoneNumber,
                txtBoxEmail
            };

            foreach (var textBox in requiredFields)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Please fill out all required fields.");
                    return;
                }
            }

            if (cboBoxState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a state.");
                return;
            }

            _customer = new Customer
            (
                txtBoxFirstName.Text,
                txtBoxLastName.Text,
                txtBoxAddress1.Text,
                txtBoxAddress2.Text,
                txtBoxCity.Text,
                cboBoxState.SelectedItem.ToString(),
                txtBoxZipCode.Text,
                txtBoxPhoneNumber.Text,
                txtBoxEmail.Text
            );

            ClearForm();

            tabControl1.SelectedIndex = 1;
            
        }

        private void ClearForm()
        {
            foreach (Control control in tabPage1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            foreach (Control control in tabPage2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            radProfessional.Checked = false;
            radSelfMotivated.Checked = false;
            cboBoxState.SelectedIndex = -1;
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                ShowColor = true,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = true,
                MaxSize = 16,
                MinSize = 8
            };

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                tabPage1.Font = fontDialog.Font;
                tabPage2.Font = fontDialog.Font;
            }
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true,
                Color = Color.Black,
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tabPage1.ForeColor = colorDialog.Color;
                tabPage2.ForeColor = colorDialog.Color;
            }
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Floor and Carpet Application. It allows you to select a material, " +
                            "calculate costs based on dimensions and installation type, and save customer information.", 
                            "Program Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ClearForm();   
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_customer, richTextBox1.Text);
            form2.Show();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle the key press event here
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyPress_LetterAndNumber(object sender, KeyPressEventArgs e)
        {
            // Handle the key press event here
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyPress_ZipCode(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits for the Zip Code.");
            }
            // Check if the text box already contains 5 digits
            else if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 5)
            {
                e.Handled = true;
                MessageBox.Show("The Zip Code should be 5 digits long.");
            }
        }

        private void TextBox_KeyPress_PhoneNumber(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits, control characters, and dashes
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits and dashes for the Phone Number.");
            }
            // Check if the text box already contains 12 characters
            else if ((char.IsDigit(e.KeyChar) || e.KeyChar == '-') && textBox.Text.Length >= 12)
            {
                e.Handled = true;
                MessageBox.Show("The Phone Number should be in the format: 123-456-1234.");
            }
            // Check if the dash is in the correct position
            else if (e.KeyChar == '-' && (textBox.Text.Length != 3 && textBox.Text.Length != 7))
            {
                e.Handled = true;
                MessageBox.Show("The Phone Number should be in the format: 123-456-1234.");
            }
            // Check if a digit is in the position where a dash should be
            else if (char.IsDigit(e.KeyChar) && (textBox.Text.Length == 3 || textBox.Text.Length == 7))
            {
                e.Handled = true;
                MessageBox.Show("The Phone Number should be in the format: 123-456-1234.");
            }
        }

        private void TextBox_Leave_Email(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check if the text box does not end with ".com"
            if (!textBox.Text.ToLower().EndsWith(".com"))
            {
                MessageBox.Show("The Email should end with '.com'.");
                textBox.Focus();
            }
        }

        private void TextBox_KeyPress_Width(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits for the Width.");
            }
            // Check if the text box already contains 3 digits
            else if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 3)
            {
                e.Handled = true;
                MessageBox.Show("The Width should be up to 3 digits long.");
            }
        }

        private void TextBox_KeyPress_Length(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits for the Length.");
            }
            // Check if the text box already contains 3 digits
            else if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 3)
            {
                e.Handled = true;
                MessageBox.Show("The Length should be up to 3 digits long.");
            }
        }

    }
}
