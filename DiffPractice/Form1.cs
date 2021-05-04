using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffPractice
{
    public partial class Form1 : Form
    {
        string myName;
        string difficultySetting;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            //grab content from playerNameINput and put it in myName
             myName = playerNameInput.Text;
            //set difficultySetting = "easy"
             difficultySetting = "easy";

        }

        private void mediumButton_Click(object sender, EventArgs e)

        {
            myName = playerNameInput.Text;
            difficultySetting = "Medium";
           

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            myName = playerNameInput.Text;
            difficultySetting = "Hard";
            

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label2.Text = $"Welcome {myName}. A True Brave Hero! Conquer the {difficultySetting} path";
        }
    }
}
