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
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;

namespace DarkRoomW
{
    public partial class DarkTextBox : System.Windows.Forms.RichTextBox 
    {
        // TOGGLE MODE
        public bool FormattingEnabled = false;
        
        private const int TO_ADVANCEDTYPOGRAPHY = 1;
        private const int EM_SETTYPOGRAPHYOPTIONS = (Eclectic.WM_USER + 202);

        private int tabCount = 0;

        public bool AutoIndent = false;
        public int TabsToSpaces = 0;

        public DarkTextBox()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DarkTextBox_KeyDown);
        }

        public DarkTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DarkTextBox_KeyDown);
        }

        #region "Helper Functions"

        private string findIndentLevel()
        {
            int startPos;
            int endPos;
            string test;

            startPos = Text.LastIndexOf("\n") + 1;
            if (startPos == -1) startPos = 0;

            for (endPos = startPos; endPos < SelectionStart; endPos++)
            {
                test = Text.Substring(endPos, 1);
                if (test != " " & test != "\t")
                    break;
            }
            
            if (startPos != endPos) 
            {
                return Text.Substring(startPos, endPos - startPos);
            }

            return "";
        }

        #endregion

        private void DarkTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.Control) // handle control key functions
            {
                if (FormattingEnabled) // handle formating keys if formatting enabled
                {
                    if (e.KeyCode == Keys.B)
                    {
                        if (this.SelectionFont.Bold)
                        {
                            this.SelectionFont = new Font(this.SelectionFont, FontStyle.Regular);
                        }
                        else
                        {
                            this.SelectionFont = new Font(this.SelectionFont, FontStyle.Bold);
                        }
                    }
                    else if (e.KeyCode == Keys.J)
                    {
                        Eclectic.SendMessage(Handle, EM_SETTYPOGRAPHYOPTIONS, TO_ADVANCEDTYPOGRAPHY, TO_ADVANCEDTYPOGRAPHY);
                    }
                }
                else // supress formating if formatting disabled
                {
                    if (e.KeyCode == Keys.L || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.Oem2 || e.KeyCode == Keys.Oem1)
                    {
                        e.Handled = true;
                    }
                }
            }
            else // handle if control not pressed 
            {
                // handle new line
                if (e.KeyCode == Keys.Enter)
                {
                    // handle autoindent
                    if (AutoIndent & SelectionStart != 0)
                    {
                        SelectedText = "\n" + findIndentLevel();
                        e.Handled = true;
                    }
                }

                // handle tabs to spaces
                if (e.KeyCode == Keys.Tab)
                {
                    if (TabsToSpaces > 0)
                    {

                        SendKeys.Send("{BACKSPACE}");
                        for (int i = 0; i < TabsToSpaces; i++)
                            SendKeys.Send(" ");
                    }

                    tabCount++;
                }
            }
        }
    }
}
