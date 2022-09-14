using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno
            _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioVeterinario
            _repoVeterinario =
                new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioMascota
            _repoMascota =
                new RepositorioMascota(new Persistencia.AppContext());

        private static IRepositorioHistoria
            _repoHistoria =
                new RepositorioHistoria(new Persistencia.AppContext());

        private static IRepositorioVisitaPyP
            _repoVisitaPyP =
                new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console
                .WriteLine("hola leo vamos a empezar a trabajar con las tablas ");

            AddDueno();
            BuscarDueno(1);
            

            AddVeterinario();
            BuscarVeterinario(2);

            AddMascota();
            BuscarMascota(2);

            AddHistoria();
            BuscarHistoria(3);

            //AddVisitaPyP();
            //ListarDuenoFiltro();
            //ListarVeterinariosFiltro();
            //ListarMascotaFiltro();
            //GetMascota(1);
            //GetAllMascotas();
        }

        private static void AddDueno()
        {
            var dueno =
                new Dueno {
                    Nombres = "esneider",
                    Apellidos = "suarez",
                    Direccion = "calle 43",
                    Telefono = "3122548016",
                    Correo = "suarezsebastian@gmail.com"
                };
            _repoDueno.AddDueno (dueno);
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console
                .WriteLine(dueno.Nombres +
                " " +
                dueno.Apellidos +
                " " +
                dueno.Direccion +
                " " +
                dueno.Telefono +
                " " +
                dueno.Correo);
        }

        private static void AddVeterinario()
        {
            var veterinario =
                new Veterinario {
                    Nombres = "federico",
                    Apellidos = "suarez",
                    Direccion = "43 31-52",
                    Telefono = "3125872",
                    TarjetaProfesional = "0001"
                };
            _repoVeterinario.AddVeterinario (veterinario);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console
                .WriteLine(veterinario.Nombres +
                " " +
                veterinario.Apellidos +
                " " +
                veterinario.Direccion +
                " " +
                veterinario.Telefono +
                " " +
                veterinario.TarjetaProfesional);
        }

        private static void AddMascota()
        {
            var mascota =
                new Mascota {
                    Nombres = "gara3",
                    Color = "Dorado",
                    Raza = "Labrador",
                    Especie = "Canino"
                };
            _repoMascota.AddMascota (mascota);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console
                .WriteLine(mascota.Id +
                " " +
                mascota.Nombres +
                " " +
                mascota.Color +
                " " +
                mascota.Especie +
                " " +
                mascota.Raza);
        }


        private static void AddHistoria()
        {
            var historia =
                new Historia {
                    FechaInicial = new DateTime(2000, 04, 12),
                    VisitasPyP = new List<VisitaPyP>(5)
                };
            _repoHistoria.AddHistoria (historia);
        }

        private static void BuscarHistoria(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine(historia.FechaInicial);
        }

                /*
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console
                .WriteLine(mascota.Nombres +
                " " +
                mascota.Color +
                " " +
                mascota.Raza +
                " " +
                mascota.Especie);
        }
*/

        /*
        private static void ListarDuenosFiltro()
        {
            var duenoM = _repoDueno.GetDuenosPorFiltro("Fel");
            foreach (Dueno p in duenoM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }
        }

        private static void ListarDuenoFiltro()
        {
            var duenos = _repoDueno.GetDuenosPorFiltro("Fel");
            foreach (Dueno p in duenos)
            {

                Console
                    .WriteLine(duenos.Nombres +
                    " " +
                    duenos.Apellidos +
                    " " +
                    duenos.Direccion +
                    " " +
                    duenos.Telefono +
                    " " +
                    duenos.Correo);
            }
        }
*/

/*                                        
private static void GetAllMascotas()
{
                                     
    var mascotaM = _repoMascota.GetAllMascotas("");
    foreach (Mascota p in mascotaM)
    {
        Console.WriteLine(p.Nombres+ ""+ p.Color);
    }
}

    private static void ListarMascotaFiltro()
{
    var mascotaM = _repoMascota.GetMascotasPorFiltro("");
    foreach (Mascota p in mascotaM)
    {
        Console.WriteLine(p.Nombres+ ""+ p.Color);
    }
}
*/
    }
}
