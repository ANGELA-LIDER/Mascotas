using System;
namespace MascotaFeliz.App.Dominio
{

public class Mascota
    {
        public int Id {set; get;}
        public string Nombre {set; get;}
        public string Color {set; get;}
        public string Especie {set; get;}
        public string Raza {set; get;}
        public Dueno Dueno {set; get;}
        public Veterinario Veterinario {set; get;}
        public Historia Historia {set; get;}

    }

}