using PracticaPOO2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2.Models
{
    public class Piano : InstrumentoMusical
    {
        public override string Afinar()
        {
            return "Afinando Piano";
        }
    }
}
