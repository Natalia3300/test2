namespace Game
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
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnChest = new System.Windows.Forms.Button();
            this.btnCabinet = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(738, 345);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // btnChest
            // 
            this.btnChest.Location = new System.Drawing.Point(26, 385);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(98, 53);
            this.btnChest.TabIndex = 1;
            this.btnChest.Text = "Осмотреть сундук";
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnCabinet
            // 
            this.btnCabinet.Location = new System.Drawing.Point(141, 396);
            this.btnCabinet.Name = "btnCabinet";
            this.btnCabinet.Size = new System.Drawing.Size(114, 42);
            this.btnCabinet.TabIndex = 2;
            this.btnCabinet.Text = "Осмотреть комод";
            this.btnCabinet.UseVisualStyleBackColor = true;
            this.btnCabinet.Click += new System.EventHandler(this.btnCabinet_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Location = new System.Drawing.Point(282, 396);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(119, 42);
            this.btnTrash.TabIndex = 3;
            this.btnTrash.Text = "Заглянуть под брезент";
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(445, 407);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(122, 20);
            this.lblEnergy.TabIndex = 4;
            this.lblEnergy.Text = "Форарик: 3 ед.";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(574, 406);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(124, 20);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Находки: 0 руб.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.btnTrash);
            this.Controls.Add(this.btnCabinet);
            this.Controls.Add(this.btnChest);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnCabinet;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblMoney;
    }
}

