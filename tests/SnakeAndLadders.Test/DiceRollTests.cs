using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class DiceRollTests
    {
        private readonly Dice _dice;

        public DiceRollTests()
        {
            _dice = new Dice();
        }
        
        [Fact]
        public void WhenPlayerRollsDice_ThenResultShouldBeBetweenOneAndSix()
        {
            _dice.Roll().Should().BeInRange(1, 6);
        }        
    }
}