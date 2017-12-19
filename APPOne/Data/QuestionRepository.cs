using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOne.Data
{
   public static class QuestionRepository
    {
        public static List<Question> GetQuestions()
        {
            var list = new List<Question>() {
                new Question
                {
                    ID =0,
                    QuestionText = "if you are going to create a menu which surrounding HTML tag should you use",
                    Answer1 = "<menu>",
                    Answer2 ="<section>",
                    Answer3="<div id='menu'>",
                    CorrectAnswer="<nav>"            
                }
            };

            return list;            
        }
    }
}
