using System;

namespace Roshambo.Core
{
	public class RoshamboGame
	{
		private Shape? player1Shape = null;
		private Shape? player2Shape = null;

		public void Player1Throws(Shape shape)
		{
			player1Shape = shape;
		}

		public void Player2Throws(Shape shape)
		{
			player2Shape = shape;
		}

		public Outcome GetOutcome()
		{
			if (!player1Shape.HasValue && !player2Shape.HasValue) return Outcome.Tie;
			if (player1Shape.HasValue && !player2Shape.HasValue) return Outcome.Player1Wins;
			if (!player1Shape.HasValue && player2Shape.HasValue) return Outcome.Player2Wins;
			if (player1Shape.Value == player2Shape.Value) return Outcome.Tie;
			if (LeftBeatsRight(player1Shape.Value, player2Shape.Value))
			{
				return Outcome.Player1Wins;
			}
			else
			{
				return Outcome.Player2Wins;
			}
		}

		private bool LeftBeatsRight(Shape left, Shape right)
		{
			if (
				left == Shape.Rock && right == Shape.Scissors ||
				left == Shape.Paper && right == Shape.Rock ||
				left == Shape.Scissors && right == Shape.Paper
				)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
