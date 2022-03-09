namespace Task_1_conversion_tool
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Label();
            this.FirstOption = new System.Windows.Forms.Label();
            this.SecondOption = new System.Windows.Forms.Label();
            this.feettom = new System.Windows.Forms.Button();
            this.yardstom = new System.Windows.Forms.Button();
            this.milestokm = new System.Windows.Forms.Button();
            this.inchestocm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(206, 57);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(83, 30);
            this.result.TabIndex = 2;
            this.result.Text = "0";
            this.result.Visible = false;
            this.result.WordWrap = false;
            this.result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(176, 60);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(24, 25);
            this.equals.TabIndex = 3;
            this.equals.Text = "=";
            this.equals.Visible = false;
            // 
            // FirstOption
            // 
            this.FirstOption.AutoSize = true;
            this.FirstOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstOption.Location = new System.Drawing.Point(100, 60);
            this.FirstOption.Name = "FirstOption";
            this.FirstOption.Size = new System.Drawing.Size(70, 25);
            this.FirstOption.TabIndex = 4;
            this.FirstOption.Text = "Inches";
            this.FirstOption.Visible = false;
            // 
            // SecondOption
            // 
            this.SecondOption.AutoSize = true;
            this.SecondOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondOption.Location = new System.Drawing.Point(295, 60);
            this.SecondOption.Name = "SecondOption";
            this.SecondOption.Size = new System.Drawing.Size(117, 25);
            this.SecondOption.TabIndex = 5;
            this.SecondOption.Text = "Centimeters";
            this.SecondOption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SecondOption.Visible = false;
            // 
            // feettom
            // 
            this.feettom.Location = new System.Drawing.Point(6, 54);
            this.feettom.Name = "feettom";
            this.feettom.Size = new System.Drawing.Size(232, 23);
            this.feettom.TabIndex = 6;
            this.feettom.Text = "Feet to Metres";
            this.feettom.UseVisualStyleBackColor = true;
            this.feettom.Click += new System.EventHandler(this.feettom_Click);
            this.feettom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // yardstom
            // 
            this.yardstom.Location = new System.Drawing.Point(6, 83);
            this.yardstom.Name = "yardstom";
            this.yardstom.Size = new System.Drawing.Size(232, 23);
            this.yardstom.TabIndex = 7;
            this.yardstom.Text = "Yards to Metres";
            this.yardstom.UseVisualStyleBackColor = true;
            this.yardstom.Click += new System.EventHandler(this.yardstom_Click);
            this.yardstom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // milestokm
            // 
            this.milestokm.Location = new System.Drawing.Point(6, 112);
            this.milestokm.Name = "milestokm";
            this.milestokm.Size = new System.Drawing.Size(232, 23);
            this.milestokm.TabIndex = 8;
            this.milestokm.Text = "Miles to Kilometres";
            this.milestokm.UseVisualStyleBackColor = true;
            this.milestokm.Click += new System.EventHandler(this.button2_Click);
            this.milestokm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // inchestocm
            // 
            this.inchestocm.Location = new System.Drawing.Point(18, 164);
            this.inchestocm.Name = "inchestocm";
            this.inchestocm.Size = new System.Drawing.Size(232, 23);
            this.inchestocm.TabIndex = 9;
            this.inchestocm.Text = "Inches to Centimetres";
            this.inchestocm.UseVisualStyleBackColor = true;
            this.inchestocm.Click += new System.EventHandler(this.inchestocm_Click);
            this.inchestocm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feettom);
            this.groupBox1.Controls.Add(this.yardstom);
            this.groupBox1.Controls.Add(this.milestokm);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of conversion";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(301, 253);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 32);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            this.exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the value to be converted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Made by Blake McCullough";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(264, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 77);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard Shortcuts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 52);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alt + I == Inches to Centimetres\r\nAlt + F == Feet to Metres\r\nAlt + Y == Yards to " +
    "Metres\r\nAlt + M == Miles to Kilometres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(436, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.inchestocm);
            this.Controls.Add(this.SecondOption);
            this.Controls.Add(this.FirstOption);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Distance Convertor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForExit);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label FirstOption;
        private System.Windows.Forms.Label SecondOption;
        private System.Windows.Forms.Button feettom;
        private System.Windows.Forms.Button yardstom;
        private System.Windows.Forms.Button milestokm;
        private System.Windows.Forms.Button inchestocm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

