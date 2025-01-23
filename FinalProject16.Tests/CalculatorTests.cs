namespace FinalProject16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(100, 50) == 150);
        }
        
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 50) == 50);
        }
        
        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(100, 50) == 5000);
        }

        [Test]
        public void DivisionMustReturnCorrectVaiue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(100, 50) == 2);
        }
    }
}