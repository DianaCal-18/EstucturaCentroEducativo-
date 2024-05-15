using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo.Clases
{
    public class Administrativo: Empleado
    {
        public Administrativo(int cedula, string nombre, string apellido, int id, float salario, string puesto, string departamento)
            : base(cedula, nombre, apellido, id, salario, puesto, departamento) 
        { 

        }

        public void GestionarInventario() { }
        public void AtenderConsultas() { }
        public void GestionarMatricular() { }
    }

    
}
