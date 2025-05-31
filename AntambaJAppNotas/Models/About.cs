using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntambaJAppNotas.Models
{
    internal class About
    {
    
        public string Title => "Juan Carlos Antamba";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message =>
            "Soy Ingeniero en Software, me gustaría especializarme en desarrollo Front-End. Me gustan los deportes, especialmente el fútbol, y mi equipo favorito es Liga de Quito.";
    }
}
