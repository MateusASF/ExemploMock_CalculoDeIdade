using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoMock
{
    public interface IIdadeService
    {
        //método abstraído para calcular a Idade na IdadeService
        public int CalculoIdade(int ano);

        public bool PalavraPalindroma(string palavra);
    }
}
