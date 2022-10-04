using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2___Encontro_Remoto_2.Interfaces
{
    public interface IPessoa
    {
    /// <summary>
    /// metodo para calcular imposto
    /// </summary>
    /// <param name="rendimento">rendimento para basear o calculo do imposto</param>
    /// <returns>valor do imposto a ser pago</returns>
       float PagarImposto(float rendimento); 

    }
}

