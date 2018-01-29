namespace MakePlaylist
{
    partial class EditDialog
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBRoot = new System.Windows.Forms.ComboBox();
            this.ChkRoot = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkPath = new System.Windows.Forms.CheckBox();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCancel.Location = new System.Drawing.Point(229, 161);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(81, 26);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnOk.Enabled = false;
            this.BtnOk.Location = new System.Drawing.Point(142, 161);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(81, 26);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Playlist root:";
            // 
            // CBRoot
            // 
            this.CBRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRoot.Enabled = false;
            this.CBRoot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBRoot.FormattingEnabled = true;
            this.CBRoot.Location = new System.Drawing.Point(54, 44);
            this.CBRoot.Name = "CBRoot";
            this.CBRoot.Size = new System.Drawing.Size(256, 24);
            this.CBRoot.TabIndex = 7;
            // 
            // ChkRoot
            // 
            this.ChkRoot.AutoSize = true;
            this.ChkRoot.Location = new System.Drawing.Point(21, 48);
            this.ChkRoot.Name = "ChkRoot";
            this.ChkRoot.Size = new System.Drawing.Size(18, 17);
            this.ChkRoot.TabIndex = 8;
            this.ChkRoot.UseVisualStyleBackColor = true;
            this.ChkRoot.CheckedChanged += new System.EventHandler(this.ChkRoot_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist path:";
            // 
            // ChkPath
            // 
            this.ChkPath.AutoSize = true;
            this.ChkPath.Location = new System.Drawing.Point(21, 111);
            this.ChkPath.Name = "ChkPath";
            this.ChkPath.Size = new System.Drawing.Size(18, 17);
            this.ChkPath.TabIndex = 10;
            this.ChkPath.UseVisualStyleBackColor = true;
            this.ChkPath.CheckedChanged += new System.EventHandler(this.ChkPath_CheckedChanged);
            // 
            // TBPath
            // 
            this.TBPath.Enabled = false;
            this.TBPath.Location = new System.Drawing.Point(54, 107);
            this.TBPath.Name = "TBPath";
            this.TBPath.Size = new System.Drawing.Size(256, 22);
            this.TBPath.TabIndex = 11;
            this.TBPath.TextChanged += new System.EventHandler(this.TBPath_TextChanged);
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 211);
            this.Controls.Add(this.TBPath);
            this.Controls.Add(this.ChkPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChkRoot);
            this.Controls.Add(this.CBRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditDialog";
            this.Text = "Edit selected";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBRoot;
        private System.Windows.Forms.CheckBox ChkRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkPath;
        private System.Windows.Forms.TextBox TBPath;
    }
}