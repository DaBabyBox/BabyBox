﻿using System;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        int count = 0;

        public void generateNumber()
        {
            rightButton();
            RandomNumber randomNumber = new RandomNumber(this);
            randomNumber.GenerateNumber();
        }
        

        public  void BtnStart_Click(object sender, EventArgs e)
        {
            disableBoxes();
            RandomNumber randomNumber = new RandomNumber(this);
            randomNumber.GenerateNumber();
            BtnStart.Visible = false;
        }

        
        public void wrongButton()
        {
            MessageBox.Show("This is the wrong Color");
            count = 0;
            LbScore.Text = count.ToString();
            //veranderen door timer.
        }

        public void rightButton()
        {
           // MessageBox.Show("This is the right Color");
        }
       
        public void addScore()
        {
            count++;
            LbScore.Text = count.ToString();
        }


        private void BlueBox_Click(object sender, EventArgs e)
        {
            BlueBox.Visible = false;
            generateNumber();
            addScore();
        }

        private void RedBox_Click(object sender, EventArgs e)
        {
            RedBox.Visible = false;
            generateNumber();
            addScore();
        }

        private void YellowBox_Click(object sender, EventArgs e)
        {
            YellowBox.Visible = false;
            generateNumber();
            addScore();
        }

        private void PurpleBox_Click(object sender, EventArgs e)
        {
            PurpleBox.Visible = false;
            generateNumber();
            addScore();
        }

        private void RedBackground_Click(object sender, EventArgs e)
        {
            wrongButton();
        }

        private void BlueBackground_Click(object sender, EventArgs e)
        {
            wrongButton();
        }

        private void PurpleBackground_Click(object sender, EventArgs e)
        {
            wrongButton();
        }

        private void YellowBlackground_Click(object sender, EventArgs e)
        {
            wrongButton();
        }


        public void disableBoxes()
        {
            BlueBox.Visible = false;
            RedBox.Visible = false;
            YellowBox.Visible = false;
            PurpleBox.Visible = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}