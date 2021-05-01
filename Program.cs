using System;
using System.Collections.Generic;

namespace Graph
{
    internal class Program
    {
        public static Node node = new Node();
        public static Graph graph = new Graph();
        public static List<string> tagList = new List<string>();

        private static void Main(string[] args)
        {
            //Graph test

            string name;
            string[] tags = new string[200];

            name = "Avengers: Endgame";
            tags[0] = "Action";
            tags[1] = "Sci-Fi";
            tags[2] = "Disney";
            tags[3] = "Marvel";
            tags[4] = "PG-13";
            tags[5] = "Robert Downey Jr.";

            Console.WriteLine(node.Add(name, tags, null));

            name = "How to Train Your Dragon";
            tags[0] = "Animation";
            tags[1] = "Action";
            tags[2] = "Adventure";
            tags[3] = "Dreamworks";
            tags[4] = "PG";
            tags[5] = "T.J. Miller";

            Console.WriteLine(node.Add(name, tags, null));

            name = "Ice Age: A Mammoth Christmas";
            tags[0] = "Animation";
            tags[1] = "Adventure";
            tags[2] = "Comedy";
            tags[3] = "Blue Skies";
            tags[4] = "PG";
            tags[5] = "T.J. Miller";

            Console.WriteLine(node.Add(name, tags, null));
            Console.WriteLine(graph.GetGraph());
        }

        public void Watched(string tag)
        {
            tagList.Add(tag);
        }

        public static string[] GetList()
        {
            int i = 0;
            string[] tags = new string[200];

            foreach (string j in tagList)
            {
                tags[i] = j;
                i++;
            }
            return tags;
        }

        //Graph hint

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

        /*------------------------------------------------------------------------------------------------------------------------*/

        //Graph Goal

        /*string text = "Movies  ";
        Relationship relationship = new Relationship();

        for (int i = 0; i < node.movies.Count; i++)
        {
            text += " " + (i + 1) + " ";
        }

        text += "\n";

        for (int i = 0; i < node.movies.Count; i++)
        {
            text += (i + 1) + "      - ";

            for (int j = 0; j < node.movies.Count; j++)
            {
                if (i == j)
                {
                    text += 0;
                }
                else
                {
                    //text += relationship.Relationships(i, j);
                }

                if (j < node.movies.Count - 1)
                {
                    text += ", ";
                }
                else
                {
                    text += ".\n";
                }
            }
        }

        Console.WriteLine(text);*/

        /*------------------------------------------------------------------------------------------------------------------------*/

        //Node test

        /*string name;
            string[] tags = new string[100];

            name = "Avengers: Endgame";
            tags[0] = "Action";
            tags[1] = "Sci-Fi";
            tags[2] = "Marvel";
            tags[3] = "PG-13";
            tags[4] = "Robert Downey Jr.";

            Console.WriteLine(node.Search(name, null));
            Console.WriteLine(node.Remove(name, null));

            Console.WriteLine(node.Add(name, tags, null));

            tags[1] = "Disney";

            Console.WriteLine(node.Add(name, tags, null));

            name = "How to Train Your Dragon";
            tags[0] = "Animation";
            tags[1] = "Action";
            tags[2] = "Adventure";
            tags[3] = "Dreamworks";
            tags[4] = "PG";
            tags[5] = "T.J. Miller";

            Console.WriteLine(node.Add(name, tags, null));
            Console.WriteLine(node.Remove(name, null));

            name = "Ice Age: A Mammoth Christmas";
            tags[0] = "Animation";
            tags[1] = "Adventure";
            tags[2] = "Comedy";
            tags[3] = "Blue Skies";
            tags[4] = "PG";
            tags[5] = "T.J. Miller";

            Console.WriteLine(node.Add(name, tags, null));

            Console.WriteLine(node.Search("Avengers: Endgame", null));
            Console.WriteLine(node.Search("How to Train Your Dragon", null));
            Console.WriteLine(node.Search("Ice Age: A Mammoth Christmas", null));
            Console.WriteLine(node.Watch("Avengers: Endgame", null));

            text = string.Join(", ", tagList);

            if (text != "")
            {
                text = text.TrimEnd(' ');
                text = text.TrimEnd(',') + ".\n";
            }

            Console.WriteLine("Your tags are: " + text);
            Console.Write("The movie list is: ");
            text = "";

            text = string.Join(", ", node.movies);

            text = text.TrimEnd(' ');
            text = text.TrimEnd(',') + ".\n";
            Console.WriteLine(text);*/

        /*------------------------------------------------------------------------------------------------------------------------*/

        //Relationship Goal

        /*int tagValue = 0;
        int z = 0;
        string[] movies = new string[100];
        Edge edge = new Edge();

        foreach (string x in node.movies)
        {
            movies[z] = x;
            z++;
        }

        for (int i = 0; i < movies.Length; i++)
        {
            if (movies[i] != null)
            {
                Console.WriteLine(movies[i]);
            }
        }

        Node origin = node.Find(movies[1], null);
        Node end = node.Find(movies[2], null);

        foreach (string x in origin.list)
        {
            foreach (string y in end.list)
            {
                if (x == y)
                {
                    tagValue++;
                }
            }
        }

        Console.WriteLine(edge.EdgeValue(tagValue));*/

        /*------------------------------------------------------------------------------------------------------------------------*/

        //Reccomended Goals

        /*Console.WriteLine(node.Watch("How to Train Your Dragon", null));

        bool watched = false;
        int z = 0;
        int previousValue = 0;
        int tagValue = 0;
        string[] movies = new string[200];
        Node origin;
        Node end;

        foreach (string x in node.movies)
        {
            movies[z] = x;
            z++;
        }

        tags = GetList();

        for (int i = 0; i < movies.Length; i++)
        {
            if (movies[i] != null)
            {
                for (int x = 0; x < tags.Length; x++)
                {
                    if (movies[i] == tags[x])
                    {
                        watched = true;
                    }
                }

                if (!watched)
                {
                    origin = node.Find(movies[i], null);

                    for (int j = 0; j < tags.Length; j++)
                    {
                        foreach (string y in origin.list)
                        {
                            if (tags[j] == y)
                            {
                                tagValue++;
                            }
                        }
                    }

                    if (tagValue > previousValue)
                    {
                        previousValue = tagValue;
                        end = origin;
                    }
                }
                watched = false;
                tagValue = 0;
            }
        }

        Console.WriteLine(previousValue);*/

        /*------------------------------------------------------------------------------------------------------------------------*/

        //Tags test

        /*Tags tags = new Tags();

        Console.WriteLine(tags.Search("Cast"));

        Console.WriteLine(tags.Add("Cast", "Tim") + tags.Add("Cast", "Tim") + tags.Add("Cast", "Jhon") + tags.Add("Cast", "Amber"));
        Console.WriteLine(tags.Remove("Cast", "Tim"));

        Console.WriteLine(tags.Search("Cast"));*/

        /*------------------------------------------------------------------------------------------------------------------------*/
    }
}