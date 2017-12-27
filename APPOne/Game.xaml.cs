using APPOne.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace APPOne
{
    public partial class Game : ContentPage
    {
        public List<Question> list;
        public Question currentQuestion;
        public int currentNumber = 0;
        public int score = 0;

        public Game()
        {
            InitializeComponent();
            list = QuestionRepository.GetQuestions();
            currentQuestion = list[currentNumber];
            SetScoreText();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            btnAnswer1.ClearValue(Button.BackgroundColorProperty);
            btnAnswer2.ClearValue(Button.BackgroundColorProperty);
            btnAnswer3.ClearValue(Button.BackgroundColorProperty);
            btnAnswer4.ClearValue(Button.BackgroundColorProperty);

            lblQuestion.Text = currentQuestion.QuestionText;
            btnAnswer1.Text = currentQuestion.Answer1;
            btnAnswer2.Text = currentQuestion.Answer2;
            btnAnswer3.Text = currentQuestion.Answer3;
            btnAnswer4.Text = currentQuestion.CorrectAnswer;
        }

        void answer4_handled(object sender, System.EventArgs e)
        {
            CheckAnswer((Button)sender);
        }

        void nextQuestion_handled(object sender, System.EventArgs e)
        {
            btnNextQuestion.IsVisible = false;
            LoadQuestion();
        }

        private void CheckAnswer(Button button)
        {
            //TODO : async displayalert, goto another screen when finished
            if (button.Text == currentQuestion.CorrectAnswer)
            {
                score++;
                SetScoreText();
                button.BackgroundColor = Color.Green;
                //DisplayAlert("Correct", "Correct answer", "Ok");
            }
            else
            {
                button.BackgroundColor = Color.Red;
                //DisplayAlert("Wrong", "Wrong answer", "Ok");
            }

            currentNumber++;
            if (currentNumber < list.Count)
            {
                currentQuestion = list[currentNumber];
                btnNextQuestion.IsVisible = true;
            }
            else
            {
                DisplayAlert("Done", "all answerd", "Ok");
            }
        }

        private void SetScoreText()
        {
            lblScore.Text = "Score " + score + "/" + list.Count;
        }
    }
}
