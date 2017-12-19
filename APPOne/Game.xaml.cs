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

        public Game()
        {
            InitializeComponent();
            list = QuestionRepository.GetQuestions();
            currentQuestion = list[0];
            LoadQuestion();            

        }

        private void LoadQuestion()
        {
            btnAnswer1.Text = currentQuestion.Answer1;
            btnAnswer2.Text = currentQuestion.Answer2;
            btnAnswer3.Text = currentQuestion.Answer3;
            btnAnswer4.Text = currentQuestion.CorrectAnswer;
        }
    }
}
