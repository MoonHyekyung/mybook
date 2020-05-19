using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Mybook
        {
            public string bookname;
            public string date;
            public string author;
            public string publisher;
            public string publisherCompany;
            public string alleditor;
            public string planner;
            public string editor;
            public string designer;
        }
        static void Main(string[] args)
        {
            Mybook book = new Mybook() { bookname = "PHP 프로그래밍 입문",  date = "2013년 5월 20일", 
                author = "황재호", publisher = "김태헌", publisherCompany = "한빛아카데미(주)", 
                alleditor = "김현용", planner = "김이화", editor = "김이화", designer = "여동일"};
        }
    }
}
