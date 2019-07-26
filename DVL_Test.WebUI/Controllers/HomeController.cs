using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DVL_Test.Domain.Words_Contoller;
using DVL_Test.Domain.Typing_Test;

namespace DVL_Test.WebUI.Controllers
{
    public class HomeController : Controller
    {
        WordsArea wordsArea = new WordsArea();
        TypingTest typingTest = new TypingTest();
        int IndexOfWord = 0;
        bool wordIsActive = true;

        public ActionResult Index()
        {
            wordsArea.getWords(300);
            typingTest.AddWords(wordsArea.Words);
            return View(typingTest);
        }

        //public ActionResult CheckText(int Key, string Text)
        //{
        //    //if(Key=="32")
        //    //    typingTest.
        //    string s = ((char)Key).ToString();
        //    wordsArea.getWords(300);
        //    typingTest.AddWords(wordsArea.Words);
        //    return View(typingTest);
        //}

    }
}