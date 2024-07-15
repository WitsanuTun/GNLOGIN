namespace GNLOGIN
{
    partial class FormLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picView = new System.Windows.Forms.PictureBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GNLOGIN.Properties.Resources.images__1__removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(52, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.ForeColor = System.Drawing.Color.Black;
            this.tUser.Location = new System.Drawing.Point(27, 231);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(220, 28);
            this.tUser.TabIndex = 1;
            this.tUser.TextChanged += new System.EventHandler(this.tUser_TextChanged);
            // 
            // tPwd
            // 
            this.tPwd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPwd.ForeColor = System.Drawing.Color.Black;
            this.tPwd.Location = new System.Drawing.Point(26, 290);
            this.tPwd.Name = "tPwd";
            this.tPwd.Size = new System.Drawing.Size(220, 28);
            this.tPwd.TabIndex = 2;
            this.tPwd.UseSystemPasswordChar = true;
            this.tPwd.TextChanged += new System.EventHandler(this.tPwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "___________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "___________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "___________________________________";
            // 
            // picView
            // 
            this.picView.BackColor = System.Drawing.Color.Transparent;
            this.picView.Image = global::GNLOGIN.Properties.Resources.images__1__removebg_preview;
            this.picView.Location = new System.Drawing.Point(237, 335);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(37, 28);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 8;
            this.picView.TabStop = false;
            this.picView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picView_MouseDown);
            this.picView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picView_MouseUp);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN.BackgroundImage = global::GNLOGIN.Properties.Resources._230f9a0c7c603ee72788967213f39ac1;
            this.LOGIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.LOGIN.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.Gold;
            this.LOGIN.Location = new System.Drawing.Point(68, 360);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(149, 50);
            this.LOGIN.TabIndex = 9;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(41, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 85);
            this.label5.TabIndex = 10;
            this.label5.Text = "LOGIN";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GNLOGIN.Properties.Resources._230f9a0c7c603ee72788967213f39ac1;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Label label5;
    }
}

