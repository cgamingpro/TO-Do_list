namespace ALLTOOOLS
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddBt = new System.Windows.Forms.Button();
            this.headTb = new System.Windows.Forms.TextBox();
            this.TitleLb = new System.Windows.Forms.Label();
            this.datatb = new System.Windows.Forms.TextBox();
            this.LoadTaskBt = new System.Windows.Forms.Button();
            this.DontBt = new System.Windows.Forms.Button();
            this.TasksLB = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(60, 375);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(121, 23);
            this.AddBt.TabIndex = 2;
            this.AddBt.Text = "Add NEW Task";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // headTb
            // 
            this.headTb.Location = new System.Drawing.Point(255, 46);
            this.headTb.Name = "headTb";
            this.headTb.Size = new System.Drawing.Size(100, 22);
            this.headTb.TabIndex = 3;
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Location = new System.Drawing.Point(216, 52);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(33, 16);
            this.TitleLb.TabIndex = 4;
            this.TitleLb.Text = "Title";
            this.TitleLb.Click += new System.EventHandler(this.TitleLb_Click);
            // 
            // datatb
            // 
            this.datatb.Location = new System.Drawing.Point(255, 74);
            this.datatb.Multiline = true;
            this.datatb.Name = "datatb";
            this.datatb.Size = new System.Drawing.Size(355, 324);
            this.datatb.TabIndex = 5;
            // 
            // LoadTaskBt
            // 
            this.LoadTaskBt.Location = new System.Drawing.Point(60, 331);
            this.LoadTaskBt.Name = "LoadTaskBt";
            this.LoadTaskBt.Size = new System.Drawing.Size(121, 23);
            this.LoadTaskBt.TabIndex = 6;
            this.LoadTaskBt.Text = "Load Task";
            this.LoadTaskBt.UseVisualStyleBackColor = true;
            this.LoadTaskBt.Click += new System.EventHandler(this.LoadTaskBt_Click);
            // 
            // DontBt
            // 
            this.DontBt.Location = new System.Drawing.Point(634, 375);
            this.DontBt.Name = "DontBt";
            this.DontBt.Size = new System.Drawing.Size(121, 23);
            this.DontBt.TabIndex = 7;
            this.DontBt.Text = "Mark Done";
            this.DontBt.UseVisualStyleBackColor = true;
            this.DontBt.Click += new System.EventHandler(this.DontBt_Click);
            // 
            // TasksLB
            // 
            this.TasksLB.AutoSize = true;
            this.TasksLB.Location = new System.Drawing.Point(57, 25);
            this.TasksLB.Name = "TasksLB";
            this.TasksLB.Size = new System.Drawing.Size(45, 16);
            this.TasksLB.TabIndex = 8;
            this.TasksLB.Text = "Tasks";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(60, 283);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(121, 23);
            this.refresh.TabIndex = 9;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.TasksLB);
            this.Controls.Add(this.DontBt);
            this.Controls.Add(this.LoadTaskBt);
            this.Controls.Add(this.datatb);
            this.Controls.Add(this.TitleLb);
            this.Controls.Add(this.headTb);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "TO-DO List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.TextBox headTb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.TextBox datatb;
        private System.Windows.Forms.Button LoadTaskBt;
        private System.Windows.Forms.Button DontBt;
        private System.Windows.Forms.Label TasksLB;
        private System.Windows.Forms.Button refresh;
    }
}

