
namespace Durak
{
    partial class frmMain
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
            this.yourLbl = new System.Windows.Forms.Label();
            this.playingLbl = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.pnlPlayerArea = new System.Windows.Forms.Panel();
            this.pnlPlayArea = new System.Windows.Forms.Panel();
            this.pnlOpponent = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbDeckCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckCard)).BeginInit();
            this.SuspendLayout();
            // 
            // yourLbl
            // 
            this.yourLbl.AutoSize = true;
            this.yourLbl.Location = new System.Drawing.Point(505, 500);
            this.yourLbl.Name = "yourLbl";
            this.yourLbl.Size = new System.Drawing.Size(72, 17);
            this.yourLbl.TabIndex = 10;
            this.yourLbl.Text = "Your Area";
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(505, 260);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(88, 17);
            this.playingLbl.TabIndex = 9;
            this.playingLbl.Text = "Playing Area";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(513, 7);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(105, 17);
            this.lblOpponent.TabIndex = 8;
            this.lblOpponent.Text = "Opponent Area";
            // 
            // pnlPlayerArea
            // 
            this.pnlPlayerArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPlayerArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayerArea.Location = new System.Drawing.Point(508, 519);
            this.pnlPlayerArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayerArea.Name = "pnlPlayerArea";
            this.pnlPlayerArea.Size = new System.Drawing.Size(713, 202);
            this.pnlPlayerArea.TabIndex = 6;
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlPlayArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayArea.Location = new System.Drawing.Point(508, 279);
            this.pnlPlayArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(713, 202);
            this.pnlPlayArea.TabIndex = 7;
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlOpponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpponent.Location = new System.Drawing.Point(508, 32);
            this.pnlOpponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(713, 202);
            this.pnlOpponent.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNewGame.Location = new System.Drawing.Point(38, 519);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 28);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(38, 554);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDeckCard
            // 
            this.pbDeckCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDeckCard.Location = new System.Drawing.Point(38, 295);
            this.pbDeckCard.Margin = new System.Windows.Forms.Padding(4);
            this.pbDeckCard.Name = "pbDeckCard";
            this.pbDeckCard.Size = new System.Drawing.Size(99, 132);
            this.pbDeckCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeckCard.TabIndex = 13;
            this.pbDeckCard.TabStop = false;
            this.pbDeckCard.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1288, 729);
            this.Controls.Add(this.pbDeckCard);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.yourLbl);
            this.Controls.Add(this.playingLbl);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.pnlPlayerArea);
            this.Controls.Add(this.pnlPlayArea);
            this.Controls.Add(this.pnlOpponent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1306, 776);
            this.MinimumSize = new System.Drawing.Size(1306, 776);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourLbl;
        private System.Windows.Forms.Label playingLbl;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Panel pnlPlayerArea;
        private System.Windows.Forms.Panel pnlPlayArea;
        private System.Windows.Forms.Panel pnlOpponent;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbDeckCard;
    }
}

