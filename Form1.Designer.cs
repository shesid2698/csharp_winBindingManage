namespace wintest3
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_marry = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_member = new System.Windows.Forms.DateTimePicker();
            this.lblshow = new System.Windows.Forms.Label();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(94, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "編號";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(153, 54);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 25);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(153, 118);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 25);
            this.textBox_phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(94, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "電話";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(542, 59);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 25);
            this.textBox_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(483, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // textBox_sex
            // 
            this.textBox_sex.Location = new System.Drawing.Point(542, 124);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.Size = new System.Drawing.Size(100, 25);
            this.textBox_sex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(483, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "性別";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(94, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "入會日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(483, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "婚姻狀態";
            // 
            // checkBox_marry
            // 
            this.checkBox_marry.AutoSize = true;
            this.checkBox_marry.Location = new System.Drawing.Point(578, 195);
            this.checkBox_marry.Name = "checkBox_marry";
            this.checkBox_marry.Size = new System.Drawing.Size(18, 17);
            this.checkBox_marry.TabIndex = 10;
            this.checkBox_marry.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_member
            // 
            this.dateTimePicker_member.Location = new System.Drawing.Point(189, 186);
            this.dateTimePicker_member.Name = "dateTimePicker_member";
            this.dateTimePicker_member.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_member.TabIndex = 11;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshow.Location = new System.Drawing.Point(94, 272);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(67, 20);
            this.lblshow.TabIndex = 12;
            this.lblshow.Text = "lblshow";
            // 
            // button_last
            // 
            this.button_last.Location = new System.Drawing.Point(542, 326);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(117, 35);
            this.button_last.TabIndex = 15;
            this.button_last.Text = "最末筆";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(391, 326);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(117, 35);
            this.button_next.TabIndex = 16;
            this.button_next.Text = "下一筆";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(230, 326);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(117, 35);
            this.button_prev.TabIndex = 17;
            this.button_prev.Text = "上一筆";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_first
            // 
            this.button_first.Location = new System.Drawing.Point(83, 326);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(117, 35);
            this.button_first.TabIndex = 18;
            this.button_first.Text = "第一筆";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_first);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.dateTimePicker_member);
            this.Controls.Add(this.checkBox_marry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_marry;
        private System.Windows.Forms.DateTimePicker dateTimePicker_member;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_first;
    }
}

