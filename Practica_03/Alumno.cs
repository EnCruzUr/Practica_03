using System;
using System.Collections;
namespace Practica_03
{
    public class Alumno
    {
        private Hashtable BdAlumnos=new Hashtable();
        private string NombreAlumno;
        private string CodigoAlumno;
        public Alumno()
        {
        }

        public void precticaHashtableAlumnos()
        {
            this.alta();
            this.alta();
            this.editar();
            this.imprimir();
            this.eliminar();
            this.imprimir();
            Console.ReadKey(true);
        }

        private void alta()
        {
            Console.Write("Ingrese nombre del alumno: ");
            NombreAlumno = Console.ReadLine();
            Console.Write("Ingresa codigo del alumno: ");
            CodigoAlumno = Console.ReadLine();
            try
            {
                BdAlumnos.Add(CodigoAlumno, NombreAlumno);
            }
            catch
            {
                Console.Write("\nCodigo de alumno repetido\n");
            }
            
        }
        private void editar()
        {

        }
        private void eliminar()
        {

        }
        private void imprimir()
        {

        }

    }
}