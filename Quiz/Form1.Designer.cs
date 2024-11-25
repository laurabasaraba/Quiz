namespace Quiz
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(40, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "La culoarea rosie a semaforului:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "opresti";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "accelerezi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 84);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(115, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "treci cu prudenta";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(386, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "La semnalul galben intermitent:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "reduci viteza";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "opresti";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 94);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(112, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "respecti regulile ";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(318, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Evalueaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}
