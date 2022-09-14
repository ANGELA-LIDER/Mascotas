using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP);

        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP);

        void DeletVisitaPyP(int idVisitaPyP);
        //VisitaPyP GetVisitaPyP(int idVisitaPyP);
        //IEnumerable<VisitaPyP> GetAllVisitaPyP();
    }
}
