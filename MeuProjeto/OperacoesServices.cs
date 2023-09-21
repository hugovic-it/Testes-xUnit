using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal static class OperacoesServices
    {
        public static bool UsuarioMaiorDeIdade(Usuario user) 
        { 
            if(user.Idade >= 18){
                return true;
            }
            return false;
        }
    }
}
