using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roshambo.Core;

namespace Roshambo.WOPR
{
	public partial class Form1 : Form
	{
		private const int IntroSpeed = 2;
		private const int Iterations = 1000;
		private const int WaitStart = 1000;
		private const int MinimumWait = 1;
		private const double WaitMultiplier = 0.95;

		private Random random = new Random();

		private int ScoreUSA = 0;
		private int ScoreUSSR = 0;
		private int ScoreTIE = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Show();
			Intro();
			Start();
			Stop();
		}

		private void Intro()
		{
			Sleep(IntroSpeed);
			USA.Visible = true;
			Sleep(IntroSpeed);
			USSR.Visible = true;
			Sleep(IntroSpeed);
			TIE.Visible = true;
			Sleep(IntroSpeed);
		}

		private void Start()
		{
			var wait = WaitStart;
			for (var i = 0; i < Iterations; i++)
			{
				Wait(wait);
				PlayOneRound();
				if (wait > MinimumWait)
				{
					wait = (int)(wait * WaitMultiplier);
				}
				else
				{
					wait = MinimumWait;
				}
			}
		}

		private void Stop()
		{
			DotUSA.Visible = false;
			DotUSSR.Visible = false;
			DotUSA.Refresh();
			DotUSSR.Refresh();
		}

		private void Sleep(int seconds)
		{
			this.Refresh();
			Thread.Sleep(seconds * 1000);
			this.Refresh();
		}

		private void Wait(int milliseconds)
		{
			Thread.Sleep(milliseconds);
		}

		private void PlayOneRound()
		{
			DotUSA.Visible = false;
			DotUSSR.Visible = false;
			var player1Shape = GetRandomShape();
			var player2Shape = GetRandomShape();
			var game = new RoshamboGame();
			game.Player1Throws(player1Shape);
			game.Player2Throws(player2Shape);
			var outcome = game.GetOutcome();
			switch (outcome)
			{
				case Outcome.Player1Wins:
					ScoreUSA++;
					USA.Text = ScoreUSA.ToString();
					USA.Refresh();
					DotUSSR.Visible = true;
					break;
				case Outcome.Player2Wins:
					ScoreUSSR++;
					USSR.Text = ScoreUSSR.ToString();
					USSR.Refresh();
					DotUSA.Visible = true;
					break;
				case Outcome.Tie:
					ScoreTIE++;
					TIE.Text = ScoreTIE.ToString();
					TIE.Refresh();
					DotUSA.Visible = true;
					DotUSSR.Visible = true;
					break;
				default:
					throw new NotSupportedException();
			}
			DotUSA.Refresh();
			DotUSSR.Refresh();
		}

		private Shape GetRandomShape()
		{
			var randomNumber = random.Next(3);
			switch (randomNumber)
			{
				case 0:
					return Shape.Rock;
				case 1:
					return Shape.Paper;
				case 2:
					return Shape.Scissors;
				default:
					throw new NotSupportedException();
			}
		}
	}
}
