namespace Praktika2._0
{
    partial class Form23
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
            button2.Location = new Point(208, 138);
            button2.Name = "button2";
            button2.Size = new Size(80, 40);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(208, 69);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("PT Bold Arch", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 5;
            label2.Text = "English";
            // 
            // label1
            // 
            label1.Font = new Font("PT Bold Arch", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
            label1.TabIndex = 4;
            label1.Text = "Русский";
            // 
            // Form23
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
            Name = "Form23";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Язык  анг/тем";
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