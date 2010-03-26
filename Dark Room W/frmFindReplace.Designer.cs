namespace DarkRoomW
{
    partial class frmFindReplace
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
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.chkWholeWords = new System.Windows.Forms.CheckBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUp = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDirection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(13, 13);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(30, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(49, 10);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(251, 20);
            this.txtFind.TabIndex = 1;
            // 
            // chkWholeWords
            // 
            this.chkWholeWords.AutoSize = true;
            this.chkWholeWords.Location = new System.Drawing.Point(16, 45);
            this.chkWholeWords.Name = "chkWholeWords";
            this.chkWholeWords.Size = new System.Drawing.Size(148, 17);
            this.chkWholeWords.TabIndex = 2;
            this.chkWholeWords.Text = "Match &Whole Words Only";
            this.chkWholeWords.UseVisualStyleBackColor = true;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(16, 68);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(83, 17);
            this.chkCase.TabIndex = 3;
            this.chkCase.Text = "Match &Case";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.rdoDown);
            this.grpDirection.Controls.Add(this.rdoUp);
            this.grpDirection.Location = new System.Drawing.Point(192, 43);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(108, 50);
            this.grpDirection.TabIndex = 4;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Direction";
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Checked = true;
            this.rdoDown.Location = new System.Drawing.Point(53, 19);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(54, 17);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "&Down";
            this.rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUp
            // 
            this.rdoUp.AutoSize = true;
            this.rdoUp.Location = new System.Drawing.Point(6, 19);
            this.rdoUp.Name = "rdoUp";
            this.rdoUp.Size = new System.Drawing.Size(40, 17);
            this.rdoUp.TabIndex = 0;
            this.rdoUp.TabStop = true;
            this.rdoUp.Text = "&Up";
            this.rdoUp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(328, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(80, 61);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(3, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(74, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "&Find Next";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFindReplace
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(417, 105);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grpDirection);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.chkWholeWords);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFindReplace";
            this.Text = "Dark Room W - Find";
            this.Load += new System.EventHandler(this.frmFindReplace_Load);
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox chkWholeWords;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.RadioButton rdoDown;
        private System.Windows.Forms.RadioButton rdoUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
    }
}