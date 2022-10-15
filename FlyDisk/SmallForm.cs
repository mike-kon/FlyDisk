using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyDisk
{
    public partial class SmallForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IShootType? shootType;
        public SmallForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            var screen = System.Windows.Forms.Screen.PrimaryScreen;
            this.Top = screen.Bounds.Size.Height - this.Height - 1;
            this.Left = screen.Bounds.Size.Width - this.Width - 1;
            shootType = (IShootType)mainForm.BoxShootType.SelectedValue;
            LbInfo.Text = shootType?.Name ?? "Сначала выберите тип";
            Start.Enabled = shootType != null;
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            var color = this.BackColor;
            this.BackColor = Color.Red;
            await mainForm.Shoot();
            this.BackColor = color;
        }

        private void SmallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
