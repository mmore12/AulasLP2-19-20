﻿
/*
 * lufer
 * 
 * Camada de Regras de Negócio ! Business Rules Layer
 * */

using Dados;
using Excepcoes;
using ObjetosNegocio;

namespace RegrasNegocio
{
    /// <summary>
    /// Descreve os métodos de acesso aos dados, filtrado por regras de negócio
    /// </summary>
    public class Regras
    {

        public Regras()
        {
            
        }

        /// <summary>
        /// Insere nova pessoa
        /// Devolve Exceção "InsereException"
        /// </summary>
        /// <param name="p"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        public static bool InserePessoa(Pessoa p, int perfil)
        {
            //Aplicar regra de negócio
            if (perfil > 0)
            {
                try
                {
                    return Pessoas.AddPessoa(p);
                }
                catch( InsercaoException e)
                {
                    throw e;
                }
            }
            return false;  
        }

        public static Pessoa GetPessoa (int cod, int perfil)
        {
            return null;
        }
       
    }
}
