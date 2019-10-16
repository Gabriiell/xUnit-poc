using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class EnemyFactory
    {
        public object Create(bool isBoss)
        {
            if (isBoss)
            {
                return new BossEnemy();
            }

            return new NormalEnemy();
        }
    }
}