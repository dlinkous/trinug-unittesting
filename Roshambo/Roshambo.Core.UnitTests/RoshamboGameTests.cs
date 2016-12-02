using System;
using NUnit;
using NUnit.Framework;
using Roshambo.Core;

namespace Roshambo.Core.UnitTests
{
	public class RoshamboGameTests
	{
		[Test]
		public void WhenNoThrows_GetOutcomeReturnsTie()
		{
			var game = new RoshamboGame();
			var outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Tie, outcome);
		}

		[Test]
		public void WhenOnlyPlayer1Throws_Player1Wins_RegardlessOfShape()
		{
			// Rock
			var game = new RoshamboGame();
			game.Player1Throws(Shape.Rock);
			var outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player1Wins, outcome);
			// Paper
			game = new RoshamboGame();
			game.Player1Throws(Shape.Paper);
			outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player1Wins, outcome);
			// Scissors
			game = new RoshamboGame();
			game.Player1Throws(Shape.Scissors);
			outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player1Wins, outcome);
		}

		[Test]
		public void WhenOnlyPlayer2Throws_Player2Wins_RegardlessOfShape()
		{
			// Rock
			var game = new RoshamboGame();
			game.Player2Throws(Shape.Rock);
			var outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player2Wins, outcome);
			// Paper
			game = new RoshamboGame();
			game.Player2Throws(Shape.Paper);
			outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player2Wins, outcome);
			// Scissors
			game = new RoshamboGame();
			game.Player2Throws(Shape.Scissors);
			outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player2Wins, outcome);
		}

		[Test]
		public void WhenMultipleThrows_OnlyLastIsConsidered()
		{
			var game = new RoshamboGame();
			game.Player1Throws(Shape.Rock);
			game.Player2Throws(Shape.Paper);
			game.Player2Throws(Shape.Scissors);
			var outcome = game.GetOutcome();
			Assert.AreEqual(Outcome.Player1Wins, outcome);
		}

		[Test]
		public void TestAllStandardRules()
		{
			ThrowShapesAndAssertOutcome(Shape.Rock, Shape.Rock, Outcome.Tie);
			ThrowShapesAndAssertOutcome(Shape.Paper, Shape.Paper, Outcome.Tie);
			ThrowShapesAndAssertOutcome(Shape.Scissors, Shape.Scissors, Outcome.Tie);
			ThrowShapesAndAssertOutcome(Shape.Rock, Shape.Scissors, Outcome.Player1Wins);
			ThrowShapesAndAssertOutcome(Shape.Paper, Shape.Rock, Outcome.Player1Wins);
			ThrowShapesAndAssertOutcome(Shape.Scissors, Shape.Paper, Outcome.Player1Wins);
			ThrowShapesAndAssertOutcome(Shape.Rock, Shape.Paper, Outcome.Player2Wins);
			ThrowShapesAndAssertOutcome(Shape.Paper, Shape.Scissors, Outcome.Player2Wins);
			ThrowShapesAndAssertOutcome(Shape.Scissors, Shape.Rock, Outcome.Player2Wins);
		}

		private void ThrowShapesAndAssertOutcome(Shape player1Shape, Shape player2Shape, Outcome expectedOutcome)
		{
			var game = new RoshamboGame();
			game.Player1Throws(player1Shape);
			game.Player2Throws(player2Shape);
			var outcome = game.GetOutcome();
			Assert.AreEqual(expectedOutcome, outcome);
		}
	}
}
