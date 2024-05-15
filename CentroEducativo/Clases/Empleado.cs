using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo.Clases
{
    public class Empleado : MiembroDeLaComunidad
    {
        private int id;
        private float salario;
        private string puesto;
        private string departamento;


        public Empleado(int cedula, string nombre, string apellido, int id,float salario, string puesto, string departamento) 
            : base(cedula, nombre, apellido)
        {
            this.id = id;
            this.salario = salario;
            this.puesto = puesto;
            this.departamento = departamento;
        }

        //metodos

        public override void ObtenerInfo()
        {
            throw new NotImplementedException();
        }

        public void CalcularSalario()
        {
            Console.WriteLine("Realizar Calculo del salario"); 
        }

    }

}
