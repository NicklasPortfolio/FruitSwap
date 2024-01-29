using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FruitSwap
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

        Random rand = new Random();

        Dictionary<string, string> fruits = new Dictionary<string, string>
		{
			{ "🍓", "Strawberry" },
			{ "🍇", "Grape" },
			{ "🍉", "Watermelon" },
			{ "🍊", "Orange" },
			{ "🍋", "Lemon" },
			{ "🍌", "Banana" },
			{ "🍍", "Pineapple" },
			{ "🍏", "Apple" },
			{ "🍐", "Pear" },
			{ "🍑", "Peach" },
			{ "🍒", "Cherry" }
		};

        HashSet<string> fruitSet = new HashSet<string>();

        List<Button> buttons;

		string requestedFruit;
		public int score;
		int timeLeft;

		private void btnStart_Click(object sender, EventArgs e)
		{
			timeLeft = 3;
			score = 0;
			gameTimer.Start();

            buttons = new List<Button>()
			{
				btnTop,
				btnTopleft,
				btnTopright,
				btnBottomleft,
				btnBottomright
			};

			RandomizeButtons();
		}

        private void btnFruit_Click(object sender, EventArgs e)
        {
			Button clicked = sender as Button;

			if (clicked.Text == requestedFruit)
			{
				RandomizeButtons();
				score++;
				timeLeft = 3;
				lblTime.Text = timeLeft.ToString();
			}
			else
			{
				GameOver();
			}

			lblScore.Text = score.ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            lblTime.Text = timeLeft.ToString();

			if (timeLeft <= 0)
			{
				GameOver();
			}
        }

		// Using a HashSet to ensure selection of 5 unique random fruits each time
        private void RandomizeButtons()
		{
			int randomIndex;
			fruitSet.Clear();

			do
			{
				randomIndex = rand.Next(fruits.Count());
				fruitSet.Add(fruits.ElementAt(randomIndex).Key);

			} while (fruitSet.Count < 5);

			for (int i = 0; i < 5; i++)
			{
				buttons[i].Text = fruitSet.ElementAt(i);
			}

            randomIndex = rand.Next(fruitSet.Count);
            requestedFruit = fruitSet.ElementAt(randomIndex);
            lblFruit.Text = fruits[requestedFruit];
        }

		private void GameOver()
		{
			gameTimer.Stop();
            Highscores hsForm = new Highscores(this);
            hsForm.Show();
		}
    }
}
