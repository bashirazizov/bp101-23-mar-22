using System;
using vehiclesFb.ModelF;
using vehiclesFb.ModelV;

namespace vehiclesFb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW
            //Car c1 = new Car("BMW","F10",2016,3000);
            //c1.FuelAmount = 60;
            //c1.FuelUsedPerKm = 0.1;
            //c1.TurnOn();
            //c1.Go(500);
            //c1.Go(200);
            //c1.TurnOff();

            //Console.WriteLine(c1.GetDetailedInfo());

            //Comment c1 = new Comment();
            //c1.Text = "C1Salam";

            //Comment c2 = new Comment();
            //c2.Text = "C2Salam";

            //Comment c3 = new Comment();
            //c3.Text = "C3Salam";

            //Post p1 = new Post();
            //p1.Text = "Salam olsun yaxsilara!";
            //p1.LikeCount = 100;
            //p1.CommentCount = 2;
            //p1.Comments = new Comment[] { c1, c2 };

            //Post p2 = new Post();
            //p2.Text = "Salam olsun pislere!";
            //p2.LikeCount = 50;
            //p2.CommentCount = 1;
            //p2.Comments = new Comment[] { c3 };

            ////for (int i = 0; i < p1.Comments.Length; i++)
            ////{
            ////    Console.WriteLine(p1.Comments[i].Text);
            ////}

            //User user = new User("Mamed", "Aliyev", "mamed@code.edu.az", false);
            //user.Posts = new Post[] { p1, p2 };


            //Console.WriteLine(user.Posts[0].Comments[0].Text);

            //for (int i = 0; i < user.Posts.Length; i++)
            //{
            //    Console.WriteLine(user.Posts[i].Text);
            //    for (int j = 0; j < user.Posts[i].Comments.Length; j++)
            //    {
            //        Console.WriteLine("->"+user.Posts[i].Comments[j].Text);
            //    }
            //}
            #endregion

            string st1 = " ";
            string st2 = "!!!!!!!!!!!!!!!!!!!!!!salam!!!!!!!";
            string names = "mamed, isa, rasim, agagul";

            //Console.WriteLine(st1.StartsWith("Mamed"));
            //Console.WriteLine(st1.EndsWith("yaxsi oglandir ozune gore."));

            //Console.WriteLine(st1.ToUpper());
            //Console.WriteLine(st1.ToLower());

            //Console.WriteLine(String.Concat(st1, st2));

            //Console.WriteLine(st2.LastIndexOf('a'));

            //Console.WriteLine(st1.Replace("med",""));
            //Console.WriteLine(st2.Replace('a','j'));

            //Console.WriteLine(st2.Length);

            //Console.WriteLine(st2);
            //Console.WriteLine(st2.Trim('!'));


            //string[] namesAsArr = names.Split(", ");
            //for (int i = 0; i < namesAsArr.Length; i++)
            //{
            //    Console.WriteLine(namesAsArr[i]);
            //}

            //char[] chars = st1.ToCharArray();

            Console.WriteLine(string.IsNullOrEmpty(st1));
        }
    }
}
