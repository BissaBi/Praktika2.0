namespace Praktika2._0
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 61);
            button1.Name = "button1";
            button1.Size = new Size(185, 65);
            button1.TabIndex = 0;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(30, 162);
            button2.Name = "button2";
            button2.Size = new Size(185, 65);
            button2.TabIndex = 1;
            button2.Text = "Темы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(30, 255);
            button3.Name = "button3";
            button3.Size = new Size(185, 65);
            button3.TabIndex = 2;
            button3.Text = "Об авторах";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(196, 12);
            button4.Name = "button4";
            button4.Size = new Size(31, 33);
            button4.TabIndex = 3;
            button4.Text = "Х";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 361);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}