using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
class Program
    {

     private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());  
     private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());  
     //private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());  
     //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());  
     //private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());   
        static void Main(string[] args)
        {
            Console.WriteLine("hola leo vamos a empezar a trabajar con las tablas ");

            //ListarDuenosFiltro();
            AddDueno();
            //BuscarDueno();

            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario();
            //AddHistoria();

           
        }   

  private static void AddDueno()
        {
            var dueno = new Dueno
            {
               
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
    
    private static void AddVeterinario()
    {
        var veterinario = new Veterinario
        {
                Nombres = "leonardo",
                Apellidos = "suarez",
                Direccion = "43 31-52",
                Telefono = "3125872",
                TarjetaProfesional = "0001",
        };
        _repoVeterinario.AddVeterinario(veterinario);
    }

    private static void AddHistoria()
    {
        var historia = new Historia
        {
            FechaInicial = new DateTime(1990,04,12)
        
        };
        //_repoHistoria.AddHistoria(historia);
    }


        private static void BuscarDueno(int idDueno)
    {
        var dueno =_repoDueno.GetDueno(idDueno);
        Console.WriteLine(dueno.Nombres+ " " +dueno.Apellidos+" "+dueno.Direccion+" "+dueno.Telefono+" "+dueno.Correo);
    }
    
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres+""+veterinario.Apellidos);
        }
    
         private static void ListarDuenosFiltro()
    {
        var duenoM = _repoDueno.GetDuenosPorFiltro("Fel");
        foreach (Dueno p in duenoM)
        {
            Console.WriteLine(p.Nombres + " " + p.Apellidos);
        }

    }
    
             private static void ListarVeterinariosFiltro()
    {
        var veterinarioM = _repoVeterinario.GetVeterinariosPorFiltro("Fel");
        foreach (Veterinario p in veterinarioM)
        {
            Console.WriteLine(p.Nombres + " " + p.Apellidos);
        }

    }




    }
}
