
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
            this.SuspendLayout();
            // 
            // yourLbl
            // 
            this.yourLbl.AutoSize = true;
            this.yourLbl.Location = new System.Drawing.Point(379, 406);
            this.yourLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yourLbl.Name = "yourLbl";
            this.yourLbl.Size = new System.Drawing.Size(54, 13);
            this.yourLbl.TabIndex = 10;
            this.yourLbl.Text = "Your Area";
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(379, 211);
            this.playingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(66, 13);
            this.playingLbl.TabIndex = 9;
            this.playingLbl.Text = "Playing Area";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(385, 6);
            this.lblOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(79, 13);
            this.lblOpponent.TabIndex = 8;
            this.lblOpponent.Text = "Opponent Area";
            // 
            // pnlPlayerArea
            // 
            this.pnlPlayerArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayerArea.Location = new System.Drawing.Point(381, 422);
            this.pnlPlayerArea.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlayerArea.Name = "pnlPlayerArea";
            this.pnlPlayerArea.Size = new System.Drawing.Size(536, 165);
            this.pnlPlayerArea.TabIndex = 6;
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPlayArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayArea.Location = new System.Drawing.Point(381, 227);
            this.pnlPlayArea.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(536, 165);
            this.pnlPlayArea.TabIndex = 7;
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlOpponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpponent.Location = new System.Drawing.Point(381, 26);
            this.pnlOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(536, 165);
            this.pnlOpponent.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 600);
            this.Controls.Add(this.yourLbl);
            this.Controls.Add(this.playingLbl);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.pnlPlayerArea);
            this.Controls.Add(this.pnlPlayArea);
            this.Controls.Add(this.pnlOpponent);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(984, 639);
            this.MinimumSize = new System.Drawing.Size(984, 639);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
    }
}

