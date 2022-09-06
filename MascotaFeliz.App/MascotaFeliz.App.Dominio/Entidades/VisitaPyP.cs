using System;
using System.Collections.Generic;
namespace MascotaFeliz.App.Dominio
{

public class VisitaPyP
    {
        public int Id {set; get;}
        public float Temperatura {set; get;}        
        public float Peso {set; get;}
        public float FrecuenciaRespiratoria {set; get;}
        public float FrecuenciaCardiaca {set; get;}
        public string EstadoAnimo {set; get;}
        public DateTime FechaVisita {set; get;}
        public int IdVeterinario {set; get;}
        public string Recomendaciones {set; get;}
        

    }

}