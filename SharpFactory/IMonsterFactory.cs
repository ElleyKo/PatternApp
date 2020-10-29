using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory
{
    /// <summary>
    /// Абстракция для фабрики монстров.
    /// </summary>
    interface IMonsterFactory
    {
        ///<summary>
        /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта.
        /// </summary>
        /// <returns></returns>
        IMonster Create();
    }
}
