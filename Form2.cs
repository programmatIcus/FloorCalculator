using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloorAndCarpetApp
{
    public partial class Form2 : Form
    {
        private Customer _customer;
        private string _invoiceText;
        public Form2(Customer customer, string invoiceText)
        {
            InitializeComponent();
            _customer = customer;
            _invoiceText = invoiceText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Check if _customer is not null before trying to access its properties
            if (_customer != null)
            {
                // Display the customer data
                lblCustomerData.Text = $"Name: {_customer.FirstName} {_customer.LastName}\n" +
                                       $"Address: {_customer.Address1} {_customer.Address2}\n" +
                                       $"City: {_customer.City}\n" +
                                       $"State: {_customer.State}\n" +
                                       $"Phone Number: {_customer.Phone}\n" +
                                       $"Email: {_customer.Email}";
            }

            // Display the invoice text
            lblInvoiceText.Text = _invoiceText;
        }

        public void PrintForm()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            btnPrint.Visible = false;
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

    }
}
