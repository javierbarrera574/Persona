using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    public class Persona
    {

        #region Atrinutos o campos

        //Defino atributos o campos
        //Que son aquellos que estan a la misma altura que la clase


        private string nombre;

        private int dni;

        private DateTime fecha_nacimiento;

        #endregion FinAtributos/campos


        #region Constructores

        //Defino dos construtores

        public Persona() //constructor inicializador de la clase por defecto
        {

        }

        public Persona(string Nombre, int DNI, DateTime FechaNacimiento)
        {

            nombre = Nombre;

            dni = DNI;


            fecha_nacimiento = FechaNacimiento;

        }

        #endregion FinConstructores

        #region Propiedades

        //Atributos y propiedades estáticas

        private string nombrePersonaP
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int dniPersonaP
        {
            set { dni = value; } //para modificar, actualizar, eliminar, cargar valores, etc

            get { return dni; }//para leer solamente valores
        }

        public DateTime fechaNacimientoPersonaP
        {
            set { fecha_nacimiento = value; }
            get { return fecha_nacimiento; }
        }


        #endregion PropiedadesFin


        #region Metodos

        public int EdadRetornar()
        {
            DateTime actual = DateTime.Now;
            
            int edad = actual.Year - fecha_nacimiento.Year;

            return edad;

        }

        #endregion FinMetodos
    }
}