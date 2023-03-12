namespace Calculadoraora
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
            txt_result = new TextBox();
            btn_9 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_3 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_6 = new Button();
            btn_0 = new Button();
            btn_sum = new Button();
            btn_sub = new Button();
            btn_result = new Button();
            lbl_store = new Label();
            SuspendLayout();
            // 
            // txt_result
            // 
            txt_result.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_result.Location = new Point(11, 39);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(334, 43);
            txt_result.TabIndex = 0;
            txt_result.Text = "0";
            txt_result.TextAlign = HorizontalAlignment.Right;
            txt_result.TextChanged += txt_result_TextChanged;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_9.Location = new Point(194, 88);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(56, 37);
            btn_9.TabIndex = 12;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_7.Location = new Point(70, 88);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(56, 37);
            btn_7.TabIndex = 13;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_8.Location = new Point(132, 88);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(56, 37);
            btn_8.TabIndex = 14;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_2.Location = new Point(132, 174);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(56, 37);
            btn_2.TabIndex = 17;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1.Location = new Point(70, 174);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(56, 37);
            btn_1.TabIndex = 16;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_3.Location = new Point(194, 174);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(56, 37);
            btn_3.TabIndex = 15;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_5.Location = new Point(132, 131);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(56, 37);
            btn_5.TabIndex = 20;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_4.Location = new Point(70, 131);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(56, 37);
            btn_4.TabIndex = 19;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_6.Location = new Point(194, 131);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(56, 37);
            btn_6.TabIndex = 18;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_0.Location = new Point(132, 217);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(56, 37);
            btn_0.TabIndex = 21;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_sum
            // 
            btn_sum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sum.Location = new Point(256, 131);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(56, 37);
            btn_sum.TabIndex = 24;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_sub
            // 
            btn_sub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sub.Location = new Point(256, 88);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(56, 37);
            btn_sub.TabIndex = 23;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_result
            // 
            btn_result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_result.Location = new Point(256, 174);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(56, 37);
            btn_result.TabIndex = 22;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = true;
            btn_result.Click += btn_result_Click;
            // 
            // lbl_store
            // 
            lbl_store.AutoSize = true;
            lbl_store.Location = new Point(14, 43);
            lbl_store.Name = "lbl_store";
            lbl_store.Size = new Size(0, 15);
            lbl_store.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 346);
            Controls.Add(lbl_store);
            Controls.Add(btn_sum);
            Controls.Add(btn_sub);
            Controls.Add(btn_result);
            Controls.Add(btn_0);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_6);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_3);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_9);
            Controls.Add(txt_result);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_result;
        private Button btn_9;
        private Button btn_7;
        private Button btn_8;
        private Button btn_2;
        private Button btn_1;
        private Button btn_3;
        private Button btn_5;
        private Button btn_4;
        private Button btn_6;
        private Button btn_0;
        private Button btn_sum;
        private Button btn_sub;
        private Button btn_result;
        private Label lbl_store;
    }
}