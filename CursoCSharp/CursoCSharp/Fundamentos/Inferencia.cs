using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            /* Pelo fato de ter duas aspas duplas ao redor de "Leonardo"
             * a propria IDE identificou, via inferência, que a função 'nome'
             * é do tipo string.
             * A limitação da inferência é que você é obrigado a setar um valor
             * para ela, caso contrário não irá funcionar.
             */
            var nome = "Leonardo";
        }
    }
}
