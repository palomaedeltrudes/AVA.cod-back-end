using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2___Encontro_Remoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        /// <summary>
        /// metodo para validar o cpf da Pessoa Fisica.
        /// </summary>
        /// <param name="Cpf">Cpf</param>
        /// <returns>verdadeiro ou falso</returns>
      bool ValidarCpf(string Cpf);  
    }
}