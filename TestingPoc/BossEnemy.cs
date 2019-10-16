using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class BossEnemy : Enemy
    {
        public int ExtraPower
        {
            get { return 42; }
        }
    }
}