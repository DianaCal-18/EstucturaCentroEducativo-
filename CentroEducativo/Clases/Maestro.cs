using CentroEducativo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo.Clases
{
    public class Maestro : Docente, IMetodos
    {
        public Maestro(int cedula, string nombre, string apellido, int id, float salario, string puesto, string departamento, string especialidad)
            : base(cedula, nombre, apellido, id, salario, puesto, departamento, especialidad) { }
        public void RevisarTareas() { }
        public void CalcularCalificaciones()
        {
            throw new NotImplementedException();
        }

        public void ConsultarHorario()
        {
            throw new NotImplementedException();
        }

        public void VerCalificaciones()
        {
            throw new NotImplementedException();
        }
    }
}
