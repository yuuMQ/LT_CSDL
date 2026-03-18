namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dis_button = new System.Windows.Forms.Button();
            this.conn_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.sql_radio = new System.Windows.Forms.RadioButton();
            this.window_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.TextBox();
            this.servername = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dis_button);
            this.groupBox1.Controls.Add(this.conn_button);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dbname);
            this.groupBox1.Controls.Add(this.servername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết nối đến Server";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dis_button
            // 
            this.dis_button.Location = new System.Drawing.Point(214, 263);
            this.dis_button.Name = "dis_button";
            this.dis_button.Size = new System.Drawing.Size(144, 31);
            this.dis_button.TabIndex = 7;
            this.dis_button.Text = "DisConnect";
            this.dis_button.UseVisualStyleBackColor = true;
            // 
            // conn_button
            // 
            this.conn_button.Location = new System.Drawing.Point(33, 263);
            this.conn_button.Name = "conn_button";
            this.conn_button.Size = new System.Drawing.Size(133, 31);
            this.conn_button.TabIndex = 6;
            this.conn_button.Text = "Connect";
            this.conn_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.sql_radio);
            this.groupBox2.Controls.Add(this.window_radio);
            this.groupBox2.Location = new System.Drawing.Point(9, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chứng thực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(137, 123);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(122, 20);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(137, 149);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 20);
            this.password.TabIndex = 2;
            // 
            // sql_radio
            // 
            this.sql_radio.AutoSize = true;
            this.sql_radio.Location = new System.Drawing.Point(6, 66);
            this.sql_radio.Name = "sql_radio";
            this.sql_radio.Size = new System.Drawing.Size(151, 17);
            this.sql_radio.TabIndex = 1;
            this.sql_radio.TabStop = true;
            this.sql_radio.Text = "SQL Server Authentication";
            this.sql_radio.UseVisualStyleBackColor = true;
            // 
            // window_radio
            // 
            this.window_radio.AutoSize = true;
            this.window_radio.Location = new System.Drawing.Point(6, 43);
            this.window_radio.Name = "window_radio";
            this.window_radio.Size = new System.Drawing.Size(140, 17);
            this.window_radio.TabIndex = 0;
            this.window_radio.TabStop = true;
            this.window_radio.Text = "Windows Authentication";
            this.window_radio.UseVisualStyleBackColor = true;
            this.window_radio.CheckedChanged += new System.EventHandler(this.window_radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server name";
            // 
            // dbname
            // 
            this.dbname.Location = new System.Drawing.Point(176, 45);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(182, 20);
            this.dbname.TabIndex = 1;
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(176, 19);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(182, 20);
            this.servername.TabIndex = 0;
            this.servername.Text = "(local)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 334);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ket noi CSDL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.RadioButton sql_radio;
        private System.Windows.Forms.RadioButton window_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbname;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Button dis_button;
        private System.Windows.Forms.Button conn_button;
    }
}

