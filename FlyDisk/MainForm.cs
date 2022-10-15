using Koma.Utils.WinReestr;
using System.Reflection;

namespace FlyDisk
{
    [WinReester(ReistryHKEY.HKEY_CURRENTUSER,"FlyDisk")]
    public partial class MainForm : Form
    {
        private readonly List<IShootType> ShootTypes;

        [WinReestrField]
        public int CurShootType { 
            get => BoxShootType.SelectedIndex;
            set => BoxShootType.SelectedIndex = value;
        }

        public MainForm()
        {
            ShootTypes = new List<IShootType>();
            InitializeComponent();
            LoadClasses();
            BoxShootType.DataSource = ShootTypes;
            BoxShootType.DisplayMember = "Name";
            BoxShootType.SelectedIndex = -1;
            WinReestr.Load(this);
        }

        private void SmalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var small = new SmallForm(this);
            small.Show();
        }

        public void LoadClasses()
        {
            var tps = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var cls in tps.Where(t => !t.IsAbstract && t.GetInterface(typeof(IShootType).ToString()) != null))
            {
                try
                {
                    var ctor = cls.GetConstructor(Array.Empty<Type>())!;
                    IShootType obj = (IShootType)ctor.Invoke(Array.Empty<object>());
                    ShootTypes.Add(obj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void BtnShoot_Click(object sender, EventArgs e)
        {
            await Shoot();
        }

        private IShootType? prev = null;
        private void BoxShootType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlSettings.Controls.Clear();
            if (BoxShootType.SelectedItem is IShootType obj)
            {
                if (prev != null)
                {
                    WinReestr.Save(prev);
                }
                prev = obj;
                WinReestr.Load(obj);
                PnlSettings.Controls.Add(obj.Frame);
                obj.Frame.Width = PnlSettings.Width;
                obj.Frame.Height = PnlSettings.Height;
            }
        }

        private void PnlSettings_Resize(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            foreach (var o in pnl.Controls)
            {
                if (o is UserControl frame)
                {
                    frame.Width = pnl.Width;
                    frame.Height = pnl.Height;
                }
            }
        }
        public async Task Shoot()
        {
            if (BoxShootType.SelectedItem is IShootType obj)
            {
                await Task.Run(() => obj.Shoot());
            }
        }
    }
}