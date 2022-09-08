/*
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;


    namespace MascotaFeliz.App.Persistencia
{
public class RepositorioMascota : IRepositorioMascota 
{  
///<summary>
/// Referencia al contexto del Mascota 
///</summary>
private readonly AppContext _appContext;
//<summary>
/// Metodo Constructor utilizado
//<summary>
//</summary>
///<param name="appContext"></param>//
public RepositorioMascota(AppContext appContext)
{
    _appContext = appContext;
}

public Mascota AddMascota(Mascota mascota)
{
   var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
   _appContext.SaveChanges();   
   return mascotaAdicionado.Entity;
}

public void DeletMascota(int idMascota)
{
 var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(d => d.Id == idMascota);

   return;
_appContext.Mascota.Remove(mascotaEncontrado);
_appContext.SaveChanges();
}
/*
public IEnumerable<Mascota> GetAllMascotas()
{
    return GetAllMascotas();
}
*/
/*
public IEnumerable<Mascota> GetVeterinariosPorFiltro(string filtro)
{
    var mascota = GetAllMascotas(); // obtiene todos los saludos
    if (mascota != null) // si es tienen saludos
    {
        if (!string.IsNullOrEmpty(filtro)) //si el filtro tiene algun valor
        {
            mascota = mascota.Where(s => s.Nombres.Contains(filtro));
        }
    }
      return mascotas;
}

          public IEnumerable<Mascota> GetAllMascotas()
{
    return _appContext.Mascota;
}

           public Mascota GetMascota(int idMascota)
{
    return _appContext.Mascota.FirstOrDefault(m => m.Id == idMascota);
}

            public Mascota UpdateMascota(Mascota  mascota)
{
    var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(m => m.Id == mascota.Id);
if (mascotaEncontrado != null)
{
    mascotaEncontrado.Nombre = mascota.Nombre;
    mascotaEncontrado.Color = mascota.Color;
    mascotaEncontrado.Especie = mascota.Especie;
    mascotaEncontrado.Raza =mascota.Raza;
    mascotaEncontrado.Dueno =mascota.Dueno;
    mascotaEncontrado.Veterinario =mascota.Veterinario;
    mascotaEncontrado.Historia =mascota.Historia;
    _appContext.SaveChanges();
}
   return mascotaEncontrado;

  }

        public Veterinario asignarVeterinario(int idMascota,int idVeterinario)
{
        var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(m => m.Id == mascota.Id);
        if (mascotaEncontrado != null)
        {
                var veterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(m => m.Id == mascota.Id);
                if (veterinarioEncontrado != null)
                {
                   mascotaEncontrado.Veterinario = veterinarioEncontrado; 
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
        }
        return null;
}

        public Dueno asignarDueno(int idMascota,int idDueno)
{
        var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(m => m.Id == mascota.Id);
        if (mascotaEncontrado != null)
        {
                var duenoEncontrado = _appContext.Dueno.FirstOrDefault(d => d.Id == mascota.Id);
                if (duenoEncontrado != null)
                {
                   mascotaEncontrado.Dueno = duenoEncontrado; 
                    _appContext.SaveChanges();
                }
                return duenoEncontrado;
        }
        return null;
}

        public Historia asignarHistoria(int idMascota,int idHistoria)
{
        var mascotaEncontrado = _appContext.Mascota.FirstOrDefault(m => m.Id == mascota.Id);
        if (mascotaEncontrado != null)
        {
                var historiaEncontrado = _appContext.Historia.FirstOrDefault(h => h.Id == mascota.Id);
                if (historiaEncontrado != null)
                {
                   mascotaEncontrado.Historia = historiaEncontrado; 
                    _appContext.SaveChanges();
                }
                return historiaEncontrado;
        }
        return null;
  }
 } 
}
 */