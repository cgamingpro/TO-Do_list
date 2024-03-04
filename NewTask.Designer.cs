namespace ALLTOOOLS
{
    partial class NewTask
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
            this.titletx = new System.Windows.Forms.TextBox();
            this.datatx = new System.Windows.Forms.TextBox();
            this.EnterTItleLb = new System.Windows.Forms.Label();
            this.EnterDataLb = new System.Windows.Forms.Label();
            this.SaveBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titletx
            // 
            this.titletx.Location = new System.Drawing.Point(185, 49);
            this.titletx.Name = "titletx";
            this.titletx.Size = new System.Drawing.Size(265, 22);
            this.titletx.TabIndex = 0;
            // 
            // datatx
            // 
            this.datatx.Location = new System.Drawing.Point(185, 90);
            this.datatx.Multiline = true;
            this.datatx.Name = "datatx";
            this.datatx.Size = new System.Drawing.Size(495, 286);
            this.datatx.TabIndex = 1;
            // 
            // EnterTItleLb
            // 
            this.EnterTItleLb.AutoSize = true;
            this.EnterTItleLb.Location = new System.Drawing.Point(39, 54);
            this.EnterTItleLb.Name = "EnterTItleLb";
            this.EnterTItleLb.Size = new System.Drawing.Size(67, 16);
            this.EnterTItleLb.TabIndex = 2;
            this.EnterTItleLb.Text = "Enter Title";
            // 
            // EnterDataLb
            // 
            this.EnterDataLb.AutoSize = true;
            this.EnterDataLb.Location = new System.Drawing.Point(39, 110);
            this.EnterDataLb.Name = "EnterDataLb";
            this.EnterDataLb.Size = new System.Drawing.Size(70, 16);
            this.EnterDataLb.TabIndex = 3;
            this.EnterDataLb.Text = "Enter Data";
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(605, 395);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 23);
            this.SaveBt.TabIndex = 4;
            this.SaveBt.Text = "SaveBt";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.EnterDataLb);
            this.Controls.Add(this.EnterTItleLb);
            this.Controls.Add(this.datatx);
            this.Controls.Add(this.titletx);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.Load += new System.EventHandler(this.NewTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titletx;
        private System.Windows.Forms.TextBox datatx;
        private System.Windows.Forms.Label EnterTItleLb;
        private System.Windows.Forms.Label EnterDataLb;
        private System.Windows.Forms.Button SaveBt;
    }
}