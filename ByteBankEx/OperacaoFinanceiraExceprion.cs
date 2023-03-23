using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankEx
{
    public class OperacaoFinanceiraExceprion : Exception
    {
        public OperacaoFinanceiraExceprion(string message):base(message) 
        {

        }
        public OperacaoFinanceiraExceprion(string message, Exception ExcecaoInterna)
        {

        }
    }
}
