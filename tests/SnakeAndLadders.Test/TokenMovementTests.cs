using System;
using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class TokenMovementTests
    {
        [Fact]
        public void WhenGameStarts_ThenTokenIsOnSquareOne()
        {
            var game = new Game();
            game.TokenPosition.Should().Be(1);
        }
    }
}