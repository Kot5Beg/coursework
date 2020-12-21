namespace Ювелирная_мастерская
{
    partial class UpdTP
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
            this.ApText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdTypeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApText
            // 
            this.ApText.Location = new System.Drawing.Point(131, 57);
            this.ApText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApText.Name = "ApText";
            this.ApText.Size = new System.Drawing.Size(330, 29);
            this.ApText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите данные о типе изделий";
            // 
            // UpdTypeBut
            // 
            this.UpdTypeBut.Location = new System.Drawing.Point(163, 107);
            this.UpdTypeBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdTypeBut.Name = "UpdTypeBut";
            this.UpdTypeBut.Size = new System.Drawing.Size(112, 37);
            this.UpdTypeBut.TabIndex = 4;
            this.UpdTypeBut.Text = "Сохранить";
            this.UpdTypeBut.UseVisualStyleBackColor = true;
            this.UpdTypeBut.Click += new System.EventHandler(this.UpdTypeBut_Click);
            // 
            // UpdTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 158);
            this.Controls.Add(this.ApText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdTypeBut);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о типе изделий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdTypeBut;
    }
}