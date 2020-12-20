namespace Ювелирная_мастерская
{
    partial class UpdQual
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
            this.label3 = new System.Windows.Forms.Label();
            this.AddButQual = new System.Windows.Forms.Button();
            this.PText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите данные о квалификации";
            // 
            // AddButQual
            // 
            this.AddButQual.Location = new System.Drawing.Point(327, 337);
            this.AddButQual.Name = "AddButQual";
            this.AddButQual.Size = new System.Drawing.Size(119, 44);
            this.AddButQual.TabIndex = 10;
            this.AddButQual.Text = "Сохранить";
            this.AddButQual.UseVisualStyleBackColor = true;
            this.AddButQual.Click += new System.EventHandler(this.AddButQual_Click);
            // 
            // PText
            // 
            this.PText.Location = new System.Drawing.Point(279, 178);
            this.PText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PText.Multiline = true;
            this.PText.Name = "PText";
            this.PText.Size = new System.Drawing.Size(367, 151);
            this.PText.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Полномочия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование";
            // 
            // AText
            // 
            this.AText.Location = new System.Drawing.Point(279, 126);
            this.AText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(367, 20);
            this.AText.TabIndex = 6;
            // 
            // UpdQual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddButQual);
            this.Controls.Add(this.PText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AText);
            this.Name = "UpdQual";
            this.Text = "UpdQual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButQual;
        private System.Windows.Forms.TextBox PText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AText;
    }
}