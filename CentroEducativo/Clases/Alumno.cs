using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroEducativo.Interface;

namespace CentroEducativo.Clases
{
    public class Alumno : MiembroDeLaComunidad, IMetodos
    {
        public int matricula;
        public Alumno (int cedula, string nombre, string apellido, int matricula) : base ( cedula, nombre, apellido)
        {
            this.matricula = matricula;
        }
        //sobreescritura
        public override void ObtenerInfo()
        {
            throw new NotImplementedException();
        }
        //metodos propios de la clase
        public void CalcularPromedio()
        { 
            Console.WriteLine("metodo para calcular promedio"); 
        
        }
        public void RealizarPago()
        { 
           
            Console.WriteLine("Estudiante paga creditos e inscripcion"); 
        }
        public void RetirarMateria() 
        
        { 
            Console.WriteLine("Estudiante retira materias");
        }
        //metodos de la interface
        public void ConsultarHorario()
        {
            throw new NotImplementedException();
        }

        public void VerCalificaciones()
        {
            throw new NotImplementedException();
        }

        public void CalcularCalificaciones()
        {
            throw new NotImplementedException();
        }
    }

}
