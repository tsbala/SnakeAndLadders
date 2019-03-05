using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class WinTheGameTests
    {
        private readonly Game _game;

        public WinTheGameTests()
        {
            _game = new Game();
            _game.MoveBy(96);
        }

        
        [Fact]
        public void WhenTokenIsOnPositionHundred_GameIsWon()
        {
            _game.MoveBy(3);
            _game.TokenPosition.Should().Be(100);
            _game.Won.Should().BeTrue();
        }

        [Fact]
        public void WhenNextTokenPositionIsOutOfBounds_ThenTokenPositionIsNotChanged_AndGameIsNotWon()
        {
            _game.MoveBy(4);
            _game.TokenPosition.Should().Be(97);
            _game.Won.Should().BeFalse();
        }
    }
}