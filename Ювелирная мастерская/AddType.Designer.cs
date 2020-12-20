namespace Ювелирная_мастерская
{
    partial class AddType
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
            this.AddTypeBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTypeBut
            // 
            this.AddTypeBut.Location = new System.Drawing.Point(121, 134);
            this.AddTypeBut.Name = "AddTypeBut";
            this.AddTypeBut.Size = new System.Drawing.Size(75, 23);
            this.AddTypeBut.TabIndex = 0;
            this.AddTypeBut.Text = "Добавить";
            this.AddTypeBut.UseVisualStyleBackColor = true;
            this.AddTypeBut.Click += new System.EventHandler(this.AddTypeBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите данные о типе изделий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // ApText
            // 
            this.ApText.Location = new System.Drawing.Point(96, 90);
            this.ApText.Name = "ApText";
            this.ApText.Size = new System.Drawing.Size(221, 20);
            this.ApText.TabIndex = 3;
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 187);
            this.Controls.Add(this.ApText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTypeBut);
            this.Name = "AddType";
            this.Text = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTypeBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApText;
    }
}