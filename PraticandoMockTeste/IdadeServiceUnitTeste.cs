using Moq;
using PraticandoMock;
using Shouldly;

namespace PraticandoMockTeste
{
    public class IdadeServiceUnitTeste 
    {
        [Fact]
        public void CalculoIdade_AnoValidoIdadeCorreta()
        {
            //criamos um mock usando a interface que nos retorna um ano em espec�fico
            //para usarmos no teste...
            var mock = new Mock<IMyCalendarService>(); //-> criamos o mock com a interface abstra�da
            mock.Setup(x => x.GetCurrentYear()).Returns(2022); //-> mockamos o valor, no caso 2022 de forma fixa.

            var sut = new IdadeService(mock.Object); //->Criamos a inst�ncia do objeto
            
            var result = sut.CalculoIdade(1972); //-> Calulamos a idade com base no ano passado, que seria 1972.

            result.ShouldBe(50);//usamos o ShoulBe com valor 50, para ver se o calculo de idade de uma pessoa
                                //que nasceu em 1972 (parametro do m�todo) ter� 50 anos no ano passado (valor que foi mockado)
        }
    }
}