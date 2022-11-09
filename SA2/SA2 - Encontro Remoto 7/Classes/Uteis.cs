using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2___Encontro_Remoto_2.Classes
{
    static class Uteis
    {
      public static void BarraCarregamento(string texto, int tempo, int quantidade)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write(texto);

        for (var contador = 0; contador < quantidade; contador++)
        {
          Console.Write(".");
          Thread.Sleep(tempo);  
        }
        Console.ResetColor();
      } 
    }
}