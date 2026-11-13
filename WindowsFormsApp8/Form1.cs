using System;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
         Dog dog;
        static System.Timers.Timer tamagochiTimer = new System.Timers.Timer(2000);
    
        public Form1()
        {
            InitializeComponent();
            dog = new Dog();
            this.progressBarEnergy.SetState(1);
            this.progressBarHungry.SetState(1);
            this.progressBarHappiness.SetState(1);
            initUI();

            tamagochiTimer.Elapsed += Tick;
            tamagochiTimer.Enabled = true;
        }

        private void Tick(Object source, ElapsedEventArgs e)
        {
            dog.increaseHungry(5);
            dog.decreaseEnergy(5);
            dog.decreaseHappiness(5);

            if (dog.getEnergy() == 0 || dog.getHungry() == 100 || dog.getHappiness() == 0)
            {
                this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_5;
                tamagochiTimer.Enabled = false;

                DialogResult dr = MessageBox.Show("Ваш пес пішов шукати кращого хазяїна!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(dr == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            else if (dog.getEnergy() <= 30 || dog.getHungry() > 80)
                this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_3;
            else if (dog.getEnergy() >= 80 && dog.getHungry() <= 50)
                this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_1;

            initUI();
        }

        private void initUI()
        {
            this.progressBarEnergy.Value = dog.getEnergy();
            this.progressBarHungry.Value = dog.getHungry();
            this.progressBarHappiness.Value = dog.getHappiness();

            if (dog.getEnergy() <= 30)
                this.progressBarEnergy.SetState(2);
            else if (dog.getEnergy() < 80)
                this.progressBarEnergy.SetState(3);
            else
                this.progressBarEnergy.SetState(1);

            if (dog.getHungry() > 80)
                this.progressBarHungry.SetState(2);
            else if (dog.getHungry() > 50)
                this.progressBarHungry.SetState(3);
            else
                this.progressBarHungry.SetState(1);

            if (dog.getHappiness() <= 30)
                this.progressBarHappiness.SetState(2);
            else if (dog.getHappiness() < 80)
                this.progressBarHappiness.SetState(3);
            else
                this.progressBarHappiness.SetState(1);
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            dog.increaseHappiness(15);
            dog.increaseHungry(15);
            dog.decreaseEnergy(15);
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_4;

            initUI();
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            dog.increaseEnergy(15);
            dog.increaseHungry(15);
            dog.decreaseHappiness(15);
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_2;

            initUI();
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            dog.increaseEnergy(15);
            dog.increaseHappiness(15);
            dog.decreaseHungry(15);

            initUI();
        }
    }
}
