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
            //criamos um mock usando a interface que nos retorna um ano em específico
            //para usarmos no teste...
            var mock = new Mock<IMyCalendarService>(); //-> criamos o mock com a interface abstraída
            mock.Setup(x => x.GetCurrentYear()).Returns(2022); //-> mockamos o valor, no caso 2022 de forma fixa.

            var sut = new IdadeService(mock.Object); //->Criamos a instância do objeto
            
            var result = sut.CalculoIdade(1972); //-> Calulamos a idade com base no ano passado, que seria 1972.

            result.ShouldBe(50);//usamos o ShoulBe com valor 50, para ver se o calculo de idade de uma pessoa
                                //que nasceu em 1972 (parametro do método) terá 50 anos no ano passado (valor que foi mockado)
        }


        [Fact]
        public void PalvaraPalindroma()
        {
            var sut = new IdadeService();
            var result = sut.PalavraPalindroma("Arara");
            Assert.True(result);
        }

        [Fact]
        public void PalvaraNaoPalindroma()
        {
            var sut = new IdadeService();
            var result = sut.PalavraPalindroma("morango");
            Assert.False(result);
        }

        [Fact]
        public void FrasePalindroma()
        {
            var sut = new IdadeService();
            var result = sut.PalavraPalindroma("Roma me tem amor");
            Assert.True(result);
        }

        [Fact]
        public void FraseNaoPalindroma()
        {
            var sut = new IdadeService();
            var result = sut.PalavraPalindroma("Eu sou feliz");
            Assert.False(result);
        }
    }
}