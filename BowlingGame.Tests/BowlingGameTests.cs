using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {
        private Game _game;

        [SetUp]
        public void Init()
        {
            _game = new Game();
        }

        [Test]
        public void Should_GutterGame_ScoresZero()
        {
            _game.Roll(0);
            // Assert ?
        }

    }
}
