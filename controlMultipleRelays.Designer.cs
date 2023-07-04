﻿namespace MissionPlanner
{
    partial class controlMultipleRelays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlMultipleRelays));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftAll = new MissionPlanner.Controls.MyButton();
            this.LeftOnOff = new System.Windows.Forms.GroupBox();
            this.leftOn = new System.Windows.Forms.RadioButton();
            this.leftOff = new System.Windows.Forms.RadioButton();
            this.leftOne = new MissionPlanner.Controls.MyButton();
            this.leftFive = new MissionPlanner.Controls.MyButton();
            this.leftTwo = new MissionPlanner.Controls.MyButton();
            this.leftThree = new MissionPlanner.Controls.MyButton();
            this.leftFour = new MissionPlanner.Controls.MyButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightOnOff = new System.Windows.Forms.GroupBox();
            this.rightOn = new System.Windows.Forms.RadioButton();
            this.rightOff = new System.Windows.Forms.RadioButton();
            this.rightAll = new MissionPlanner.Controls.MyButton();
            this.rightTwo = new MissionPlanner.Controls.MyButton();
            this.rightOne = new MissionPlanner.Controls.MyButton();
            this.rightFive = new MissionPlanner.Controls.MyButton();
            this.rightThree = new MissionPlanner.Controls.MyButton();
            this.rightFour = new MissionPlanner.Controls.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.LeftOnOff.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rightOnOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftAll);
            this.groupBox1.Controls.Add(this.LeftOnOff);
            this.groupBox1.Controls.Add(this.leftOne);
            this.groupBox1.Controls.Add(this.leftFive);
            this.groupBox1.Controls.Add(this.leftTwo);
            this.groupBox1.Controls.Add(this.leftThree);
            this.groupBox1.Controls.Add(this.leftFour);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 316);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left";
            // 
            // leftAll
            // 
            this.leftAll.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftAll.Location = new System.Drawing.Point(451, 61);
            this.leftAll.Name = "leftAll";
            this.leftAll.Size = new System.Drawing.Size(204, 109);
            this.leftAll.TabIndex = 6;
            this.leftAll.Text = "Select All";
            this.leftAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftAll.UseVisualStyleBackColor = true;
            this.leftAll.Click += new System.EventHandler(this.leftAll_Click);
            // 
            // LeftOnOff
            // 
            this.LeftOnOff.Controls.Add(this.leftOn);
            this.LeftOnOff.Controls.Add(this.leftOff);
            this.LeftOnOff.Location = new System.Drawing.Point(17, 50);
            this.LeftOnOff.Name = "LeftOnOff";
            this.LeftOnOff.Size = new System.Drawing.Size(416, 121);
            this.LeftOnOff.TabIndex = 9;
            this.LeftOnOff.TabStop = false;
            // 
            // leftOn
            // 
            this.leftOn.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOn.Location = new System.Drawing.Point(22, 47);
            this.leftOn.Name = "leftOn";
            this.leftOn.Size = new System.Drawing.Size(197, 39);
            this.leftOn.TabIndex = 0;
            this.leftOn.TabStop = true;
            this.leftOn.Text = "Fire";
            this.leftOn.UseVisualStyleBackColor = true;
            this.leftOn.CheckedChanged += new System.EventHandler(this.leftOn_CheckedChanged);
            // 
            // leftOff
            // 
            this.leftOff.Checked = true;
            this.leftOff.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOff.Location = new System.Drawing.Point(255, 47);
            this.leftOff.Name = "leftOff";
            this.leftOff.Size = new System.Drawing.Size(146, 39);
            this.leftOff.TabIndex = 0;
            this.leftOff.TabStop = true;
            this.leftOff.Text = "Reset";
            this.leftOff.UseVisualStyleBackColor = true;
            this.leftOff.CheckedChanged += new System.EventHandler(this.leftOff_CheckedChanged);
            // 
            // leftOne
            // 
            this.leftOne.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftOne.Location = new System.Drawing.Point(6, 189);
            this.leftOne.Name = "leftOne";
            this.leftOne.Size = new System.Drawing.Size(112, 109);
            this.leftOne.TabIndex = 2;
            this.leftOne.Text = "1";
            this.leftOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftOne.UseVisualStyleBackColor = true;
            this.leftOne.Click += new System.EventHandler(this.leftOne_Click);
            // 
            // leftFive
            // 
            this.leftFive.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftFive.Location = new System.Drawing.Point(543, 189);
            this.leftFive.Name = "leftFive";
            this.leftFive.Size = new System.Drawing.Size(112, 109);
            this.leftFive.TabIndex = 6;
            this.leftFive.Text = "5";
            this.leftFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFive.UseVisualStyleBackColor = true;
            this.leftFive.Click += new System.EventHandler(this.leftFive_Click);
            // 
            // leftTwo
            // 
            this.leftTwo.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftTwo.Location = new System.Drawing.Point(141, 189);
            this.leftTwo.Name = "leftTwo";
            this.leftTwo.Size = new System.Drawing.Size(112, 109);
            this.leftTwo.TabIndex = 3;
            this.leftTwo.Text = "2";
            this.leftTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftTwo.UseVisualStyleBackColor = true;
            this.leftTwo.Click += new System.EventHandler(this.leftTwo_Click);
            // 
            // leftThree
            // 
            this.leftThree.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftThree.Location = new System.Drawing.Point(276, 189);
            this.leftThree.Name = "leftThree";
            this.leftThree.Size = new System.Drawing.Size(112, 109);
            this.leftThree.TabIndex = 4;
            this.leftThree.Text = "3";
            this.leftThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftThree.UseVisualStyleBackColor = true;
            this.leftThree.Click += new System.EventHandler(this.leftThree_Click);
            // 
            // leftFour
            // 
            this.leftFour.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftFour.Location = new System.Drawing.Point(408, 189);
            this.leftFour.Name = "leftFour";
            this.leftFour.Size = new System.Drawing.Size(112, 109);
            this.leftFour.TabIndex = 5;
            this.leftFour.Text = "4";
            this.leftFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.leftFour.UseVisualStyleBackColor = true;
            this.leftFour.Click += new System.EventHandler(this.leftFour_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rightOnOff);
            this.groupBox2.Controls.Add(this.rightAll);
            this.groupBox2.Controls.Add(this.rightTwo);
            this.groupBox2.Controls.Add(this.rightOne);
            this.groupBox2.Controls.Add(this.rightFive);
            this.groupBox2.Controls.Add(this.rightThree);
            this.groupBox2.Controls.Add(this.rightFour);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(682, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 316);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rightOnOff
            // 
            this.rightOnOff.Controls.Add(this.rightOn);
            this.rightOnOff.Controls.Add(this.rightOff);
            this.rightOnOff.Location = new System.Drawing.Point(6, 50);
            this.rightOnOff.Name = "rightOnOff";
            this.rightOnOff.Size = new System.Drawing.Size(422, 121);
            this.rightOnOff.TabIndex = 10;
            this.rightOnOff.TabStop = false;
            // 
            // rightOn
            // 
            this.rightOn.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOn.Location = new System.Drawing.Point(31, 47);
            this.rightOn.Name = "rightOn";
            this.rightOn.Size = new System.Drawing.Size(170, 39);
            this.rightOn.TabIndex = 0;
            this.rightOn.TabStop = true;
            this.rightOn.Text = "Fire";
            this.rightOn.UseVisualStyleBackColor = true;
            this.rightOn.CheckedChanged += new System.EventHandler(this.rightOn_CheckedChanged);
            // 
            // rightOff
            // 
            this.rightOff.Checked = true;
            this.rightOff.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOff.Location = new System.Drawing.Point(263, 47);
            this.rightOff.Name = "rightOff";
            this.rightOff.Size = new System.Drawing.Size(139, 39);
            this.rightOff.TabIndex = 0;
            this.rightOff.TabStop = true;
            this.rightOff.Text = "Reset";
            this.rightOff.UseVisualStyleBackColor = true;
            this.rightOff.CheckedChanged += new System.EventHandler(this.rightOff_CheckedChanged);
            // 
            // rightAll
            // 
            this.rightAll.Font = new System.Drawing.Font("Gulim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightAll.Location = new System.Drawing.Point(447, 62);
            this.rightAll.Name = "rightAll";
            this.rightAll.Size = new System.Drawing.Size(201, 109);
            this.rightAll.TabIndex = 6;
            this.rightAll.Text = "Select All";
            this.rightAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightAll.UseVisualStyleBackColor = true;
            this.rightAll.Click += new System.EventHandler(this.rightAll_Click);
            // 
            // rightTwo
            // 
            this.rightTwo.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightTwo.Location = new System.Drawing.Point(133, 189);
            this.rightTwo.Name = "rightTwo";
            this.rightTwo.Size = new System.Drawing.Size(112, 109);
            this.rightTwo.TabIndex = 3;
            this.rightTwo.Text = "2";
            this.rightTwo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightTwo.UseVisualStyleBackColor = true;
            this.rightTwo.Click += new System.EventHandler(this.rightTwo_Click);
            // 
            // rightOne
            // 
            this.rightOne.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightOne.Location = new System.Drawing.Point(1, 189);
            this.rightOne.Name = "rightOne";
            this.rightOne.Size = new System.Drawing.Size(112, 109);
            this.rightOne.TabIndex = 2;
            this.rightOne.Text = "1";
            this.rightOne.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightOne.UseVisualStyleBackColor = true;
            this.rightOne.Click += new System.EventHandler(this.rightOne_Click);
            // 
            // rightFive
            // 
            this.rightFive.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightFive.Location = new System.Drawing.Point(536, 189);
            this.rightFive.Name = "rightFive";
            this.rightFive.Size = new System.Drawing.Size(112, 109);
            this.rightFive.TabIndex = 6;
            this.rightFive.Text = "5";
            this.rightFive.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFive.UseVisualStyleBackColor = true;
            this.rightFive.Click += new System.EventHandler(this.rightFive_Click);
            // 
            // rightThree
            // 
            this.rightThree.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightThree.Location = new System.Drawing.Point(269, 189);
            this.rightThree.Name = "rightThree";
            this.rightThree.Size = new System.Drawing.Size(112, 109);
            this.rightThree.TabIndex = 4;
            this.rightThree.Text = "3";
            this.rightThree.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightThree.UseVisualStyleBackColor = true;
            this.rightThree.Click += new System.EventHandler(this.rightThree_Click);
            // 
            // rightFour
            // 
            this.rightFour.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightFour.Location = new System.Drawing.Point(401, 189);
            this.rightFour.Name = "rightFour";
            this.rightFour.Size = new System.Drawing.Size(112, 109);
            this.rightFour.TabIndex = 5;
            this.rightFour.Text = "4";
            this.rightFour.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.rightFour.UseVisualStyleBackColor = true;
            this.rightFour.Click += new System.EventHandler(this.rightFour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(143, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select and press buttons 1 to 5 to prepare for firing.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1319, 259);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(141, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(720, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Press the Fire button to fire the selected bullet.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(141, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1008, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "When all bullets have been fired, press the Reset button to reload.";
            // 
            // controlMultipleRelays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "controlMultipleRelays";
            this.Text = "DEFENCE KOREA";
            this.groupBox1.ResumeLayout(false);
            this.LeftOnOff.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.rightOnOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton leftOne;
        private Controls.MyButton leftTwo;
        private Controls.MyButton leftThree;
        private Controls.MyButton leftFour;
        private Controls.MyButton leftFive;
        private Controls.MyButton rightOne;
        private Controls.MyButton rightTwo;
        private Controls.MyButton rightThree;
        private Controls.MyButton rightFour;
        private Controls.MyButton rightFive;
        private Controls.MyButton rightAll;
        private Controls.MyButton leftAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton leftOff;
        private System.Windows.Forms.RadioButton leftOn;
        private System.Windows.Forms.RadioButton rightOff;
        private System.Windows.Forms.RadioButton rightOn;
        private System.Windows.Forms.GroupBox LeftOnOff;
        private System.Windows.Forms.GroupBox rightOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}