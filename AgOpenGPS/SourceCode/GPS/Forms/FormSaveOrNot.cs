﻿using System;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormSaveOrNot : Form
    {
        //class variables
        //private readonly FormGPS mf = null;

        public FormSaveOrNot()
        {
            //get copy of the calling main form
            //mf = callingForm as FormGPS;

            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //back to FormGPS
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            Close();
        }

        private void FormSaveOrNot_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}