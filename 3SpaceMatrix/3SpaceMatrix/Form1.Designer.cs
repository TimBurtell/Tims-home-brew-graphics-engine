namespace _3SpaceMatrix
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
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.VP1 = new System.Windows.Forms.TextBox();
            this.VP2 = new System.Windows.Forms.TextBox();
            this.VP3 = new System.Windows.Forms.TextBox();
            this.VP4 = new System.Windows.Forms.TextBox();
            this.VPl4 = new System.Windows.Forms.TextBox();
            this.VPl3 = new System.Windows.Forms.TextBox();
            this.VPl2 = new System.Windows.Forms.TextBox();
            this.VPl1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.O3 = new System.Windows.Forms.TextBox();
            this.O2 = new System.Windows.Forms.TextBox();
            this.O1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VW4 = new System.Windows.Forms.TextBox();
            this.VW3 = new System.Windows.Forms.TextBox();
            this.VW2 = new System.Windows.Forms.TextBox();
            this.VW1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DW4 = new System.Windows.Forms.TextBox();
            this.DW3 = new System.Windows.Forms.TextBox();
            this.DW2 = new System.Windows.Forms.TextBox();
            this.DW1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(900, 450);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(933, 344);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(170, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Update";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(930, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Viewpoint";
            // 
            // VP1
            // 
            this.VP1.Location = new System.Drawing.Point(933, 46);
            this.VP1.Name = "VP1";
            this.VP1.Size = new System.Drawing.Size(38, 20);
            this.VP1.TabIndex = 11;
            // 
            // VP2
            // 
            this.VP2.Location = new System.Drawing.Point(977, 46);
            this.VP2.Name = "VP2";
            this.VP2.Size = new System.Drawing.Size(38, 20);
            this.VP2.TabIndex = 12;
            // 
            // VP3
            // 
            this.VP3.Location = new System.Drawing.Point(1021, 46);
            this.VP3.Name = "VP3";
            this.VP3.Size = new System.Drawing.Size(38, 20);
            this.VP3.TabIndex = 13;
            // 
            // VP4
            // 
            this.VP4.Location = new System.Drawing.Point(1065, 46);
            this.VP4.Name = "VP4";
            this.VP4.Size = new System.Drawing.Size(38, 20);
            this.VP4.TabIndex = 14;
            // 
            // VPl4
            // 
            this.VPl4.Location = new System.Drawing.Point(1065, 93);
            this.VPl4.Name = "VPl4";
            this.VPl4.Size = new System.Drawing.Size(38, 20);
            this.VPl4.TabIndex = 19;
            // 
            // VPl3
            // 
            this.VPl3.Location = new System.Drawing.Point(1021, 93);
            this.VPl3.Name = "VPl3";
            this.VPl3.Size = new System.Drawing.Size(38, 20);
            this.VPl3.TabIndex = 18;
            // 
            // VPl2
            // 
            this.VPl2.Location = new System.Drawing.Point(977, 93);
            this.VPl2.Name = "VPl2";
            this.VPl2.Size = new System.Drawing.Size(38, 20);
            this.VPl2.TabIndex = 17;
            // 
            // VPl1
            // 
            this.VPl1.Location = new System.Drawing.Point(933, 93);
            this.VPl1.Name = "VPl1";
            this.VPl1.Size = new System.Drawing.Size(38, 20);
            this.VPl1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(930, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Viewplane";
            // 
            // O3
            // 
            this.O3.Location = new System.Drawing.Point(1021, 138);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(38, 20);
            this.O3.TabIndex = 23;
            // 
            // O2
            // 
            this.O2.Location = new System.Drawing.Point(977, 138);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(38, 20);
            this.O2.TabIndex = 22;
            // 
            // O1
            // 
            this.O1.Location = new System.Drawing.Point(933, 138);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(38, 20);
            this.O1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(930, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Origin";
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(1021, 181);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(38, 20);
            this.X3.TabIndex = 28;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(977, 181);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(38, 20);
            this.X2.TabIndex = 27;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(933, 181);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(38, 20);
            this.X1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "X-Axis";
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(1021, 226);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(38, 20);
            this.Y3.TabIndex = 33;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(977, 226);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(38, 20);
            this.Y2.TabIndex = 32;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(933, 226);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(38, 20);
            this.Y1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(930, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Y-Axis";
            // 
            // VW4
            // 
            this.VW4.Location = new System.Drawing.Point(1065, 269);
            this.VW4.Name = "VW4";
            this.VW4.Size = new System.Drawing.Size(38, 20);
            this.VW4.TabIndex = 39;
            // 
            // VW3
            // 
            this.VW3.Location = new System.Drawing.Point(1021, 269);
            this.VW3.Name = "VW3";
            this.VW3.Size = new System.Drawing.Size(38, 20);
            this.VW3.TabIndex = 38;
            // 
            // VW2
            // 
            this.VW2.Location = new System.Drawing.Point(977, 269);
            this.VW2.Name = "VW2";
            this.VW2.Size = new System.Drawing.Size(38, 20);
            this.VW2.TabIndex = 37;
            // 
            // VW1
            // 
            this.VW1.Location = new System.Drawing.Point(933, 269);
            this.VW1.Name = "VW1";
            this.VW1.Size = new System.Drawing.Size(38, 20);
            this.VW1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "View Window";
            // 
            // DW4
            // 
            this.DW4.Location = new System.Drawing.Point(1065, 318);
            this.DW4.Name = "DW4";
            this.DW4.Size = new System.Drawing.Size(38, 20);
            this.DW4.TabIndex = 44;
            // 
            // DW3
            // 
            this.DW3.Location = new System.Drawing.Point(1021, 318);
            this.DW3.Name = "DW3";
            this.DW3.Size = new System.Drawing.Size(38, 20);
            this.DW3.TabIndex = 43;
            // 
            // DW2
            // 
            this.DW2.Location = new System.Drawing.Point(977, 318);
            this.DW2.Name = "DW2";
            this.DW2.Size = new System.Drawing.Size(38, 20);
            this.DW2.TabIndex = 42;
            // 
            // DW1
            // 
            this.DW1.Location = new System.Drawing.Point(933, 318);
            this.DW1.Name = "DW1";
            this.DW1.Size = new System.Drawing.Size(38, 20);
            this.DW1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(930, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Device Window";
            // 
            // t_label
            // 
            this.t_label.AutoSize = true;
            this.t_label.Location = new System.Drawing.Point(967, 411);
            this.t_label.Name = "t_label";
            this.t_label.Size = new System.Drawing.Size(35, 13);
            this.t_label.TabIndex = 45;
            this.t_label.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 503);
            this.Controls.Add(this.t_label);
            this.Controls.Add(this.DW4);
            this.Controls.Add(this.DW3);
            this.Controls.Add(this.DW2);
            this.Controls.Add(this.DW1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VW4);
            this.Controls.Add(this.VW3);
            this.Controls.Add(this.VW2);
            this.Controls.Add(this.VW1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.O3);
            this.Controls.Add(this.O2);
            this.Controls.Add(this.O1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VPl4);
            this.Controls.Add(this.VPl3);
            this.Controls.Add(this.VPl2);
            this.Controls.Add(this.VPl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VP4);
            this.Controls.Add(this.VP3);
            this.Controls.Add(this.VP2);
            this.Controls.Add(this.VP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VP1;
        private System.Windows.Forms.TextBox VP2;
        private System.Windows.Forms.TextBox VP3;
        private System.Windows.Forms.TextBox VP4;
        private System.Windows.Forms.TextBox VPl4;
        private System.Windows.Forms.TextBox VPl3;
        private System.Windows.Forms.TextBox VPl2;
        private System.Windows.Forms.TextBox VPl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox O3;
        private System.Windows.Forms.TextBox O2;
        private System.Windows.Forms.TextBox O1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VW4;
        private System.Windows.Forms.TextBox VW3;
        private System.Windows.Forms.TextBox VW2;
        private System.Windows.Forms.TextBox VW1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DW4;
        private System.Windows.Forms.TextBox DW3;
        private System.Windows.Forms.TextBox DW2;
        private System.Windows.Forms.TextBox DW1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label t_label;
    }
}

