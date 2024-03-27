using System;
using System.Windows.Forms;

namespace testes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string text = txtText.Text;
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            Button novo = new Button();

            novo.Name = name;
            novo.Text = text;
            novo.Location = new Point(x, y);


            this.Controls.Add(novo);
            


        }
    }
}