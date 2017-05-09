namespace n_layer_course.UI
{
    partial class Form2
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
            this.ID = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.branchid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(655, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "کد درس";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(655, 291);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(75, 13);
            this.hour.TabIndex = 1;
            this.hour.Text = "ساعات کلاسی";
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.Location = new System.Drawing.Point(655, 222);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(48, 13);
            this.teachername.TabIndex = 2;
            this.teachername.Text = "نام استاد";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(655, 161);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 13);
            this.name.TabIndex = 3;
            this.name.Text = "نام درس";
            // 
            // branchid
            // 
            this.branchid.AutoSize = true;
            this.branchid.Location = new System.Drawing.Point(655, 96);
            this.branchid.Name = "branchid";
            this.branchid.Size = new System.Drawing.Size(45, 13);
            this.branchid.TabIndex = 4;
            this.branchid.Text = "کد رشته";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(468, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(468, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(468, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(468, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 9;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(658, 392);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(84, 45);
            this.insert.TabIndex = 10;
            this.insert.Text = "اضافه";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(514, 392);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 45);
            this.delete.TabIndex = 12;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.branchid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.ID);
            this.Name = "Form2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label teachername;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label branchid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
    }
}