
namespace vacc
{
    partial class ViewInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.gender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.gov = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.vac = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.dosagenum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.category = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "FULL NAME";
            // 
            // nametxt
            // 
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nametxt.HintForeColor = System.Drawing.Color.Empty;
            this.nametxt.HintText = "";
            this.nametxt.isPassword = false;
            this.nametxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.nametxt.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.nametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nametxt.LineThickness = 3;
            this.nametxt.Location = new System.Drawing.Point(45, 122);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(217, 46);
            this.nametxt.TabIndex = 13;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nametxt.OnValueChanged += new System.EventHandler(this.name_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(662, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(377, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "NATIONAL ID";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(626, 122);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(217, 46);
            this.email.TabIndex = 43;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.OnValueChanged += new System.EventHandler(this.email_OnValueChanged);
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.id.HintForeColor = System.Drawing.Color.Empty;
            this.id.HintText = "";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.Blue;
            this.id.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.id.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(346, 122);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(217, 46);
            this.id.TabIndex = 44;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(61, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "GENDER";
            // 
            // gender
            // 
            this.gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gender.HintForeColor = System.Drawing.Color.Empty;
            this.gender.HintText = "";
            this.gender.isPassword = false;
            this.gender.LineFocusedColor = System.Drawing.Color.Blue;
            this.gender.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.gender.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gender.LineThickness = 3;
            this.gender.Location = new System.Drawing.Point(45, 278);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(217, 46);
            this.gender.TabIndex = 46;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(411, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "AGE";
            // 
            // age
            // 
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.age.HintForeColor = System.Drawing.Color.Empty;
            this.age.HintText = "";
            this.age.isPassword = false;
            this.age.LineFocusedColor = System.Drawing.Color.Blue;
            this.age.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.age.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.age.LineThickness = 3;
            this.age.Location = new System.Drawing.Point(346, 278);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(217, 46);
            this.age.TabIndex = 48;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(662, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Governorate";
            // 
            // gov
            // 
            this.gov.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gov.HintForeColor = System.Drawing.Color.Empty;
            this.gov.HintText = "";
            this.gov.isPassword = false;
            this.gov.LineFocusedColor = System.Drawing.Color.Blue;
            this.gov.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.gov.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gov.LineThickness = 3;
            this.gov.Location = new System.Drawing.Point(626, 278);
            this.gov.Margin = new System.Windows.Forms.Padding(4);
            this.gov.Name = "gov";
            this.gov.Size = new System.Drawing.Size(217, 46);
            this.gov.TabIndex = 50;
            this.gov.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(49, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "VACCINATION STATUS";
            // 
            // vac
            // 
            this.vac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vac.Enabled = false;
            this.vac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vac.HintForeColor = System.Drawing.Color.Empty;
            this.vac.HintText = "";
            this.vac.isPassword = false;
            this.vac.LineFocusedColor = System.Drawing.Color.Blue;
            this.vac.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.vac.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.vac.LineThickness = 3;
            this.vac.Location = new System.Drawing.Point(45, 454);
            this.vac.Margin = new System.Windows.Forms.Padding(4);
            this.vac.Name = "vac";
            this.vac.Size = new System.Drawing.Size(217, 46);
            this.vac.TabIndex = 52;
            this.vac.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(351, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "NUMBER OF DOSAGES\r\n";
            // 
            // dosagenum
            // 
            this.dosagenum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dosagenum.Enabled = false;
            this.dosagenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosagenum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dosagenum.HintForeColor = System.Drawing.Color.Empty;
            this.dosagenum.HintText = "";
            this.dosagenum.isPassword = false;
            this.dosagenum.LineFocusedColor = System.Drawing.Color.Blue;
            this.dosagenum.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.dosagenum.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.dosagenum.LineThickness = 3;
            this.dosagenum.Location = new System.Drawing.Point(346, 454);
            this.dosagenum.Margin = new System.Windows.Forms.Padding(4);
            this.dosagenum.Name = "dosagenum";
            this.dosagenum.Size = new System.Drawing.Size(217, 46);
            this.dosagenum.TabIndex = 54;
            this.dosagenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(676, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "CATEGORY";
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.category.HintForeColor = System.Drawing.Color.Empty;
            this.category.HintText = "";
            this.category.isPassword = false;
            this.category.LineFocusedColor = System.Drawing.Color.Blue;
            this.category.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.category.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.category.LineThickness = 3;
            this.category.Location = new System.Drawing.Point(626, 454);
            this.category.Margin = new System.Windows.Forms.Padding(4);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(217, 46);
            this.category.TabIndex = 56;
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(81, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 50);
            this.button2.TabIndex = 58;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(401, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 50);
            this.button1.TabIndex = 59;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(681, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 50);
            this.button3.TabIndex = 60;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 654);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dosagenum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gov);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Name = "ViewInfo";
            this.Text = "ViewInfo";
            this.Load += new System.EventHandler(this.ViewInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gender;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox age;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gov;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox vac;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dosagenum;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox category;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}