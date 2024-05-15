using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo.Clases
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        int graduacionYear;
        public ExAlumno(int cedula, string nombre, string apellido, int graduacionYear):
            base(cedula, nombre, apellido) 
        {
            this.graduacionYear = graduacionYear;
        }
        public override void ObtenerInfo()
        {
            throw new NotImplementedException();
        }
    }
}
