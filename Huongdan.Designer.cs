namespace baigiuaky
{
    partial class Huongdan
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
            this.gamemau1 = new baigiuaky.gamemau();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamemau1
            // 
            this.gamemau1.BackColor = System.Drawing.Color.Transparent;
            this.gamemau1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamemau1.Location = new System.Drawing.Point(215, 137);
            this.gamemau1.Name = "gamemau1";
            this.gamemau1.Size = new System.Drawing.Size(410, 602);
            this.gamemau1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhấp chuột vào các ô hình gần ô trống để di chuyển vào vị trí\r\nô trống. Nếu xếp g" +
    "iống như hình mẫu thì chiến thắng";
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamemau1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Huongdan";
            this.Text = "Huongdan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gamemau gamemau1;
        private System.Windows.Forms.Label label1;
    }
}
