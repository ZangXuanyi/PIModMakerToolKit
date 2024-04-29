namespace Calculator
{
    partial class FMainForm
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
            textBox_WealthyR = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_PovertyR = new TextBox();
            label3 = new Label();
            textBox_HotR = new TextBox();
            label4 = new Label();
            textBox_ColdR = new TextBox();
            label5 = new Label();
            textBox_UrbanR = new TextBox();
            label6 = new Label();
            textBox_RuralR = new TextBox();
            label7 = new Label();
            textBox_AridR = new TextBox();
            label8 = new Label();
            textBox_HumidR = new TextBox();
            label9 = new Label();
            textBox_Infectivity = new TextBox();
            label10 = new Label();
            textBox_Severity = new TextBox();
            label11 = new Label();
            textBox_Lethality = new TextBox();
            label12 = new Label();
            textBox_CureBase = new TextBox();
            label13 = new Label();
            textBox_ResInefficiency = new TextBox();
            label14 = new Label();
            textBox_Cost = new TextBox();
            button_CalculateCost = new Button();
            label17 = new Label();
            textBox_Mutation = new TextBox();
            richTextBox_CurrentPlace = new RichTextBox();
            label_CurrentPlace = new Label();
            button_UpdatePlaces = new Button();
            button_ChangePlaces = new Button();
            textBox_Hint = new TextBox();
            button_ShowDCalculator = new Button();
            button_ShowDMutation = new Button();
            SuspendLayout();
            // 
            // textBox_WealthyR
            // 
            textBox_WealthyR.Location = new Point(64, 6);
            textBox_WealthyR.Name = "textBox_WealthyR";
            textBox_WealthyR.Size = new Size(150, 30);
            textBox_WealthyR.TabIndex = 0;
            textBox_WealthyR.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 1;
            label1.Text = "富抗";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 3;
            label2.Text = "贫抗";
            // 
            // textBox_PovertyR
            // 
            textBox_PovertyR.Location = new Point(64, 42);
            textBox_PovertyR.Name = "textBox_PovertyR";
            textBox_PovertyR.Size = new Size(150, 30);
            textBox_PovertyR.TabIndex = 2;
            textBox_PovertyR.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 5;
            label3.Text = "热抗";
            // 
            // textBox_HotR
            // 
            textBox_HotR.Location = new Point(64, 78);
            textBox_HotR.Name = "textBox_HotR";
            textBox_HotR.Size = new Size(150, 30);
            textBox_HotR.TabIndex = 4;
            textBox_HotR.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 7;
            label4.Text = "寒抗";
            // 
            // textBox_ColdR
            // 
            textBox_ColdR.Location = new Point(64, 114);
            textBox_ColdR.Name = "textBox_ColdR";
            textBox_ColdR.Size = new Size(150, 30);
            textBox_ColdR.TabIndex = 6;
            textBox_ColdR.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 9;
            label5.Text = "城抗";
            // 
            // textBox_UrbanR
            // 
            textBox_UrbanR.Location = new Point(64, 150);
            textBox_UrbanR.Name = "textBox_UrbanR";
            textBox_UrbanR.Size = new Size(150, 30);
            textBox_UrbanR.TabIndex = 8;
            textBox_UrbanR.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 11;
            label6.Text = "农抗";
            // 
            // textBox_RuralR
            // 
            textBox_RuralR.Location = new Point(64, 186);
            textBox_RuralR.Name = "textBox_RuralR";
            textBox_RuralR.Size = new Size(150, 30);
            textBox_RuralR.TabIndex = 10;
            textBox_RuralR.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 225);
            label7.Name = "label7";
            label7.Size = new Size(46, 24);
            label7.TabIndex = 13;
            label7.Text = "干抗";
            // 
            // textBox_AridR
            // 
            textBox_AridR.Location = new Point(64, 222);
            textBox_AridR.Name = "textBox_AridR";
            textBox_AridR.Size = new Size(150, 30);
            textBox_AridR.TabIndex = 12;
            textBox_AridR.TextChanged += textBox7_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 261);
            label8.Name = "label8";
            label8.Size = new Size(46, 24);
            label8.TabIndex = 15;
            label8.Text = "潮抗";
            // 
            // textBox_HumidR
            // 
            textBox_HumidR.Location = new Point(64, 258);
            textBox_HumidR.Name = "textBox_HumidR";
            textBox_HumidR.Size = new Size(150, 30);
            textBox_HumidR.TabIndex = 14;
            textBox_HumidR.TextChanged += textBox8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 9);
            label9.Name = "label9";
            label9.Size = new Size(46, 24);
            label9.TabIndex = 17;
            label9.Text = "传染";
            // 
            // textBox_Infectivity
            // 
            textBox_Infectivity.Location = new Point(282, 6);
            textBox_Infectivity.Name = "textBox_Infectivity";
            textBox_Infectivity.Size = new Size(150, 30);
            textBox_Infectivity.TabIndex = 16;
            textBox_Infectivity.TextChanged += textBox9_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(230, 45);
            label10.Name = "label10";
            label10.Size = new Size(46, 24);
            label10.TabIndex = 19;
            label10.Text = "严重";
            // 
            // textBox_Severity
            // 
            textBox_Severity.Location = new Point(282, 42);
            textBox_Severity.Name = "textBox_Severity";
            textBox_Severity.Size = new Size(150, 30);
            textBox_Severity.TabIndex = 18;
            textBox_Severity.TextChanged += textBox10_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(230, 81);
            label11.Name = "label11";
            label11.Size = new Size(46, 24);
            label11.TabIndex = 21;
            label11.Text = "致死";
            // 
            // textBox_Lethality
            // 
            textBox_Lethality.Location = new Point(282, 78);
            textBox_Lethality.Name = "textBox_Lethality";
            textBox_Lethality.Size = new Size(150, 30);
            textBox_Lethality.TabIndex = 20;
            textBox_Lethality.TextChanged += textBox11_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(230, 117);
            label12.Name = "label12";
            label12.Size = new Size(46, 24);
            label12.TabIndex = 23;
            label12.Text = "需求";
            // 
            // textBox_CureBase
            // 
            textBox_CureBase.Location = new Point(282, 114);
            textBox_CureBase.Name = "textBox_CureBase";
            textBox_CureBase.Size = new Size(150, 30);
            textBox_CureBase.TabIndex = 22;
            textBox_CureBase.TextChanged += textBox12_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(230, 153);
            label13.Name = "label13";
            label13.Size = new Size(46, 24);
            label13.TabIndex = 25;
            label13.Text = "阻滞";
            // 
            // textBox_ResInefficiency
            // 
            textBox_ResInefficiency.Location = new Point(282, 150);
            textBox_ResInefficiency.Name = "textBox_ResInefficiency";
            textBox_ResInefficiency.Size = new Size(150, 30);
            textBox_ResInefficiency.TabIndex = 24;
            textBox_ResInefficiency.TextChanged += textBox13_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(230, 225);
            label14.Name = "label14";
            label14.Size = new Size(46, 24);
            label14.TabIndex = 27;
            label14.Text = "花费";
            // 
            // textBox_Cost
            // 
            textBox_Cost.Location = new Point(282, 222);
            textBox_Cost.Name = "textBox_Cost";
            textBox_Cost.Size = new Size(150, 30);
            textBox_Cost.TabIndex = 26;
            textBox_Cost.TextChanged += textBox14_TextChanged;
            // 
            // button_CalculateCost
            // 
            button_CalculateCost.Location = new Point(502, 12);
            button_CalculateCost.Name = "button_CalculateCost";
            button_CalculateCost.Size = new Size(158, 32);
            button_CalculateCost.TabIndex = 32;
            button_CalculateCost.Text = "计算花费";
            button_CalculateCost.UseVisualStyleBackColor = true;
            button_CalculateCost.Click += button1_Click_CalculateCost;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(230, 189);
            label17.Name = "label17";
            label17.Size = new Size(46, 24);
            label17.TabIndex = 35;
            label17.Text = "突变";
            // 
            // textBox_Mutation
            // 
            textBox_Mutation.Location = new Point(282, 186);
            textBox_Mutation.Name = "textBox_Mutation";
            textBox_Mutation.Size = new Size(150, 30);
            textBox_Mutation.TabIndex = 34;
            textBox_Mutation.TextChanged += textBox16_TextChanged;
            // 
            // richTextBox_CurrentPlace
            // 
            richTextBox_CurrentPlace.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_CurrentPlace.Location = new Point(12, 333);
            richTextBox_CurrentPlace.Name = "richTextBox_CurrentPlace";
            richTextBox_CurrentPlace.ReadOnly = true;
            richTextBox_CurrentPlace.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox_CurrentPlace.Size = new Size(420, 224);
            richTextBox_CurrentPlace.TabIndex = 37;
            richTextBox_CurrentPlace.Text = "";
            // 
            // label_CurrentPlace
            // 
            label_CurrentPlace.AutoSize = true;
            label_CurrentPlace.Location = new Point(12, 306);
            label_CurrentPlace.Name = "label_CurrentPlace";
            label_CurrentPlace.Size = new Size(141, 24);
            label_CurrentPlace.TabIndex = 38;
            label_CurrentPlace.Text = "当前位（1DNA)";
            // 
            // button_UpdatePlaces
            // 
            button_UpdatePlaces.Location = new Point(502, 50);
            button_UpdatePlaces.Name = "button_UpdatePlaces";
            button_UpdatePlaces.Size = new Size(158, 34);
            button_UpdatePlaces.TabIndex = 39;
            button_UpdatePlaces.Text = "更新显示的位";
            button_UpdatePlaces.UseVisualStyleBackColor = true;
            button_UpdatePlaces.Click += button_UpdatePlaces_Click;
            // 
            // button_ChangePlaces
            // 
            button_ChangePlaces.Location = new Point(502, 90);
            button_ChangePlaces.Name = "button_ChangePlaces";
            button_ChangePlaces.Size = new Size(158, 34);
            button_ChangePlaces.TabIndex = 40;
            button_ChangePlaces.Text = "自定义新的位";
            button_ChangePlaces.UseVisualStyleBackColor = true;
            button_ChangePlaces.Click += button_ChangePlaces_Click;
            // 
            // textBox_Hint
            // 
            textBox_Hint.Location = new Point(451, 333);
            textBox_Hint.Multiline = true;
            textBox_Hint.Name = "textBox_Hint";
            textBox_Hint.ReadOnly = true;
            textBox_Hint.Size = new Size(209, 137);
            textBox_Hint.TabIndex = 42;
            textBox_Hint.Text = "注：在执行操作前，请确定所有项目均填写完整，不得有空项（可以用0填充）；\r\n除花费外均支持小数。";
            // 
            // button_ShowDCalculator
            // 
            button_ShowDCalculator.Location = new Point(502, 130);
            button_ShowDCalculator.Name = "button_ShowDCalculator";
            button_ShowDCalculator.Size = new Size(158, 34);
            button_ShowDCalculator.TabIndex = 43;
            button_ShowDCalculator.Text = "位下度计算器";
            button_ShowDCalculator.UseVisualStyleBackColor = true;
            button_ShowDCalculator.Click += button_ShowDCalculator_Click;
            // 
            // button_ShowDMutation
            // 
            button_ShowDMutation.Location = new Point(502, 170);
            button_ShowDMutation.Name = "button_ShowDMutation";
            button_ShowDMutation.Size = new Size(158, 34);
            button_ShowDMutation.TabIndex = 44;
            button_ShowDMutation.Text = "突变计算器";
            button_ShowDMutation.UseVisualStyleBackColor = true;
            button_ShowDMutation.Click += button_ShowDMutation_Click;
            // 
            // FMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 569);
            Controls.Add(button_ShowDMutation);
            Controls.Add(button_ShowDCalculator);
            Controls.Add(textBox_Hint);
            Controls.Add(button_ChangePlaces);
            Controls.Add(button_UpdatePlaces);
            Controls.Add(label_CurrentPlace);
            Controls.Add(richTextBox_CurrentPlace);
            Controls.Add(label17);
            Controls.Add(textBox_Mutation);
            Controls.Add(button_CalculateCost);
            Controls.Add(label14);
            Controls.Add(textBox_Cost);
            Controls.Add(label13);
            Controls.Add(textBox_ResInefficiency);
            Controls.Add(label12);
            Controls.Add(textBox_CureBase);
            Controls.Add(label11);
            Controls.Add(textBox_Lethality);
            Controls.Add(label10);
            Controls.Add(textBox_Severity);
            Controls.Add(label9);
            Controls.Add(textBox_Infectivity);
            Controls.Add(label8);
            Controls.Add(textBox_HumidR);
            Controls.Add(label7);
            Controls.Add(textBox_AridR);
            Controls.Add(label6);
            Controls.Add(textBox_RuralR);
            Controls.Add(label5);
            Controls.Add(textBox_UrbanR);
            Controls.Add(label4);
            Controls.Add(textBox_ColdR);
            Controls.Add(label3);
            Controls.Add(textBox_HotR);
            Controls.Add(label2);
            Controls.Add(textBox_PovertyR);
            Controls.Add(label1);
            Controls.Add(textBox_WealthyR);
            Name = "FMainForm";
            Text = "PI制图实用工具";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_WealthyR;
        private Label label1;
        private Label label2;
        private TextBox textBox_PovertyR;
        private Label label3;
        private TextBox textBox_HotR;
        private Label label4;
        private TextBox textBox_ColdR;
        private Label label5;
        private TextBox textBox_UrbanR;
        private Label label6;
        private TextBox textBox_RuralR;
        private Label label7;
        private TextBox textBox_AridR;
        private Label label8;
        private TextBox textBox_HumidR;
        private Label label9;
        private TextBox textBox_Infectivity;
        private Label label10;
        private TextBox textBox_Severity;
        private Label label11;
        private TextBox textBox_Lethality;
        private Label label12;
        private TextBox textBox_CureBase;
        private Label label13;
        private TextBox textBox_ResInefficiency;
        private Label label14;
        private TextBox textBox_Cost;
        private Button button_CalculateCost;
        private Label label17;
        private TextBox textBox_Mutation;
        private RichTextBox richTextBox_CurrentPlace;
        private Label label_CurrentPlace;
        private Button button_UpdatePlaces;
        private Button button_ChangePlaces;
        private TextBox textBox_Hint;
        private Button button_ShowDCalculator;
        private Button button_ShowDMutation;
    }
}
