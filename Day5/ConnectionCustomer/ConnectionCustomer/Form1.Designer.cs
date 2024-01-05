namespace ConnectionCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.Label();
            this.GENDER = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.getCustomerFirst = new System.Windows.Forms.Button();
            this.getCustomerPre = new System.Windows.Forms.Button();
            this.getCustomerNext = new System.Windows.Forms.Button();
            this.getCustomerLast = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustome = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER CRUD";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(216, 47);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(216, 77);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(38, 13);
            this.NAME.TabIndex = 2;
            this.NAME.Text = "NAME";
            // 
            // ADDRESS
            // 
            this.ADDRESS.AutoSize = true;
            this.ADDRESS.Location = new System.Drawing.Point(216, 107);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(59, 13);
            this.ADDRESS.TabIndex = 3;
            this.ADDRESS.Text = "ADDRESS";
            // 
            // PHONE
            // 
            this.PHONE.AutoSize = true;
            this.PHONE.Location = new System.Drawing.Point(216, 133);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(45, 13);
            this.PHONE.TabIndex = 4;
            this.PHONE.Text = "PHONE";
            // 
            // GENDER
            // 
            this.GENDER.AutoSize = true;
            this.GENDER.Location = new System.Drawing.Point(216, 188);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(53, 13);
            this.GENDER.TabIndex = 5;
            this.GENDER.Text = "GENDER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(281, 100);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(272, 20);
            this.textBox5.TabIndex = 10;
            // 
            // getCustomerFirst
            // 
            this.getCustomerFirst.Location = new System.Drawing.Point(164, 230);
            this.getCustomerFirst.Name = "getCustomerFirst";
            this.getCustomerFirst.Size = new System.Drawing.Size(96, 47);
            this.getCustomerFirst.TabIndex = 11;
            this.getCustomerFirst.Text = "<<";
            this.getCustomerFirst.UseVisualStyleBackColor = true;
            this.getCustomerFirst.Click += new System.EventHandler(this.getCustomerFirst_Click);
            // 
            // getCustomerPre
            // 
            this.getCustomerPre.Location = new System.Drawing.Point(278, 230);
            this.getCustomerPre.Name = "getCustomerPre";
            this.getCustomerPre.Size = new System.Drawing.Size(96, 47);
            this.getCustomerPre.TabIndex = 12;
            this.getCustomerPre.Text = "<";
            this.getCustomerPre.UseVisualStyleBackColor = true;
            this.getCustomerPre.Click += new System.EventHandler(this.getCustomerPre_Click);
            // 
            // getCustomerNext
            // 
            this.getCustomerNext.Location = new System.Drawing.Point(406, 230);
            this.getCustomerNext.Name = "getCustomerNext";
            this.getCustomerNext.Size = new System.Drawing.Size(96, 47);
            this.getCustomerNext.TabIndex = 13;
            this.getCustomerNext.Text = ">";
            this.getCustomerNext.UseVisualStyleBackColor = true;
            this.getCustomerNext.Click += new System.EventHandler(this.getCustomerNext_Click);
            // 
            // getCustomerLast
            // 
            this.getCustomerLast.Location = new System.Drawing.Point(534, 230);
            this.getCustomerLast.Name = "getCustomerLast";
            this.getCustomerLast.Size = new System.Drawing.Size(96, 47);
            this.getCustomerLast.TabIndex = 14;
            this.getCustomerLast.Text = ">>";
            this.getCustomerLast.UseVisualStyleBackColor = true;
            this.getCustomerLast.Click += new System.EventHandler(this.getCustomerLast_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(534, 300);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(96, 47);
            this.deleteCustomer.TabIndex = 18;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(406, 300);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(96, 47);
            this.updateCustomer.TabIndex = 17;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustome
            // 
            this.addCustome.Location = new System.Drawing.Point(278, 300);
            this.addCustome.Name = "addCustome";
            this.addCustome.Size = new System.Drawing.Size(96, 47);
            this.addCustome.TabIndex = 16;
            this.addCustome.Text = "Add";
            this.addCustome.UseVisualStyleBackColor = true;
            this.addCustome.Click += new System.EventHandler(this.addCustome_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(164, 300);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(96, 47);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(272, 20);
            this.textBox6.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(216, 159);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 20;
            this.Email.Text = "Email";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(620, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(92, 20);
            this.textBox7.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.addCustome);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.getCustomerLast);
            this.Controls.Add(this.getCustomerNext);
            this.Controls.Add(this.getCustomerPre);
            this.Controls.Add(this.getCustomerFirst);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label ADDRESS;
        private System.Windows.Forms.Label PHONE;
        private System.Windows.Forms.Label GENDER;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button getCustomerFirst;
        private System.Windows.Forms.Button getCustomerPre;
        private System.Windows.Forms.Button getCustomerNext;
        private System.Windows.Forms.Button getCustomerLast;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustome;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
    }
}

