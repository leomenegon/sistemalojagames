using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaGames
{
    public static class GlobalVar
    {
        static int _VarGlobal;
        public static int VarGlobal
        {
            get
            {
                return _VarGlobal;
            }
            set
            {
                _VarGlobal = value;
            }
        }
    }
}
