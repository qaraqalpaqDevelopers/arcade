namespace arcade
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line6 = new System.Windows.Forms.PictureBox();
            this.line5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(468, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 640);
            this.label7.TabIndex = 6;
            this.label7.Text = " ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(507, -22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 661);
            this.label8.TabIndex = 7;
            this.label8.Text = " ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(12, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 640);
            this.label9.TabIndex = 11;
            this.label9.Text = " ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(950, -22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 640);
            this.label10.TabIndex = 12;
            this.label10.Text = " ";
            // 
            // car
            // 
            this.car.Image = global::arcade.Properties.Resources.c_2;
            this.car.Location = new System.Drawing.Point(287, 460);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(106, 176);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 13;
            this.car.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line2.Location = new System.Drawing.Point(230, 240);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(20, 120);
            this.line2.TabIndex = 14;
            this.line2.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line3.Location = new System.Drawing.Point(230, 460);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(20, 120);
            this.line3.TabIndex = 15;
            this.line3.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(230, 1);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(20, 120);
            this.line1.TabIndex = 19;
            this.line1.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line4.Location = new System.Drawing.Point(735, 0);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(20, 120);
            this.line4.TabIndex = 22;
            this.line4.TabStop = false;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.White;
            this.line6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line6.Location = new System.Drawing.Point(735, 460);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(20, 120);
            this.line6.TabIndex = 21;
            this.line6.TabStop = false;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.White;
            this.line5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line5.Location = new System.Drawing.Point(735, 240);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(20, 120);
            this.line5.TabIndex = 20;
            this.line5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy1
            // 
            this.enemy1.Image = global::arcade.Properties.Resources.c_1;
            this.enemy1.Location = new System.Drawing.Point(67, 200);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(106, 176);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 23;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::arcade.Properties.Resources.c_1;
            this.enemy2.Location = new System.Drawing.Point(306, 1);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(106, 172);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 24;
            this.enemy2.TabStop = false;
            this.enemy2.Click += new System.EventHandler(this.enemy2_Click);
            // 
            // enemy3
            // 
            this.enemy3.Image = global::arcade.Properties.Resources.c_1;
            this.enemy3.Location = new System.Drawing.Point(558, 460);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(106, 176);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 25;
            this.enemy3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(227, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 91);
            this.label1.TabIndex = 26;
            this.label1.Text = "GAME OVER! ";
            // 
            // enemy4
            // 
            this.enemy4.Image = global::arcade.Properties.Resources.c_1;
            this.enemy4.Location = new System.Drawing.Point(808, 282);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(106, 172);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 27;
            this.enemy4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(372, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 63);
            this.button1.TabIndex = 28;
            this.button1.Text = "RESTART";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.car);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line6);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line6;
        private System.Windows.Forms.PictureBox line5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.Button button1;
    }
}

