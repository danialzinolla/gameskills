namespace gameskills
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDragon = new System.Windows.Forms.PictureBox();
            this.timDragon = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.picRing1 = new System.Windows.Forms.PictureBox();
            this.picRing2 = new System.Windows.Forms.PictureBox();
            this.picRing3 = new System.Windows.Forms.PictureBox();
            this.picRing4 = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.picFired = new System.Windows.Forms.PictureBox();
            this.timFireBall = new System.Windows.Forms.Timer(this.components);
            this.picMissile = new System.Windows.Forms.PictureBox();
            this.timMissile = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).BeginInit();
            this.SuspendLayout();
            // 
            // picDragon
            // 
            this.picDragon.BackColor = System.Drawing.Color.Transparent;
            this.picDragon.Image = ((System.Drawing.Image)(resources.GetObject("picDragon.Image")));
            this.picDragon.Location = new System.Drawing.Point(647, 63);
            this.picDragon.Name = "picDragon";
            this.picDragon.Size = new System.Drawing.Size(147, 95);
            this.picDragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDragon.TabIndex = 0;
            this.picDragon.TabStop = false;
            this.picDragon.Click += new System.EventHandler(this.picDragon_Click);
            // 
            // timDragon
            // 
            this.timDragon.Interval = 10;
            this.timDragon.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Red;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(751, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // picRing1
            // 
            this.picRing1.BackColor = System.Drawing.Color.Transparent;
            this.picRing1.Image = ((System.Drawing.Image)(resources.GetObject("picRing1.Image")));
            this.picRing1.Location = new System.Drawing.Point(405, 63);
            this.picRing1.Name = "picRing1";
            this.picRing1.Size = new System.Drawing.Size(44, 47);
            this.picRing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing1.TabIndex = 2;
            this.picRing1.TabStop = false;
            // 
            // picRing2
            // 
            this.picRing2.BackColor = System.Drawing.Color.Transparent;
            this.picRing2.Image = ((System.Drawing.Image)(resources.GetObject("picRing2.Image")));
            this.picRing2.Location = new System.Drawing.Point(298, 101);
            this.picRing2.Name = "picRing2";
            this.picRing2.Size = new System.Drawing.Size(44, 47);
            this.picRing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing2.TabIndex = 3;
            this.picRing2.TabStop = false;
            // 
            // picRing3
            // 
            this.picRing3.BackColor = System.Drawing.Color.Transparent;
            this.picRing3.Image = ((System.Drawing.Image)(resources.GetObject("picRing3.Image")));
            this.picRing3.Location = new System.Drawing.Point(198, 53);
            this.picRing3.Name = "picRing3";
            this.picRing3.Size = new System.Drawing.Size(44, 47);
            this.picRing3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing3.TabIndex = 4;
            this.picRing3.TabStop = false;
            // 
            // picRing4
            // 
            this.picRing4.BackColor = System.Drawing.Color.Transparent;
            this.picRing4.Image = ((System.Drawing.Image)(resources.GetObject("picRing4.Image")));
            this.picRing4.Location = new System.Drawing.Point(99, 101);
            this.picRing4.Name = "picRing4";
            this.picRing4.Size = new System.Drawing.Size(44, 47);
            this.picRing4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing4.TabIndex = 5;
            this.picRing4.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.BackColor = System.Drawing.Color.Transparent;
            this.picTank.Image = ((System.Drawing.Image)(resources.GetObject("picTank.Image")));
            this.picTank.Location = new System.Drawing.Point(405, 374);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(80, 64);
            this.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTank.TabIndex = 6;
            this.picTank.TabStop = false;
            // 
            // picFired
            // 
            this.picFired.BackColor = System.Drawing.Color.Transparent;
            this.picFired.Image = ((System.Drawing.Image)(resources.GetObject("picFired.Image")));
            this.picFired.Location = new System.Drawing.Point(836, 79);
            this.picFired.Name = "picFired";
            this.picFired.Size = new System.Drawing.Size(34, 45);
            this.picFired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFired.TabIndex = 7;
            this.picFired.TabStop = false;
            // 
            // picMissile
            // 
            this.picMissile.BackColor = System.Drawing.Color.Transparent;
            this.picMissile.Image = ((System.Drawing.Image)(resources.GetObject("picMissile.Image")));
            this.picMissile.Location = new System.Drawing.Point(860, 392);
            this.picMissile.Name = "picMissile";
            this.picMissile.Size = new System.Drawing.Size(22, 37);
            this.picMissile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissile.TabIndex = 8;
            this.picMissile.TabStop = false;
            // 
            // timMissile
            // 
            this.timMissile.Interval = 1;
            this.timMissile.Tick += new System.EventHandler(this.timMissile_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.picMissile);
            this.Controls.Add(this.picFired);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picRing4);
            this.Controls.Add(this.picRing3);
            this.Controls.Add(this.picRing2);
            this.Controls.Add(this.picRing1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picDragon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDragon;
        private System.Windows.Forms.Timer timDragon;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picRing1;
        private System.Windows.Forms.PictureBox picRing2;
        private System.Windows.Forms.PictureBox picRing3;
        private System.Windows.Forms.PictureBox picRing4;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.PictureBox picFired;
        private System.Windows.Forms.Timer timFireBall;
        private System.Windows.Forms.PictureBox picMissile;
        private System.Windows.Forms.Timer timMissile;
    }
}

