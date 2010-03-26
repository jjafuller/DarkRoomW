/*
 * Dark Room W
 *
 * NOTICE OF LICENSE
 *
 * All project source files are subject to the Open Software License (OSL 3.0)
 * that is included with this applciation in the file LICENSE.txt.
 * The license is also available online at the following URL:
 * http://opensource.org/licenses/osl-3.0.php
 * If you did not receive a copy of the license, please send
 * an email to contact@getdarkroom.com so we can send a copy to you.
 *
 * @package    dr
 * @copyright  Copyright (c) 2010 Jeffrey Fuller (http://getdarkroom.com)
 * @license    Open Software License (OSL 3.0), http://opensource.org/licenses/osl-3.0.php  
 */
 
 namespace DarkRoomW
{
    partial class frmStatistics
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblCharNoSpaces = new System.Windows.Forms.Label();
            this.lblCharSpaces = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(205, 109);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "&OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Characters (no spaces):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Characters (with spaces):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lines:";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(202, 9);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(49, 13);
            this.lblWords.TabIndex = 5;
            this.lblWords.Text = "WORDS";
            // 
            // lblCharNoSpaces
            // 
            this.lblCharNoSpaces.AutoSize = true;
            this.lblCharNoSpaces.Location = new System.Drawing.Point(202, 31);
            this.lblCharNoSpaces.Name = "lblCharNoSpaces";
            this.lblCharNoSpaces.Size = new System.Drawing.Size(65, 13);
            this.lblCharNoSpaces.TabIndex = 6;
            this.lblCharNoSpaces.Text = "NOSPACES";
            // 
            // lblCharSpaces
            // 
            this.lblCharSpaces.AutoSize = true;
            this.lblCharSpaces.Location = new System.Drawing.Point(202, 55);
            this.lblCharSpaces.Name = "lblCharSpaces";
            this.lblCharSpaces.Size = new System.Drawing.Size(49, 13);
            this.lblCharSpaces.TabIndex = 7;
            this.lblCharSpaces.Text = "SPACES";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(202, 79);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(38, 13);
            this.lblLines.TabIndex = 8;
            this.lblLines.Text = "LINES";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 144);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.lblCharSpaces);
            this.Controls.Add(this.lblCharNoSpaces);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStatistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblCharNoSpaces;
        private System.Windows.Forms.Label lblCharSpaces;
        private System.Windows.Forms.Label lblLines;
    }
}