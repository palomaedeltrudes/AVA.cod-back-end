using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2___Encontro_Remoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        /// <summary>
        /// metodo para validar a data de nascimento da Pessoa Fisica.
        /// </summary>
        /// <param name="datanascimento">datanascimento</param>
        /// <returns>verdadeiro ou falso</returns>
      bool ValidarDataNascimento(DateTime datanascimento);  
    }
}