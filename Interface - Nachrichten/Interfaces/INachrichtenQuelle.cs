using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Nachrichten.Interfaces
{
    internal interface INachrichtenQuelle
    {
        void Anmelden(INachrichtenEmpfanger empfanger);

        void Abmelden(INachrichtenEmpfanger empfanger);

        void SendeNachricht(string nachricht);
    }
}
