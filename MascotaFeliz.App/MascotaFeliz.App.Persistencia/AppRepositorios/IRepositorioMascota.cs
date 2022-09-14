using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        Mascota AddMascota(Mascota mascota);

        Mascota GetMascota(int idMascota);

        Mascota UpdateMascota(Mascota mascota);

        void DeleteMascota(int idMascota);
        //IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
        IEnumerable<Mascota> GetAllMascotas();
    }
}
