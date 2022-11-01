using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2.Models.Base
{
    public abstract class InstrumentoMusical
    {
        //Se hace que la clase devuelva string en lugar de void para poder mostrar en MessageBox y no solo en consola
        public abstract string Afinar();
    }
}
