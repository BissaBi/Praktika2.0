namespace Praktika2._0
{
    partial class Form22
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(198, 129);
            button2.Name = "button2";
            button2.Size = new Size(76, 45);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(198, 67);
            button1.Name = "button1";
            button1.Size = new Size(76, 45);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 134);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 6;
            label2.Text = "Тёмная";
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 5;
            label1.Text = "Светлая";
            // 
            // Form22
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
            Name = "Form22";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тема";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}