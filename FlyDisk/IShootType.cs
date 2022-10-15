using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDisk
{
    public interface IShootType
    {
        string Name { get; }
        string Description { get; }
        UserControl Frame { get; }
        void Shoot();
    }
}
