using System;
using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class TokenMovementTests
    {
        private Game _game;

        public TokenMovementTests()
        {
            _game = new Game();
        }
        
        [Fact]
        public void WhenGameStarts_ThenTokenIsOnSquareOne()
        {
            _game.TokenPosition.Should().Be(1);
        }

        [Fact]
        public void GivenTokenIsOnSquareOne_WhenTokenIsMovedByThreeSpaces_ThenTokeIsOnSquareFour()
        {
            _game.MoveBy(3);
            _game.TokenPosition.Should().Be(4);
        }
    }
}