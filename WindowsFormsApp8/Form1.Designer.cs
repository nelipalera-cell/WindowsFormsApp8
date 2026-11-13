namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarHungry = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarHappiness = new System.Windows.Forms.ProgressBar();
            this.buttonGame = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonEat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Затишні_будні_лабрадора_1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarHungry
            // 
            this.progressBarHungry.Location = new System.Drawing.Point(218, 43);
            this.progressBarHungry.Name = "progressBarHungry";
            this.progressBarHungry.Size = new System.Drawing.Size(299, 22);
            this.progressBarHungry.TabIndex = 1;
            this.progressBarHungry.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Голод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Енергія";
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(218, 101);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(299, 22);
            this.progressBarEnergy.TabIndex = 3;
            this.progressBarEnergy.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(217, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Щастя";
            // 
            // progressBarHappiness
            // 
            this.progressBarHappiness.Location = new System.Drawing.Point(217, 161);
            this.progressBarHappiness.Name = "progressBarHappiness";
            this.progressBarHappiness.Size = new System.Drawing.Size(299, 22);
            this.progressBarHappiness.TabIndex = 5;
            this.progressBarHappiness.Value = 50;
            // 
            // buttonGame
            // 
            this.buttonGame.Location = new System.Drawing.Point(12, 213);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(150, 50);
            this.buttonGame.TabIndex = 7;
            this.buttonGame.Text = "Пограти";
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Location = new System.Drawing.Point(190, 213);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(150, 50);
            this.buttonSleep.TabIndex = 8;
            this.buttonSleep.Text = "Поспати";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonEat
            // 
            this.buttonEat.Location = new System.Drawing.Point(366, 213);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.Size = new System.Drawing.Size(150, 50);
            this.buttonEat.TabIndex = 9;
            this.buttonEat.Text = "Поїсти";
            this.buttonEat.UseVisualStyleBackColor = true;
            this.buttonEat.Click += new System.EventHandler(this.buttonEat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 280);
            this.Controls.Add(this.buttonEat);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarHappiness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarHungry);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarHungry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarHappiness;
        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonEat;
    }
}

