using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Interfaces
{ // Uma interface é um contrato onde a classe que a utilizá-la precisa implementar
  // todos seus metódos que estão sem corpo. Ela não pode ser instânciada. Uma classe 
  // pode utilizar uma ou mais interfaces.
    public interface ICalculadora
    {
        Double Somar (double x, double y);
        Double Subtrair (double x, double y);
        Double Multiplicar (double x, double y);
        Double Dividir (double x, double y);
    }
}