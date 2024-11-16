namespace Calculator
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
            result = new TextBox();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b0 = new Button();
            beq = new Button();
            bplus = new Button();
            bminus = new Button();
            bputa = new Button();
            bpodeljenjo = new Button();
            bclear = new Button();
            bdot = new Button();
            prvi = new TextBox();
            drugi = new TextBox();
            operacija = new TextBox();
            SuspendLayout();
            // 
            // result
            // 
            result.Font = new Font("Segoe UI", 35F);
            result.Location = new Point(12, 32);
            result.Name = "result";
            result.ReadOnly = true;
            result.RightToLeft = RightToLeft.Yes;
            result.Size = new Size(300, 70);
            result.TabIndex = 0;
            result.Text = "0";
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 15F);
            b1.Location = new Point(29, 348);
            b1.Name = "b1";
            b1.Size = new Size(36, 36);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 15F);
            b2.Location = new Point(91, 348);
            b2.Name = "b2";
            b2.Size = new Size(36, 36);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 15F);
            b3.Location = new Point(162, 348);
            b3.Name = "b3";
            b3.Size = new Size(36, 36);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 15F);
            b4.Location = new Point(29, 284);
            b4.Name = "b4";
            b4.Size = new Size(36, 36);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 15F);
            b5.Location = new Point(91, 284);
            b5.Name = "b5";
            b5.Size = new Size(36, 36);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 15F);
            b6.Location = new Point(162, 284);
            b6.Name = "b6";
            b6.Size = new Size(36, 36);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 15F);
            b7.Location = new Point(29, 219);
            b7.Name = "b7";
            b7.Size = new Size(36, 36);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 15F);
            b8.Location = new Point(91, 219);
            b8.Name = "b8";
            b8.Size = new Size(36, 36);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 15F);
            b9.Location = new Point(162, 219);
            b9.Name = "b9";
            b9.Size = new Size(36, 36);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 15F);
            b0.Location = new Point(91, 398);
            b0.Name = "b0";
            b0.Size = new Size(36, 36);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // beq
            // 
            beq.Font = new Font("Segoe UI", 15F);
            beq.Location = new Point(222, 398);
            beq.Name = "beq";
            beq.Size = new Size(36, 36);
            beq.TabIndex = 11;
            beq.Text = "=";
            beq.UseVisualStyleBackColor = true;
            beq.Click += beq_Click;
            // 
            // bplus
            // 
            bplus.Font = new Font("Segoe UI", 15F);
            bplus.Location = new Point(222, 348);
            bplus.Name = "bplus";
            bplus.Size = new Size(36, 36);
            bplus.TabIndex = 12;
            bplus.Text = "+";
            bplus.UseVisualStyleBackColor = true;
            bplus.Click += bplus_Click;
            // 
            // bminus
            // 
            bminus.Font = new Font("Segoe UI", 15F);
            bminus.Location = new Point(222, 284);
            bminus.Name = "bminus";
            bminus.Size = new Size(36, 36);
            bminus.TabIndex = 13;
            bminus.Text = "-";
            bminus.UseVisualStyleBackColor = true;
            bminus.Click += bminus_Click;
            // 
            // bputa
            // 
            bputa.Font = new Font("Segoe UI", 15F);
            bputa.Location = new Point(222, 219);
            bputa.Name = "bputa";
            bputa.Size = new Size(36, 36);
            bputa.TabIndex = 14;
            bputa.Text = "*";
            bputa.UseVisualStyleBackColor = true;
            bputa.Click += bputa_Click;
            // 
            // bpodeljenjo
            // 
            bpodeljenjo.Font = new Font("Segoe UI", 15F);
            bpodeljenjo.Location = new Point(91, 162);
            bpodeljenjo.Name = "bpodeljenjo";
            bpodeljenjo.Size = new Size(36, 36);
            bpodeljenjo.TabIndex = 15;
            bpodeljenjo.Text = "/";
            bpodeljenjo.UseVisualStyleBackColor = true;
            bpodeljenjo.Click += bpodeljenjo_Click;
            // 
            // bclear
            // 
            bclear.Font = new Font("Segoe UI", 15F);
            bclear.Location = new Point(162, 162);
            bclear.Name = "bclear";
            bclear.Size = new Size(96, 36);
            bclear.TabIndex = 16;
            bclear.Text = "clear";
            bclear.UseVisualStyleBackColor = true;
            bclear.Click += bclear_Click;
            // 
            // bdot
            // 
            bdot.Font = new Font("Segoe UI", 15F);
            bdot.Location = new Point(162, 398);
            bdot.Name = "bdot";
            bdot.Size = new Size(36, 36);
            bdot.TabIndex = 17;
            bdot.Text = ".";
            bdot.UseVisualStyleBackColor = true;
            bdot.Click += bdot_Click;
            // 
            // prvi
            // 
            prvi.Location = new Point(12, 122);
            prvi.Name = "prvi";
            prvi.ReadOnly = true;
            prvi.Size = new Size(100, 23);
            prvi.TabIndex = 18;
            prvi.TextAlign = HorizontalAlignment.Center;
            // 
            // drugi
            // 
            drugi.Location = new Point(212, 122);
            drugi.Name = "drugi";
            drugi.ReadOnly = true;
            drugi.Size = new Size(100, 23);
            drugi.TabIndex = 19;
            drugi.TextAlign = HorizontalAlignment.Center;
            // 
            // operacija
            // 
            operacija.Location = new Point(140, 122);
            operacija.Name = "operacija";
            operacija.ReadOnly = true;
            operacija.Size = new Size(40, 23);
            operacija.TabIndex = 20;
            operacija.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 446);
            Controls.Add(operacija);
            Controls.Add(drugi);
            Controls.Add(prvi);
            Controls.Add(bdot);
            Controls.Add(bclear);
            Controls.Add(bpodeljenjo);
            Controls.Add(bputa);
            Controls.Add(bminus);
            Controls.Add(bplus);
            Controls.Add(beq);
            Controls.Add(b0);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(result);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(340, 485);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b0;
        private Button beq;
        private Button bplus;
        private Button bminus;
        private Button bputa;
        private Button bpodeljenjo;
        private Button bclear;
        private Button bdot;
        private TextBox prvi;
        private TextBox drugi;
        private TextBox operacija;
    }
}
