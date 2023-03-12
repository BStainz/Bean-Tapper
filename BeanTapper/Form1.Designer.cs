namespace BeanTapper
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
            this.txtScore = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.beanReceive = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.keg = new System.Windows.Forms.PictureBox();
            this.barTable = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.charTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.beanReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(16, 23);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(131, 31);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score : 0";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.ForeColor = System.Drawing.Color.Black;
            this.txtLevel.Location = new System.Drawing.Point(625, 23);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(125, 31);
            this.txtLevel.TabIndex = 5;
            this.txtLevel.Text = "Level : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(63, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Press Enter to Release the Beans!!!";
            this.label1.Visible = false;
            // 
            // beanReceive
            // 
            this.beanReceive.BackColor = System.Drawing.Color.Transparent;
            this.beanReceive.Image = global::BeanTapper.Properties.Resources.FILLINGUP;
            this.beanReceive.Location = new System.Drawing.Point(613, 122);
            this.beanReceive.Margin = new System.Windows.Forms.Padding(4);
            this.beanReceive.Name = "beanReceive";
            this.beanReceive.Size = new System.Drawing.Size(103, 231);
            this.beanReceive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beanReceive.TabIndex = 7;
            this.beanReceive.TabStop = false;
            this.beanReceive.Visible = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.SlateGray;
            this.Player.Image = global::BeanTapper.Properties.Resources.facingright;
            this.Player.Location = new System.Drawing.Point(647, 360);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(53, 138);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // keg
            // 
            this.keg.Image = global::BeanTapper.Properties.Resources.newkeg;
            this.keg.Location = new System.Drawing.Point(708, 361);
            this.keg.Margin = new System.Windows.Forms.Padding(4);
            this.keg.Name = "keg";
            this.keg.Size = new System.Drawing.Size(99, 138);
            this.keg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keg.TabIndex = 1;
            this.keg.TabStop = false;
            // 
            // barTable
            // 
            this.barTable.Image = global::BeanTapper.Properties.Resources.bartable;
            this.barTable.Location = new System.Drawing.Point(-36, 418);
            this.barTable.Margin = new System.Windows.Forms.Padding(4);
            this.barTable.Name = "barTable";
            this.barTable.Size = new System.Drawing.Size(683, 80);
            this.barTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barTable.TabIndex = 0;
            this.barTable.TabStop = false;
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Black;
            this.Door.Image = global::BeanTapper.Properties.Resources.pngwing_com;
            this.Door.Location = new System.Drawing.Point(-36, 310);
            this.Door.Margin = new System.Windows.Forms.Padding(4);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(100, 121);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 3;
            this.Door.TabStop = false;
            // 
            // charTimer
            // 
            this.charTimer.Interval = 2000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beanReceive);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.keg);
            this.Controls.Add(this.barTable);
            this.Controls.Add(this.Door);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.beanReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox barTable;
        private System.Windows.Forms.PictureBox keg;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox beanReceive;
        private System.Windows.Forms.Timer charTimer;
    }
}

