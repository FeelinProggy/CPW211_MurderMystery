namespace CPW211_MurderMystery
{
    partial class PartyCreatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 62);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "Add Players";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(118, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(121, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Choose a theme:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 91);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Remove Players";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(48, 200);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(180, 19);
            radioButton1.TabIndex = 6;
            radioButton1.Text = "Do you want a scripted story?";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(48, 225);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 19);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "Or to improvise?";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 247);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 8;
            label2.Text = "(Character profiles only.)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 174);
            label3.Name = "label3";
            label3.Size = new Size(160, 17);
            label3.TabIndex = 9;
            label3.Text = "How do you want to play?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 282);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 10;
            label4.Text = "Should the murderer know they're it?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(70, 300);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(42, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Yes";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(119, 300);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(41, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "No";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 354);
            button3.Name = "button3";
            button3.Size = new Size(119, 23);
            button3.TabIndex = 13;
            button3.Text = "Print Instructions";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(151, 354);
            button4.Name = "button4";
            button4.Size = new Size(112, 23);
            button4.TabIndex = 14;
            button4.Text = "Save Game Info";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 421);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Murder Mystery Party Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button3;
        private Button button4;
    }
}
