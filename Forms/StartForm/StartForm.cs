using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyHeadlines.Forms.HeadlineForm;

namespace EasyHeadlines
{
    public partial class startForm : Form
    {
        private headlineForm headlineForm;
        public startForm()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startForm_FormClosed);

            this.headlineForm = new headlineForm();
        }

        private void startForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void showMeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.headlineForm.Show();
        }
    }
}
