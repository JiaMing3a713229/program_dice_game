namespace Assignment_byJia
{
    partial class lavel_1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lavel_1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodbar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.result_textbox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output_1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bloodbar2 = new System.Windows.Forms.ProgressBar();
            this.result_textbox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output_2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.game_num_text = new System.Windows.Forms.TextBox();
            this.status1 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.buffer2_pic = new System.Windows.Forms.PictureBox();
            this.buffer1_pic = new System.Windows.Forms.PictureBox();
            this.result1_label = new System.Windows.Forms.Label();
            this.result2_label = new System.Windows.Forms.Label();
            this.reStart_but = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buffer2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffer1_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.result1_label);
            this.panel1.Controls.Add(this.buffer1_pic);
            this.panel1.Controls.Add(this.status1);
            this.panel1.Controls.Add(this.bloodbar1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.result_textbox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.output_1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 295);
            this.panel1.TabIndex = 0;
            // 
            // bloodbar1
            // 
            this.bloodbar1.BackColor = System.Drawing.Color.Tomato;
            this.bloodbar1.ForeColor = System.Drawing.Color.Chartreuse;
            this.bloodbar1.Location = new System.Drawing.Point(3, 46);
            this.bloodbar1.Maximum = 200;
            this.bloodbar1.Name = "bloodbar1";
            this.bloodbar1.Size = new System.Drawing.Size(180, 21);
            this.bloodbar1.TabIndex = 6;
            this.bloodbar1.Value = 200;
            this.bloodbar1.Click += new System.EventHandler(this.Bloodbar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "生命值";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // result_textbox1
            // 
            this.result_textbox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textbox1.Location = new System.Drawing.Point(509, 228);
            this.result_textbox1.Name = "result_textbox1";
            this.result_textbox1.Size = new System.Drawing.Size(184, 64);
            this.result_textbox1.TabIndex = 4;
            this.result_textbox1.Text = "";
            this.result_textbox1.TextChanged += new System.EventHandler(this.Result_textbox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "分數";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // output_1
            // 
            this.output_1.BackColor = System.Drawing.Color.Honeydew;
            this.output_1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output_1.Location = new System.Drawing.Point(604, 185);
            this.output_1.Name = "output_1";
            this.output_1.Size = new System.Drawing.Size(89, 43);
            this.output_1.TabIndex = 2;
            this.output_1.TextChanged += new System.EventHandler(this.Output_1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "玩家一";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.result2_label);
            this.panel2.Controls.Add(this.buffer2_pic);
            this.panel2.Controls.Add(this.status2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bloodbar2);
            this.panel2.Controls.Add(this.result_textbox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.output_2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 298);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "生命值";
            // 
            // bloodbar2
            // 
            this.bloodbar2.BackColor = System.Drawing.Color.Tomato;
            this.bloodbar2.ForeColor = System.Drawing.Color.Crimson;
            this.bloodbar2.Location = new System.Drawing.Point(3, 48);
            this.bloodbar2.Maximum = 200;
            this.bloodbar2.Name = "bloodbar2";
            this.bloodbar2.Size = new System.Drawing.Size(180, 21);
            this.bloodbar2.TabIndex = 7;
            this.bloodbar2.Value = 200;
            // 
            // result_textbox2
            // 
            this.result_textbox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textbox2.Location = new System.Drawing.Point(509, 237);
            this.result_textbox2.Name = "result_textbox2";
            this.result_textbox2.Size = new System.Drawing.Size(181, 58);
            this.result_textbox2.TabIndex = 5;
            this.result_textbox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(502, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "分數";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // output_2
            // 
            this.output_2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output_2.Location = new System.Drawing.Point(604, 193);
            this.output_2.Name = "output_2";
            this.output_2.Size = new System.Drawing.Size(86, 43);
            this.output_2.TabIndex = 3;
            this.output_2.TextChanged += new System.EventHandler(this.Output_2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "玩家二";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "開始投擲";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.reStart_but);
            this.panel3.Controls.Add(this.game_num_text);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(0, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 66);
            this.panel3.TabIndex = 2;
            // 
            // game_num_text
            // 
            this.game_num_text.BackColor = System.Drawing.Color.LimeGreen;
            this.game_num_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.game_num_text.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_num_text.Location = new System.Drawing.Point(0, 0);
            this.game_num_text.Multiline = true;
            this.game_num_text.Name = "game_num_text";
            this.game_num_text.Size = new System.Drawing.Size(164, 66);
            this.game_num_text.TabIndex = 3;
            this.game_num_text.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.BackColor = System.Drawing.Color.Transparent;
            this.status1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.Location = new System.Drawing.Point(189, 46);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(0, 24);
            this.status1.TabIndex = 7;
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.BackColor = System.Drawing.Color.Transparent;
            this.status2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2.Location = new System.Drawing.Point(189, 48);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(0, 24);
            this.status2.TabIndex = 9;
            // 
            // buffer2_pic
            // 
            this.buffer2_pic.BackColor = System.Drawing.Color.Transparent;
            this.buffer2_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buffer2_pic.BackgroundImage")));
            this.buffer2_pic.Location = new System.Drawing.Point(176, 3);
            this.buffer2_pic.Name = "buffer2_pic";
            this.buffer2_pic.Size = new System.Drawing.Size(35, 35);
            this.buffer2_pic.TabIndex = 10;
            this.buffer2_pic.TabStop = false;
            this.buffer2_pic.Visible = false;
            this.buffer2_pic.Click += new System.EventHandler(this.Buffer2_pic_Click);
            // 
            // buffer1_pic
            // 
            this.buffer1_pic.BackColor = System.Drawing.Color.Transparent;
            this.buffer1_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buffer1_pic.BackgroundImage")));
            this.buffer1_pic.Location = new System.Drawing.Point(179, 6);
            this.buffer1_pic.Name = "buffer1_pic";
            this.buffer1_pic.Size = new System.Drawing.Size(35, 35);
            this.buffer1_pic.TabIndex = 11;
            this.buffer1_pic.TabStop = false;
            this.buffer1_pic.Visible = false;
            this.buffer1_pic.Click += new System.EventHandler(this.Buffer1_pic_Click);
            // 
            // result1_label
            // 
            this.result1_label.AutoSize = true;
            this.result1_label.BackColor = System.Drawing.Color.Transparent;
            this.result1_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result1_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1_label.ForeColor = System.Drawing.Color.Red;
            this.result1_label.Location = new System.Drawing.Point(241, 118);
            this.result1_label.Name = "result1_label";
            this.result1_label.Size = new System.Drawing.Size(0, 80);
            this.result1_label.TabIndex = 12;
            // 
            // result2_label
            // 
            this.result2_label.AutoSize = true;
            this.result2_label.BackColor = System.Drawing.Color.Transparent;
            this.result2_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result2_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2_label.ForeColor = System.Drawing.Color.Red;
            this.result2_label.Location = new System.Drawing.Point(241, 104);
            this.result2_label.Name = "result2_label";
            this.result2_label.Size = new System.Drawing.Size(0, 80);
            this.result2_label.TabIndex = 13;
            // 
            // reStart_but
            // 
            this.reStart_but.BackColor = System.Drawing.Color.NavajoWhite;
            this.reStart_but.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reStart_but.Location = new System.Drawing.Point(509, 0);
            this.reStart_but.Name = "reStart_but";
            this.reStart_but.Size = new System.Drawing.Size(187, 66);
            this.reStart_but.TabIndex = 4;
            this.reStart_but.Text = "重新開始";
            this.reStart_but.UseVisualStyleBackColor = false;
            this.reStart_but.Click += new System.EventHandler(this.ReStart_but_Click);
            // 
            // lavel_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "lavel_1";
            this.Size = new System.Drawing.Size(696, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buffer2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffer1_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox output_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox result_textbox1;
        private System.Windows.Forms.RichTextBox result_textbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar bloodbar1;
        private System.Windows.Forms.ProgressBar bloodbar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox game_num_text;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.PictureBox buffer1_pic;
        private System.Windows.Forms.PictureBox buffer2_pic;
        private System.Windows.Forms.Label result1_label;
        private System.Windows.Forms.Label result2_label;
        private System.Windows.Forms.Button reStart_but;
    }
}
