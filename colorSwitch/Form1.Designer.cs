
namespace colorSwitch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreList = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.block1);
            this.panel1.Controls.Add(this.block2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 550);
            this.panel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(191, 502);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 40);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Yellow;
            this.block1.Location = new System.Drawing.Point(0, 240);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(518, 25);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Red;
            this.block2.Location = new System.Drawing.Point(0, 36);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(518, 30);
            this.block2.TabIndex = 0;
            this.block2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: 0";
            // 
            // scoreList
            // 
            this.scoreList.Enabled = false;
            this.scoreList.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scoreList.FormattingEnabled = true;
            this.scoreList.ItemHeight = 15;
            this.scoreList.Location = new System.Drawing.Point(493, 80);
            this.scoreList.Name = "scoreList";
            this.scoreList.Size = new System.Drawing.Size(211, 379);
            this.scoreList.TabIndex = 2;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.playGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 556);
            this.Controls.Add(this.scoreList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Color Switch MOOICT";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyisDonw);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scoreList;
        private System.Windows.Forms.Timer gameTimer;
    }
}

