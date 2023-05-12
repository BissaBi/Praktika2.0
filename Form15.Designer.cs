namespace Praktika2._0
{
    partial class Form15
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 439);
            button1.Name = "button1";
            button1.Size = new Size(290, 35);
            button1.TabIndex = 6;
            button1.Text = "Скачать";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 215);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(267, 51);
            label3.TabIndex = 9;
            label3.Text = "Введиту функцию в строку ввода и нажмите кнопку \"Решение\"";
            // 
            // label2
            // 
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(275, 50);
            label2.TabIndex = 8;
            label2.Text = "F'( ) = - в этом поле выводится производная функции";
            // 
            // label1
            // 
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(279, 43);
            label1.TabIndex = 7;
            label1.Text = "F( ) = - в это поле вводится исходная функция ";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 483);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(330, 530);
            MinimumSize = new Size(330, 530);
            Name = "Form15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка анг/свет";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}