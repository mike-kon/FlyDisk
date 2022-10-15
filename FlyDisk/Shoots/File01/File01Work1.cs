using Koma.Utils.WinReestr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlyDisk.Shoots.File01
{
    [WinReester(ReistryHKEY.HKEY_CURRENTUSER, "FlyDisk\\File01")]
    public class File01Work1 : IShootType, IDisposable
    {
        private readonly File01Frame _frame;
        private int _LastN;
        private DateTime _LastRun;

        [WinReestrField]
        public int LastN { get => _LastN; set => _LastN = value; }
        [WinReestrField]
        public string LastRun { get => _LastRun.ToString(); set => _LastRun = DateTime.Parse(value); }
        [WinReestrField]
        public string FileMask { get => _frame.FileMask.Text; set => _frame.FileMask.Text = value; }
        [WinReestrField]
        public string SourceFile { get => _frame.SourceFile.Text; set => _frame.SourceFile.Text = value; }
        [WinReestrField]
        public string DestDir { get => _frame.DestDir.Text; set { _frame.DestDir.Text = value; } }
        public File01Work1()
        {
            _frame = new File01Frame();
            _LastN = 1;
            _LastRun = DateTime.Now.Date;
            WinReestr.Load(this);
        }

        public string Name => "Простой файл";

        public string Description => "Создает файл на основании изветсного, переименовывая его";

        public UserControl Frame => _frame;

        private const string PATTERN = @"{([A-Z])(\((.*)\))?}";
        public void Shoot()
        {
            var Reg = new Regex(PATTERN);
            string FileName = FileMask;
            var matches = Reg.Matches(FileName);
            foreach (Match match in matches)
            {
                string repl = match.Groups[1].Value.Trim() switch
                {
                    "D" => DateTime.Now.ToString(match.Groups[3].Value),
                    "N" => GetNextNumber(),
                    _ => throw new Exception(match.Groups[1].Value.Trim() + "not emplementated")
                };
                FileName = FileName.Replace(match.Value, repl);
            }
            File.Copy(SourceFile, $"{DestDir}\\{FileName}");
            WinReestr.Save(this);
        }

        private string GetNextNumber()
        {
            _LastN = _LastRun < DateTime.Now.Date ? 1 : _LastN + 1;
            _LastRun = DateTime.Now.Date;
            return _LastN.ToString();
        }

        public void Dispose()
        {
            WinReestr.Save(this);
            GC.SuppressFinalize(this);
        }
    }
}
