using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCS7.Classes
{
    internal class Cheetah:IRun
    {
        public Cheetah(int speed) { }

        public string Type;
        public byte Age;

        int _recoverytime;
        public int RecoveryTime
        {
            get=>_recoverytime; set => _recoverytime = value;
        }


        int _runspeed=110;
        public int RunSpeed
        {
            get=>_runspeed; set => _runspeed = value;
        }


        int _runtime=30;
        public int RunTime
        {
            get=>_runtime; set => _runtime = value;
        }

        public void RunCooldown()
        {
            _runspeed = _runtime;
        }

        public void Recovery()
        {
            _recoverytime = _runspeed;
        }
    }
}
