
namespace StrategyPattern.Test
{
    public class Tests
    {
        
        [Test]
        public void StrategyA()
        {
            // Arrange
            var strategy = new SortAscendingOrder();
            var input = new List<string> { "d", "b", "e", "a", "c" };

            // Act
            var result = strategy.DoAlgorithm(new List<string>(input)) as List<string>;

            // Assert
            var expected = new List<string> { "a", "b", "c", "d", "e" };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StrategyB()
        {
            var strategy = new SortDescendingOrder();
            var input = new List<string> { "d", "b", "e", "a", "c" };
            var result = strategy.DoAlgorithm(input) as List<string>;
            var expected = new List<string> { "e", "d", "c", "b", "a" };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void EmptySort()
        {
            var strategyA = new SortAscendingOrder();
            var strategyB = new SortDescendingOrder();
            var input = new List<string>();

            var resultA = strategyA.DoAlgorithm(input) as List<string>;
            var resultB = strategyB.DoAlgorithm(input) as List<string>;

            Assert.That(resultA, Is.Empty);
            Assert.That(resultB, Is.Empty);
        }

        [Test]
        public void SingleSort()
        {
            var input = new List<string> { "x" };

            var resultA = new SortAscendingOrder().DoAlgorithm(input) as List<string>;
            var resultB = new SortDescendingOrder().DoAlgorithm(input) as List<string>;

            var expected = new List<string> { "x" };

            Assert.That(resultA, Is.EqualTo(expected));
            Assert.That(resultB, Is.EqualTo(expected));
        }

        [Test]
        public void AlreadySort()
        {
            var inputA = new List<string> { "a", "b", "c", "d" };
            var inputB = new List<string> { "a", "b", "c", "d" };

            var resultA = new SortAscendingOrder().DoAlgorithm(inputA) as List<string>;
            var resultB = new SortDescendingOrder().DoAlgorithm(inputB) as List<string>;

            var expectedA = new List<string> { "a", "b", "c", "d" };
            var expectedB = new List<string> { "d", "c", "b", "a" };

            Assert.That(resultA, Is.EqualTo(expectedA));
            Assert.That(resultB, Is.EqualTo(expectedB));
        }

        [Test]
        public void DuplicateSort()
        {
            var inputA = new List<string> { "a", "c", "b", "a", "b" };
            var inputB = new List<string> { "a", "c", "b", "a", "b" };

            var resultA = new SortAscendingOrder().DoAlgorithm(inputA) as List<string>;
            var resultB = new SortDescendingOrder().DoAlgorithm(inputB) as List<string>;

            var expectedA = new List<string> { "a", "a", "b", "b", "c" };
            var expectedB = new List<string> { "c", "b", "b", "a", "a" };

            Assert.That(resultA, Is.EqualTo(expectedA));
            Assert.That(resultB, Is.EqualTo(expectedB));
        }
    }
}
