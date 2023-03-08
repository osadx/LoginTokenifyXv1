using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTokenifyXv1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }


        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // dodaj kod, który ma być wykonywany po zmianie tekstu w polu tekstowym
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            // ReSharper disable once SuggestVarOrType_SimpleTypes
            Main mainForm = new Main();
            mainForm.Show();
    
            // Ukryj bieżący formularz
            this.Hide();
        }
    }
}