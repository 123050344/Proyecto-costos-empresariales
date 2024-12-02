using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_costos_empresariales
{
    internal class DatosCostos
    {
        public static double MateriaPrima { get; set; }
        public static double ManoObra { get; set; }
        public static double CostosIndirectos { get; set; }
        public static double VolumenProducido { get; set; }
        public static double VolumenTerminado { get; set; }
        public static double GradoAvanceMP { get; set; }
        public static double GradoAvanceMO { get; set; }
        public static double GradoAvanceCI { get; set; }
        public static double TotalProduccionTerminada { get; set; }
        public static double TotalInventarioFinal { get; set; }
    }
}
