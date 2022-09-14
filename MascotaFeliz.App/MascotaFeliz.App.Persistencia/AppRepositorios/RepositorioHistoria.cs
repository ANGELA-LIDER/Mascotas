using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia

{
public class RepositorioHistoria : IRepositorioHistoria
{  
///<summary>
/// Referencia al contexto del Historia
///</summary>
private readonly AppContext _appContext;
//<summary>
/// Metodo Constructor utilizado
//<summary>
//</summary>
///<param name="appContext"></param>//
public RepositorioHistoria(AppContext appContext)
{
    _appContext = appContext;
}

public Historia AddHistoria(Historia historia)
{
   var historiaAdicionado = _appContext.Historias.Add(historia);
   _appContext.SaveChanges();   
   return historiaAdicionado.Entity;
}


public Historia GetHistoria(int idHistoria)
{
    return _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
}

public Historia UpdateHistoria(Historia historia)
{
    var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == historia.Id);
if (historiaEncontrado != null)
{
    historiaEncontrado.FechaInicial = historia.FechaInicial;
    historiaEncontrado.VisitasPyP = historia.VisitasPyP;
                                                                 
    _appContext.SaveChanges();
}
   return historiaEncontrado; 

     }

public void DeletHistoria(int idHistoria)
{
 var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);

    return;
_appContext.Historias.Remove(historiaEncontrado);
_appContext.SaveChanges();
}

   } 
}

