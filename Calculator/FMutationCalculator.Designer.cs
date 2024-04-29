namespace Calculator
{
    partial class FMutationCalculator
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
            textBox_PredictedMutation = new TextBox();
            textBox_ncConstant = new TextBox();
            label2 = new Label();
            checkBox_IsVirus = new CheckBox();
            button_Calculate = new Button();
            textBox_output = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "预期突变值";
            label1.Click += label1_Click;
            // 
            // textBox_PredictedMutation
            // 
            textBox_PredictedMutation.Location = new Point(118, 9);
            textBox_PredictedMutation.Name = "textBox_PredictedMutation";
            textBox_PredictedMutation.Size = new Size(150, 30);
            textBox_PredictedMutation.TabIndex = 1;
            textBox_PredictedMutation.TextChanged += textBox1_TextChanged;
            // 
            // textBox_ncConstant
            // 
            textBox_ncConstant.Location = new Point(118, 45);
            textBox_ncConstant.Name = "textBox_ncConstant";
            textBox_ncConstant.Size = new Size(150, 30);
            textBox_ncConstant.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 2;
            label2.Text = "nc常数";
            // 
            // checkBox_IsVirus
            // 
            checkBox_IsVirus.AutoSize = true;
            checkBox_IsVirus.Location = new Point(12, 89);
            checkBox_IsVirus.Name = "checkBox_IsVirus";
            checkBox_IsVirus.Size = new Size(90, 28);
            checkBox_IsVirus.TabIndex = 5;
            checkBox_IsVirus.Text = "是病毒";
            checkBox_IsVirus.UseVisualStyleBackColor = true;
            checkBox_IsVirus.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button_Calculate
            // 
            button_Calculate.Location = new Point(118, 89);
            button_Calculate.Name = "button_Calculate";
            button_Calculate.Size = new Size(150, 34);
            button_Calculate.TabIndex = 6;
            button_Calculate.Text = "计算";
            button_Calculate.UseVisualStyleBackColor = true;
            button_Calculate.Click += button_Calculate_Click;
            // 
            // textBox_output
            // 
            textBox_output.Location = new Point(12, 158);
            textBox_output.Multiline = true;
            textBox_output.Name = "textBox_output";
            textBox_output.ReadOnly = true;
            textBox_output.Size = new Size(256, 280);
            textBox_output.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 131);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 8;
            label3.Text = "计算结果";
            // 
            // FMutationCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(label3);
            Controls.Add(textBox_output);
            Controls.Add(button_Calculate);
            Controls.Add(checkBox_IsVirus);
            Controls.Add(textBox_ncConstant);
            Controls.Add(label2);
            Controls.Add(textBox_PredictedMutation);
            Controls.Add(label1);
            Name = "FMutationCalculator";
            Text = "突变计算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_PredictedMutation;
        private TextBox textBox_ncConstant;
        private Label label2;
        private Label label3;
        private CheckBox checkBox_IsVirus;
        private Button button_Calculate;
        private TextBox textBox_output;
    }
}