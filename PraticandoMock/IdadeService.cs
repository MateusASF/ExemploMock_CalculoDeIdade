using static System.Net.Mime.MediaTypeNames;

namespace PraticandoMock
{
    public class IdadeService : IIdadeService //Usamos a interface para realizar o calculo da idade
    {
        //crio uma dependência do MyCalendar que retorna o ano corrente.
        //devemos fazer isso pois o ano atual por exemplo ele não é controlável
        //por esse motivo "mokamos" para poder manipularmos depois
        private readonly IMyCalendarService _myCalendarService;
        public IdadeService(IMyCalendarService myCalendarService)
        {
            _myCalendarService = myCalendarService;
        }

        public IdadeService()
        {

        }

        //implementação da interface que traz o ano atual e subtrai pelo ano recebido
        public int CalculoIdade(int ano)
        {
            return _myCalendarService.GetCurrentYear() - ano;
        }


        public bool PalavraPalindroma(string palavraOriginal)
        {
            palavraOriginal = palavraOriginal.Trim().Replace(" ", "").Replace(",", "").ToLower();
            char[] charArray = palavraOriginal.ToCharArray();
            
            Array.Reverse(charArray);
            var palavraInvertida =  new string(charArray);

            if (palavraInvertida == palavraOriginal)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}