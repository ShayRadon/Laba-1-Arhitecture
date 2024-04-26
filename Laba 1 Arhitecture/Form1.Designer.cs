namespace Laba_1_Arhitecture
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Process = new System.Windows.Forms.Button();
            this.TB_IpStart = new System.Windows.Forms.TextBox();
            this.TB_Mac_Adress = new System.Windows.Forms.TextBox();
            this.TB_Broadcast_Adress = new System.Windows.Forms.TextBox();
            this.TB_Adress = new System.Windows.Forms.TextBox();
            this.TB_IpEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Mask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(24, 56);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(112, 48);
            this.Process.TabIndex = 0;
            this.Process.Text = "Рассчитать параметры";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // TB_IpStart
            // 
            this.TB_IpStart.Location = new System.Drawing.Point(352, 64);
            this.TB_IpStart.Name = "TB_IpStart";
            this.TB_IpStart.Size = new System.Drawing.Size(272, 20);
            this.TB_IpStart.TabIndex = 1;
            this.TB_IpStart.Text = "192.168.0.1";
            // 
            // TB_Mac_Adress
            // 
            this.TB_Mac_Adress.Location = new System.Drawing.Point(352, 224);
            this.TB_Mac_Adress.Name = "TB_Mac_Adress";
            this.TB_Mac_Adress.Size = new System.Drawing.Size(272, 20);
            this.TB_Mac_Adress.TabIndex = 2;
            // 
            // TB_Broadcast_Adress
            // 
            this.TB_Broadcast_Adress.Location = new System.Drawing.Point(352, 192);
            this.TB_Broadcast_Adress.Name = "TB_Broadcast_Adress";
            this.TB_Broadcast_Adress.Size = new System.Drawing.Size(272, 20);
            this.TB_Broadcast_Adress.TabIndex = 3;
            // 
            // TB_Adress
            // 
            this.TB_Adress.Location = new System.Drawing.Point(352, 160);
            this.TB_Adress.Name = "TB_Adress";
            this.TB_Adress.Size = new System.Drawing.Size(272, 20);
            this.TB_Adress.TabIndex = 4;
            // 
            // TB_IpEnd
            // 
            this.TB_IpEnd.Location = new System.Drawing.Point(352, 104);
            this.TB_IpEnd.Name = "TB_IpEnd";
            this.TB_IpEnd.Size = new System.Drawing.Size(272, 20);
            this.TB_IpEnd.TabIndex = 5;
            this.TB_IpEnd.Text = "192.168.100.10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Начальный Ip-адресс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Конечный Ip-адресс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(144, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адресс сети";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(144, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broadcast Адресс";
            // 
            // TB_Mask
            // 
            this.TB_Mask.Location = new System.Drawing.Point(352, 256);
            this.TB_Mask.Name = "TB_Mask";
            this.TB_Mask.Size = new System.Drawing.Size(272, 20);
            this.TB_Mask.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(144, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "MAC-адрес узла сети";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(144, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Маска сети";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 327);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Mask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_IpEnd);
            this.Controls.Add(this.TB_Adress);
            this.Controls.Add(this.TB_Broadcast_Adress);
            this.Controls.Add(this.TB_Mac_Adress);
            this.Controls.Add(this.TB_IpStart);
            this.Controls.Add(this.Process);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.TextBox TB_IpStart;
        private System.Windows.Forms.TextBox TB_Mac_Adress;
        private System.Windows.Forms.TextBox TB_Broadcast_Adress;
        private System.Windows.Forms.TextBox TB_Adress;
        private System.Windows.Forms.TextBox TB_IpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Mask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

