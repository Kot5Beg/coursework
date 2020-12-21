namespace Ювелирная_мастерская
{
    partial class UpdProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.UpdProductBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeProd = new System.Windows.Forms.TextBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.Appelation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Измените данные об изделии";
            // 
            // UpdProductBut
            // 
            this.UpdProductBut.Location = new System.Drawing.Point(166, 134);
            this.UpdProductBut.Name = "UpdProductBut";
            this.UpdProductBut.Size = new System.Drawing.Size(75, 23);
            this.UpdProductBut.TabIndex = 14;
            this.UpdProductBut.Text = "Сохранить";
            this.UpdProductBut.UseVisualStyleBackColor = true;
            this.UpdProductBut.Click += new System.EventHandler(this.UpdProductBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Время изготовления (в днях)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Наименование";
            // 
            // TimeProd
            // 
            this.TimeProd.Location = new System.Drawing.Point(199, 98);
            this.TimeProd.Name = "TimeProd";
            this.TimeProd.Size = new System.Drawing.Size(197, 20);
            this.TimeProd.TabIndex = 10;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(199, 71);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(197, 21);
            this.TypeCombo.TabIndex = 9;
            // 
            // Appelation
            // 
            this.Appelation.Location = new System.Drawing.Point(199, 44);
            this.Appelation.Name = "Appelation";
            this.Appelation.Size = new System.Drawing.Size(197, 20);
            this.Appelation.TabIndex = 8;
            // 
            // UpdProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdProductBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeProd);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.Appelation);
            this.Name = "UpdProduct";
            this.Text = "Изменение продукта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdProductBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeProd;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.TextBox Appelation;
    }
}