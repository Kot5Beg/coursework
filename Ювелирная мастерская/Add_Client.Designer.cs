namespace Ювелирная_мастерская
{
    partial class Add_Client
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
            this.Save_Client = new System.Windows.Forms.Button();
            this.Surname_Client = new System.Windows.Forms.TextBox();
            this.Name_Client = new System.Windows.Forms.TextBox();
            this.Patronymic_Client = new System.Windows.Forms.TextBox();
            this.Address_Client = new System.Windows.Forms.TextBox();
            this.Phone_Client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_Client
            // 
            this.Save_Client.Location = new System.Drawing.Point(130, 404);
            this.Save_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_Client.Name = "Save_Client";
            this.Save_Client.Size = new System.Drawing.Size(112, 37);
            this.Save_Client.TabIndex = 0;
            this.Save_Client.Text = "Добавить";
            this.Save_Client.UseVisualStyleBackColor = true;
            this.Save_Client.Click += new System.EventHandler(this.Save_Client_Click);
            // 
            // Surname_Client
            // 
            this.Surname_Client.Location = new System.Drawing.Point(154, 113);
            this.Surname_Client.Name = "Surname_Client";
            this.Surname_Client.Size = new System.Drawing.Size(255, 29);
            this.Surname_Client.TabIndex = 1;
            // 
            // Name_Client
            // 
            this.Name_Client.Location = new System.Drawing.Point(154, 168);
            this.Name_Client.Name = "Name_Client";
            this.Name_Client.Size = new System.Drawing.Size(255, 29);
            this.Name_Client.TabIndex = 2;
            // 
            // Patronymic_Client
            // 
            this.Patronymic_Client.Location = new System.Drawing.Point(154, 226);
            this.Patronymic_Client.Name = "Patronymic_Client";
            this.Patronymic_Client.Size = new System.Drawing.Size(255, 29);
            this.Patronymic_Client.TabIndex = 3;
            // 
            // Address_Client
            // 
            this.Address_Client.Location = new System.Drawing.Point(154, 284);
            this.Address_Client.Name = "Address_Client";
            this.Address_Client.Size = new System.Drawing.Size(255, 29);
            this.Address_Client.TabIndex = 4;
            // 
            // Phone_Client
            // 
            this.Phone_Client.Location = new System.Drawing.Point(154, 344);
            this.Phone_Client.Name = "Phone_Client";
            this.Phone_Client.Size = new System.Drawing.Size(255, 29);
            this.Phone_Client.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчетство";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите в поля данные о клиенте";
            // 
            // Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone_Client);
            this.Controls.Add(this.Address_Client);
            this.Controls.Add(this.Patronymic_Client);
            this.Controls.Add(this.Name_Client);
            this.Controls.Add(this.Surname_Client);
            this.Controls.Add(this.Save_Client);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Client;
        private System.Windows.Forms.TextBox Surname_Client;
        private System.Windows.Forms.TextBox Name_Client;
        private System.Windows.Forms.TextBox Patronymic_Client;
        private System.Windows.Forms.TextBox Address_Client;
        private System.Windows.Forms.TextBox Phone_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}