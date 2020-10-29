using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory
{
    /// <summary>
    /// Абстракция для монстра.
    /// </summary>
    interface IMonster
    {
        /// <summary>
        /// Боевой клич монстра.
        /// </summary>
        void BattleRoar();
    }
}
