using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoMock
{
    public  interface IMyCalendarService
    {
        //método abstraído que retornará o valor do ano atual, no caso este valor está fixo na classe
        //de testes para que o teste sempre funcione.
        public int GetCurrentYear();
    }
}
