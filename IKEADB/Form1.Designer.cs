namespace IKEADB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSeriesName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listRoom
            // 
            this.listRoom.FormattingEnabled = true;
            this.listRoom.Location = new System.Drawing.Point(60, 111);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(120, 95);
            this.listRoom.TabIndex = 1;
            this.listRoom.SelectedIndexChanged += new System.EventHandler(this.listRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Series";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listSeriesName
            // 
            this.listSeriesName.FormattingEnabled = true;
            this.listSeriesName.Location = new System.Drawing.Point(328, 111);
            this.listSeriesName.Name = "listSeriesName";
            this.listSeriesName.Size = new System.Drawing.Size(120, 95);
            this.listSeriesName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listSeriesName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSeriesName;
    }
}

