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
                Console.Write("\nCodigo de alumno repetido\nUltimo No Agregado!!!\n");
            }
            
        }
        private void editar()
        {

        }
        private void eliminar()
        {
            Console.WriteLine("Codigo del alumno que desea Eliminar");
            CodigoAlumno = Console.ReadLine();
            BdAlumnos.Remove(CodigoAlumno);

            if (BdAlumnos.ContainsKey("CodigoAlumno"))
            {
                Console.WriteLine("Codigo "+CodigoAlumno+" Eliminado");
            }
            else
            {
                Console.Write("Codigo " + CodigoAlumno + " No se ha encontrado");
            }
        }
        private void imprimir()
        {
            Console.WriteLine("\n   Clave    Nombre");
            foreach (DictionaryEntry Bd in BdAlumnos)
                Console.WriteLine("    {0}:    {1}", Bd.Key, Bd.Value);
        }

    }
}