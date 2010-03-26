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
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarkRoomW
{
    public partial class frmFindReplace : Form
    {
        private frmMain parent;

        public frmFindReplace()
        {
            InitializeComponent();
        }

        public frmFindReplace(frmMain pParent)
        {
            parent = pParent;
            InitializeComponent();
        }

        #region "Helper Functions"

        private void Find()
        {
            RichTextBoxFinds options = new RichTextBoxFinds();
            if (chkWholeWords.Checked)
            {
                options = options | RichTextBoxFinds.WholeWord;
            }
            if (chkCase.Checked)
            {
                options = options | RichTextBoxFinds.MatchCase;
            }
            if (rdoUp.Checked)
            {
                options = options | RichTextBoxFinds.Reverse;
            }
            parent.Find(txtFind.Text, options);
        }

        #endregion

        private void frmFindReplace_Load(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Find();
        }
    }
}