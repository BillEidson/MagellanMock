using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagellanMock
{
    public static class ControlExtensions
    {
        public static void Invoke(this Control control, Action Action)
        {
            control.Invoke(Action);
        }
    }
}
