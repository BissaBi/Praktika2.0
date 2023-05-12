namespace Praktika2._0
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 72);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 0;
            label1.Text = "Светлая";
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 134);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 1;
            label2.Text = "Тёмная";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(189, 64);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 3;
            button1.Text = "Галочка";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 120);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 4;
            button2.Text = "Включить";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 483);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(330, 530);
            MinimumSize = new Size(330, 530);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Темы";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}