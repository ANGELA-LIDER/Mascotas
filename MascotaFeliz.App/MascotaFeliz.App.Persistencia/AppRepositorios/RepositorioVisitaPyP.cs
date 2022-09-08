/*
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
   var historiaAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
   _appContext.SaveChanges();   
   return historiaAdicionado.Entity;
}

public void DeletVisitaPyP(int idVisitaPyP)
{
 var historiaEncontrado = _appContext.VisitaPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
                                  
   return;
_appContext.VisitaPyP.Remove(historiaEncontrado);
_appContext.SaveChanges();
}

public IEnumerable<VisitaPyP> GetAllVisitaPyP()
{
    return GetAllVisitaPyP();
}

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

           public VisitaPyP GetVisitaPyP(int idVisitaPyP)
{
    return _appContext.VisitaPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
}

            public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
{
    var historiaEncontrado = _appContext.VisitaPyP.FirstOrDefault(v => v.Id == visitaPyP.Id);
if (historiaEncontrado != null)
{
    historiaEncontrado.FechaInicial = visitaPyP.FechaInicial;
    historiaEncontrado.VisitaPyP = visitaPyP.VisitaPyP;
   
    _appContext.SaveChanges();
}
   return historiaEncontrado;

  }
 } 
 }
 */