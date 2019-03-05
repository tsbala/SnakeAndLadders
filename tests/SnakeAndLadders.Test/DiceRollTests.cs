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
        
        [Fact]
        public void WhenPlayerRollsDice_ThenPositionInGameShouldMoveByDiceRoll()
        {
            var diceRoll =_dice.Roll();
            var game = new Game();
            var currentPosition = game.TokenPosition;
            game.MoveBy(diceRoll);
            game.TokenPosition.Should().Be(currentPosition + diceRoll);
        }
    }
}