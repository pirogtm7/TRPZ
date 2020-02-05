using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameShop
{
    public partial class Form1 : Form
    {
        FrameShop myFrameShop = new FrameShop();

        Frame myFrame;

        public Form1()
        {
            InitializeComponent();

            myFrameShop.AddMaterials();

            foreach (Material material in myFrameShop.Materials)
            {
                materialsCheckedListBox.Items.Add(material.Name);

            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            myFrame = new Frame() { Width = Convert.ToInt32(widthTextBox.Text), Length = Convert.ToInt32(lengthTextBox.Text),
                Quantity = Convert.ToInt32(quantityTextBox.Text) };

            foreach (Material material in myFrameShop.Materials)
            {
                foreach (string s in materialsCheckedListBox.CheckedItems)
                {
                    if (material.Name == s)
                    {
                        myFrame.Materials.Add(material);
                        int finalAmount = material.QuanPerUnit * myFrame.Width * myFrame.Length * myFrame.Quantity;

                        if (material.QuanInStock >= finalAmount)
                        {
                            checkLabel.Text += "You have enough of " + material.Name + ". \n You need: " + finalAmount + ". You have: " + material.QuanInStock + ". \n\n ";
                        }

                        else if (material.QuanInStock < finalAmount)
                        {
                            checkLabel.Text += "You don't have enough of " + material.Name + ". \n You need: " + finalAmount + ". You have: " + material.QuanInStock + ". \n\n ";
                        }
                    }
                }
            }
        }
    }
}