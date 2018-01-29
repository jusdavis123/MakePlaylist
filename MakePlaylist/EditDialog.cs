using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MakePlaylist
{
    public partial class EditDialog : Form
    {
        public Storage rootVal { get; set; }
        public string pathVal { get; set; } 

        public EditDialog()
        {
            InitializeComponent();

            IList<ExtPath> paths = new List<ExtPath> { 
                new ExtPath(){ id = Storage.Internal, pathName = ExtPath.INTERNAL_SD },
                new ExtPath(){ id = Storage.External, pathName = ExtPath.EXTERNAL_SD },
                new ExtPath(){ id = Storage.External2, pathName = ExtPath.EXTERNAL_SD2 },
            };
            CBRoot.DataSource = paths;
            CBRoot.DisplayMember = "pathName";
            CBRoot.ValueMember = "id";
            CBRoot.SelectedIndex = 0;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            rootVal = (ChkRoot.Checked) ? (Storage)CBRoot.SelectedValue : Storage.None;

            if(ChkPath.Checked)
            {
                string tempPath = TBPath.Text;

                // Remove "/" at the beginning if present
                if (tempPath[0] == '/')
                    tempPath = tempPath.Remove(0, 1);

                // Make sure path always has an "/" at the end
                if (tempPath[tempPath.Length - 1] != '/')
                    tempPath += "/";

                pathVal = tempPath;
            }
            else
                pathVal = null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ChkRoot_CheckedChanged(object sender, EventArgs e)
        {
            CBRoot.Enabled = (ChkRoot.Checked);
            checkBtnOk();
        }

        private void ChkPath_CheckedChanged(object sender, EventArgs e)
        {
            TBPath.Enabled = (ChkPath.Checked);
            checkBtnOk();
        }

        private void TBPath_TextChanged(object sender, EventArgs e)
        {
            checkBtnOk();
        }

        private void checkBtnOk()
        {
            if (ChkRoot.Checked)
                BtnOk.Enabled = !(ChkPath.Checked && TBPath.Text == String.Empty);
            else
                BtnOk.Enabled = !(!ChkPath.Checked || (ChkPath.Checked && TBPath.Text == String.Empty));
        }
    }
}
