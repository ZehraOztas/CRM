using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeOdevi
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        public void CreateMyPanel()
        {
           
            TextBox textBox1 = new TextBox();
            Label label1 = new Label();

            // Initialize the Panel control.
           //  panel1.Location = new Point(56, 72);
            panel1.Size = new Size(264, 152);
            // Set the Borderstyle for the Panel to three-dimensional.
            //panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            label1.Location = new Point(16, 16);
            label1.Text = "label1";
            label1.Size = new Size(104, 16);
            textBox1.Location = new Point(16, 32);
            textBox1.Text = "";
            textBox1.Size = new Size(152, 20);

            // Add the Panel control to the form.
            this.Controls.Add(panel1);
            // Add the Label and TextBox controls to the Panel.
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CreateMyPanel();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }
    }
}
