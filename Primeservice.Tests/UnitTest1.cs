using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primeservice;

namespace Primeservice.Tests
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly Primeservice _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new Primeservice();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
