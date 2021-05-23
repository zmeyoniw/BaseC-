
namespace Ex2
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.RightOrNot = new System.Windows.Forms.Label();
            this.UserAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.count = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(383, 139);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(243, 110);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // RightOrNot
            // 
            this.RightOrNot.AutoSize = true;
            this.RightOrNot.Location = new System.Drawing.Point(132, 139);
            this.RightOrNot.Name = "RightOrNot";
            this.RightOrNot.Size = new System.Drawing.Size(35, 13);
            this.RightOrNot.TabIndex = 1;
            this.RightOrNot.Text = "label1";
            this.RightOrNot.Click += new System.EventHandler(this.RightOrNot_Click);
            // 
            // UserAnswer
            // 
            this.UserAnswer.Location = new System.Drawing.Point(135, 228);
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.Size = new System.Drawing.Size(207, 20);
            this.UserAnswer.TabIndex = 2;
            this.UserAnswer.TextChanged += new System.EventHandler(this.UserAnswer_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.игратьToolStripMenuItem.Text = "Играть";
            this.игратьToolStripMenuItem.Click += new System.EventHandler(this.игратьToolStripMenuItem_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(135, 313);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(35, 13);
            this.count.TabIndex = 4;
            this.count.Text = "label1";
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.UserAnswer);
            this.Controls.Add(this.RightOrNot);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label RightOrNot;
        private System.Windows.Forms.TextBox UserAnswer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.Label count;
    }
}

