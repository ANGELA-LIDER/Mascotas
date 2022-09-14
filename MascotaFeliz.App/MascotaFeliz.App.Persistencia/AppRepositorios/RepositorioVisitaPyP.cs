using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;


    namespace MascotaFeliz.App.Persistencia
{
public class RepositorioVisitaPyP : IRepositorioVisitaPyP
{  
///<summary>
/// Referencia al contexto del VisitaPyP
///</summary>
private readonly AppContext _appContext;
///<summary>
/// Metodo Constructor utilizado
///<summary>
///</summary>
///<param name="appContext"></param>//
public RepositorioVisitaPyP(AppContext appContext)
{
    _appContext = appContext;
}
                                                                                                 
public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
{
   var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
   _appContext.SaveChanges();   
   return visitaPyPAdicionado.Entity;
}

public VisitaPyP GetVisitaPyP(int idVisitaPyP)
{
    return _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
}


public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
{
    var visitaEncontrado = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == visitaPyP.Id);
if (visitaEncontrado != null)
{

    visitaEncontrado.FechaVisita = visitaPyP.FechaVisita;
    visitaEncontrado.Temperatura = visitaPyP.Temperatura;
    visitaEncontrado.Peso = visitaPyP.Peso;
    visitaEncontrado.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
    visitaEncontrado.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
    visitaEncontrado.EstadoAnimo = visitaPyP.EstadoAnimo;
    visitaEncontrado.IdVeterinario = visitaPyP.IdVeterinario;
    visitaEncontrado.Recomendaciones = visitaPyP.Recomendaciones;
  
    _appContext.SaveChanges();
}
   return visitaEncontrado;

  }

  public void DeletVisitaPyP(int idVisitaPyP)
{
 var visitaEncontrado = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
                                                                       
   return;
_appContext.VisitasPyP.Remove(visitaEncontrado);
_appContext.SaveChanges();
}
/*
public IEnumerable<VisitaPyP> GetVeterinariosPorFiltro(string filtro)
{
    var visitaPyP = GetAllVisitaPyP(); // obtiene todos los saludos
    if (visitaPyP != null) // si es tienen saludos
    {
        if (!string.IsNullOrEmpty(filtro)) //si el filtro tiene algun valor
        {
            visitaPyP = visitaPyP.Where(s => s.Nombres.Contains(filtro));
        }
    }
      return historias;
}

public IEnumerable<VisitaPyP> GetAllVisitaPyPs_()
{
    return _appContext.VisitaPyP;
}

public IEnumerable<VisitaPyP> GetAllVisitaPyP()
{
    return GetAllVisitaPyP();
}
*/

 } 
 }
 