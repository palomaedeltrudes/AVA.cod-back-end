using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2___Encontro_Remoto_2.Interfaces
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// Metodo para validar o Cnpj da Pessoa Juridica
        /// </summary>
        /// <param name="Cnpj">Cnpj</param>
        /// <returns>verdadeiro ou falso</returns>
       bool ValidarCnpj(string Cnpj);
    }
}