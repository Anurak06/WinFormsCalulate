namespace WinFormsCalulate
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
            btnCircleArea = new Button();
            label1 = new Label();
            txtRedius = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnTriangleArea = new Button();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            btnHexagonArea = new Button();
            txtPolygonWidth = new TextBox();
            lblResult = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.NavajoWhite;
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRedius);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(241, 44);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(143, 29);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "รัศมี";
            // 
            // txtRedius
            // 
            txtRedius.Location = new Point(76, 46);
            txtRedius.Name = "txtRedius";
            txtRedius.Size = new Size(125, 27);
            txtRedius.TabIndex = 2;
            txtRedius.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Chartreuse;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Location = new Point(23, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 78);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "ความยาวฐาน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 36);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "ความสูง";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(241, 54);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(143, 29);
            btnTriangleArea.TabIndex = 4;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(100, 75);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 4;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(100, 36);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightCyan;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Controls.Add(txtPolygonWidth);
            groupBox3.Location = new Point(23, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(431, 125);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 46);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "ความยาวฐาน";
            label5.Click += label5_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(241, 42);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(162, 29);
            btnHexagonArea.TabIndex = 4;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtPolygonWidth
            // 
            txtPolygonWidth.Location = new Point(100, 44);
            txtPolygonWidth.Name = "txtPolygonWidth";
            txtPolygonWidth.Size = new Size(125, 27);
            txtPolygonWidth.TabIndex = 5;
            txtPolygonWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Thistle;
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(491, 94);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(258, 174);
            lblResult.TabIndex = 2;
            lblResult.Text = "....";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 65);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 7;
            label6.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRedius;
        private GroupBox groupBox2;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private GroupBox groupBox3;
        private TextBox txtPolygonWidth;
        private Button btnCircleArea;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private Label lblResult;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
