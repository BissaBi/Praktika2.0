namespace Praktika2._0
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(255, 371);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(255, 316);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(255, 261);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(255, 427);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(312, 483);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            MaximumSize = new Size(330, 530);
            MinimumSize = new Size(330, 530);
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Об авторах ру/тем ";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
    }
}