namespace Csharp_12congiap
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
            this.lblnam = new System.Windows.Forms.Label();
            this.txtdl = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtds = new System.Windows.Forms.TextBox();
            this.lblcongiap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnam.Location = new System.Drawing.Point(77, 114);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(44, 20);
            this.lblnam.TabIndex = 0;
            this.lblnam.Text = "NĂM";
            // 
            // txtdl
            // 
            this.txtdl.Location = new System.Drawing.Point(151, 104);
            this.txtdl.Multiline = true;
            this.txtdl.Name = "txtdl";
            this.txtdl.Size = new System.Drawing.Size(88, 33);
            this.txtdl.TabIndex = 1;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(315, 104);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(88, 33);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "TÌM";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(230, 195);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 52);
            this.txtKQ.TabIndex = 3;
            // 
            // txtds
            // 
            this.txtds.Location = new System.Drawing.Point(473, 68);
            this.txtds.Multiline = true;
            this.txtds.Name = "txtds";
            this.txtds.Size = new System.Drawing.Size(239, 302);
            this.txtds.TabIndex = 4;
            // 
            // lblcongiap
            // 
            this.lblcongiap.AutoSize = true;
            this.lblcongiap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcongiap.Location = new System.Drawing.Point(117, 215);
            this.lblcongiap.Name = "lblcongiap";
            this.lblcongiap.Size = new System.Drawing.Size(69, 20);
            this.lblcongiap.TabIndex = 5;
            this.lblcongiap.Text = "con giáp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "DANH SÁCH 12 CON GIÁP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcongiap);
            this.Controls.Add(this.txtds);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtdl);
            this.Controls.Add(this.lblnam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.TextBox txtdl;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtds;
        private System.Windows.Forms.Label lblcongiap;
        private System.Windows.Forms.Label label3;
    }
}

