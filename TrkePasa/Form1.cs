using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TrkePasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }
        private void login()
        {
            var posi = this.PointToScreen(panel1.Location);
            posi = pictureBox1.PointToClient(posi);
            panel1.Parent = pictureBox1;
            panel1.Location = posi;
            panel1.BackColor = Color.FromArgb(220,Color.Black);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = panel1;
            label2.BackColor = Color.Transparent;

            label3.Parent = panel1;
            label3.BackColor = Color.Transparent;
            textBox2.PasswordChar = '\u25CF';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            login();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool u = false;
            bool p = false;
            string us = textBox1.Text;
            string pas = textBox2.Text;
            //CHECKING INFO
            XmlTextReader xtxtr = new XmlTextReader("C:\\Users\\Vuk\\Desktop\\TRKE PASA PROJEKAT\\TrkePasa\\profile_data.xml");
            while (xtxtr.Read())
            {
                if(xtxtr.NodeType == XmlNodeType.Element && xtxtr.Name == "username")
                {
                    if (us != xtxtr.ReadElementString())
                    {
                        MessageBox.Show("    USERNAME IS INCORRECT");
                    }
                    else
                    {
                        u = true;
                    }
                }
                if (xtxtr.NodeType == XmlNodeType.Element && xtxtr.Name == "password")
                {
                    if (pas != xtxtr.ReadElementString())
                    {
                        MessageBox.Show("    PASSWORD IS INCORRECT");
                    }
                    else
                    {
                        p = true;
                    }
                }
            }
            if(p == true && u == true)
            {
                //OTVORI SLEDECU FORMU
            }
            
        }
    }
}
