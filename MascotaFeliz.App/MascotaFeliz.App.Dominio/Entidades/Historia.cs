using System;
using System.Collections.Generic;
namespace MascotaFeliz.App.Dominio
{

public class Historia
{
public int Id {set; get;}    
public DateTime FechaInicial {set; get;}
public List<VisitaPyP> VisitasPyP {get;set;}
}

}