namespace PoolClub
{
    partial class ctrlPool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.lblCountUpTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblplayer = new System.Windows.Forms.Label();
            this.poolTimer = new System.Windows.Forms.Timer(this.components);
            this.gbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.lblCountUpTime);
            this.gbTable.Controls.Add(this.pictureBox1);
            this.gbTable.Controls.Add(this.btnStartStop);
            this.gbTable.Controls.Add(this.btnEnd);
            this.gbTable.Controls.Add(this.lblplayer);
            this.gbTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTable.Location = new System.Drawing.Point(3, 15);
            this.gbTable.Name = "groupBox1";
            this.gbTable.Size = new System.Drawing.Size(415, 231);
            this.gbTable.TabIndex = 0;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Table";
            this.gbTable.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCountUpTime
            // 
            this.lblCountUpTime.AutoSize = true;
            this.lblCountUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUpTime.Location = new System.Drawing.Point(112, 192);
            this.lblCountUpTime.Name = "lblCountUpTime";
            this.lblCountUpTime.Size = new System.Drawing.Size(49, 20);
            this.lblCountUpTime.TabIndex = 5;
            this.lblCountUpTime.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoolClub.Properties.Resources.pngtree_top_13_pool_table_wallpapers_to_get_your_ball_rolling_picture_image_3465840;
            this.pictureBox1.Location = new System.Drawing.Point(6, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStartStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartStop.Location = new System.Drawing.Point(302, 76);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(81, 36);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEnd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnd.Location = new System.Drawing.Point(302, 136);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(81, 36);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer.Location = new System.Drawing.Point(184, 16);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(58, 20);
            this.lblplayer.TabIndex = 0;
            this.lblplayer.Text = "Player";
            // 
            // poolTimer
            // 
            this.poolTimer.Interval = 1000;
            this.poolTimer.Tick += new System.EventHandler(this.poolTimer_Tick);
            // 
            // ctrlPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.gbTable);
            this.Name = "ctrlPool";
            this.Size = new System.Drawing.Size(421, 261);
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblCountUpTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer poolTimer;
    }
}
