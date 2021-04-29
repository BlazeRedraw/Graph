using System;

namespace Graph
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*string[] movies = new string[10];
            int[,] graph = new int[10, 10];

            movies[0] = "Avengers: Endgame                        ";
            //Action, Sci-Fi, Disney, Marvel, PG-13, Robert Downey Jr.

            movies[1] = "How to Train Your Dragon                 ";
            //Animation, Action, Adventure, Dreamworks, PG, T.J. Miller

            movies[2] = "Ice Age: A Mammoth Christmas             ";
            //Animation, Adventure, Comedy, Blue Skies, PG, T.J. Miller

            movies[3] = "Men in Black                             ";
            //Action, Adventure, Comedy, Sony, PG-13, Eddie Murphy

            movies[4] = "Robots                                   ";
            //Animation, Family, Comedy, Blue Sky, PG, Ewan McGregor

            movies[5] = "Sherlock Holmes                          ";
            //Action, Adventure, Mystery, Warner Brothers, PG-13, Robert Downey Jr.

            movies[6] = "Shrek 2                                  ";
            //Animation, Family, Comedy, Dreamworks, PG, Eddie Murphy

            movies[7] = "Spider Man (2002)                        ";
            //Action, Fantasy, Sony, Marvel, PG-13, J.K. Simmons

            movies[8] = "Star Wars: Episode I – The Phantom Menace";
            //Action, Adventure, Fantasy, Lucas Arts, PG Ewan McGregor

            movies[9] = "Zootopia                                 ";
            //Animation, Family, Adventure, Disney, PG, J.K. Simmons

            Console.Write("Movies                                     ");
            Random generateValue = new Random();

            for (int i = 0; i < movies.Length; i++)
            {
                Console.Write(" " + (i + 1) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < movies.Length; i++)
            {
                Console.Write(movies[i] + " - ");

                for (int j = 0; j < movies.Length; j++)
                {
                    if (i == j)
                    {
                        graph[i, j] = 0;
                    }
                    else
                    {
                        graph[i, j] = generateValue.Next(0, 10);
                    }
                    Console.Write(graph[i, j]);

                    if (j < movies.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }*/

            Tags tags = new Tags();

            Console.WriteLine(tags.GetList("Cast"));

            Console.WriteLine(tags.Add("Cast", "Tim") + tags.Add("Cast", "Tim") + tags.Add("Cast", "Jhon") + tags.Add("Cast", "Amber"));
            Console.WriteLine(tags.Remove("Cast", "Tim"));

            Console.WriteLine(tags.GetList("Cast"));

        }
    }
}
