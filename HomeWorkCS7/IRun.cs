using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCS7
{
    internal interface IRun
    {
        int RunSpeed { get; set; }
        int RunTime { get; set; }

        int RecoveryTime { get; set; }

        void RunCooldown();

        void Recovery();

    }
}
