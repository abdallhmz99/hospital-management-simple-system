namespace small_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.r_num = new System.Windows.Forms.TextBox();
            this.doctor = new System.Windows.Forms.TextBox();
            this.illness = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.search_id = new System.Windows.Forms.Button();
            this.search_name = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "the illness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "room num.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "doctor";
            // 
            // r_num
            // 
            this.r_num.Location = new System.Drawing.Point(202, 25);
            this.r_num.Name = "r_num";
            this.r_num.Size = new System.Drawing.Size(55, 20);
            this.r_num.TabIndex = 5;
            // 
            // doctor
            // 
            this.doctor.Location = new System.Drawing.Point(350, 25);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(66, 20);
            this.doctor.TabIndex = 6;
            // 
            // illness
            // 
            this.illness.Location = new System.Drawing.Point(275, 25);
            this.illness.Name = "illness";
            this.illness.Size = new System.Drawing.Size(59, 20);
            this.illness.TabIndex = 7;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(422, 25);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(131, 20);
            this.address.TabIndex = 8;
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(50, 25);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(133, 20);
            this.p_name.TabIndex = 9;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(5, 51);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 10;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(5, 25);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(33, 20);
            this.id.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(294, 51);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "save to file";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search_id
            // 
            this.search_id.Location = new System.Drawing.Point(477, 51);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(75, 23);
            this.search_id.TabIndex = 14;
            this.search_id.Text = "search by id";
            this.search_id.UseVisualStyleBackColor = true;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // search_name
            // 
            this.search_name.Location = new System.Drawing.Point(372, 51);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(99, 23);
            this.search_name.TabIndex = 15;
            this.search_name.Text = "search by name";
            this.search_name.UseVisualStyleBackColor = true;
            this.search_name.Click += new System.EventHandler(this.search_name_Click);
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(86, 51);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(97, 23);
            this.clear_all.TabIndex = 16;
            this.clear_all.Text = "clear all list";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(189, 51);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(99, 23);
            this.remove.TabIndex = 17;
            this.remove.Text = "remove by id";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(5, 80);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 18;
            this.display.Text = "disblay all";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(86, 80);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 23);
            this.exit.TabIndex = 19;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(5, 109);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(586, 149);
            this.list.TabIndex = 20;
            this.list.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.list);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.display);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.search_name);
            this.Controls.Add(this.search_id);
            this.Controls.Add(this.save);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.illness);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.r_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "patient  information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox r_num;
        private System.Windows.Forms.TextBox doctor;
        private System.Windows.Forms.TextBox illness;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button search_id;
        private System.Windows.Forms.Button search_name;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox list;
    }
}

