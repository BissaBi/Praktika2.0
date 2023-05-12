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
            button1.Location = new Point(37, 33);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.MaximumSize = new Size(240, 90);
            button1.MinimumSize = new Size(240, 90);
            button1.Name = "button1";
            button1.Size = new Size(240, 90);
            button1.TabIndex = 0;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(37, 144);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.MaximumSize = new Size(240, 90);
            button2.MinimumSize = new Size(240, 90);
            button2.Name = "button2";
            button2.Size = new Size(240, 90);
            button2.TabIndex = 1;
            button2.Text = "Темы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(37, 253);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.MaximumSize = new Size(240, 90);
            button3.MinimumSize = new Size(240, 90);
            button3.Name = "button3";
            button3.Size = new Size(240, 90);
            button3.TabIndex = 2;
            button3.Text = "Язык";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(37, 362);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.MaximumSize = new Size(240, 90);
            button4.MinimumSize = new Size(240, 90);
            button4.Name = "button4";
            button4.Size = new Size(240, 90);
            button4.TabIndex = 3;
            button4.Text = "Об авторах";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 483);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(330, 530);
            MinimumSize = new Size(330, 530);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}