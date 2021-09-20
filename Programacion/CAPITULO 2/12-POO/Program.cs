using System;

namespace _12_POO
{
    class Program
    {
        static void Main(string[] args)
        {   
                //Menu Raiz
                Menu menuRaiz = new Menu();
                menuRaiz.Id=0;
                menuRaiz.UrlIcono=null;
                menuRaiz.Nombre="Raiz";
                menuRaiz.Funcionalidad="Nada";
                menuRaiz.Activo= true;
                menuRaiz.hijos= new List<Menu>();

                //Menu Archivo
                Menu menuArchivo = new Menu();
                menuArchivo.Id=0;
                menuArchivo.UrlIcono=null;
                menuArchivo.Nombre="Archivo";
                menuArchivo.Funcionalidad="Desplegar menu hijos";
                menuArchivo.Activo= true;
                menuArchivo.hijos= new List<Menu>();

                //Menu Editar
                Menu menuEditar = new Menu();
                menuEditar.Id=0;
                menuEditar.UrlIcono=null;
                menuEditar.Nombre="Archivo";
                menuEditar.Funcionalidad="Desplegar menu hijos";
                menuEditar.Activo= true;
                menuEditar.hijos= new List<Menu>();

                //Menu Ver
                Menu menuVer = new Menu();
                menuVer.Id=0;
                menuVer.UrlIcono=null;
                menuVer.Nombre="Archivo";
                menuVer.Funcionalidad="Desplegar menu hijos";
                menuVer.Activo= true;
                menuVer.hijos= new List<Menu>();

                //Aqui hacemos los menu Archivo, Editar , Ver Hijos de Raiz
                menuRaiz.hijos.Add(menuArchivo);
                menuRaiz.hijos.Add(menuEditar);
                menuRaiz.hijos.Add(menuVer);

        }
    }

    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public char Sexo { get; set; }
        public string Curp { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public Datetime FechaNacimiento { get; set; }
        public int MyProperty { get; set; }
    }

    class Menu
    {
        public int Id { get; set; }
        public string UrlIcono { get; set; }
        public string Nombre { get; set; }
        public string Funcionalidad { get; set; }
        public bool Activo { get; set; }
        public List<Menu> hijos { get; set; }
    }



}
