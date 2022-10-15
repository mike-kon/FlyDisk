using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyDisk.Shoots.File01
{    
    public partial class File01Frame : UserControl
    {
        public File01Frame()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (OpenFileDLG.ShowDialog() == DialogResult.OK)
            {
                SourceFile.Text = OpenFileDLG.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DestDirDLG.ShowDialog() == DialogResult.OK)
            {
                DestDir.Text = DestDirDLG.SelectedPath;
            }
        }
    }
}
