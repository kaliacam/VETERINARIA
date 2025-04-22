using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA.Modelos
{
   public class Mascotass
    {
            public int ID { get; set; }
            public string NombreMascota { get; set; }
            public string TipoMascota { get; set; }
            public string Sexo { get; set; }
            public string Raza { get; set; }
            public decimal Peso { get; set; }
            public int Edad { get; set; }
            public bool Vacunas { get; set; }
            public string TiposVacunas { get; set; }
            public string EnfermedadesCronicas { get; set; }
            public bool Alergias { get; set; }
            public string TiposAlergias { get; set; }
        

    }
}
