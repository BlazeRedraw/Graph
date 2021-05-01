namespace Graph
{
    internal class Relationship
    {
        public int tagValue;
        public string[] movies = new string[200];
        public string[] tags = new string[200];
        public Edge edge = new Edge();
        public Node node = new Node();
        public Node origin;
        public Node end;
        public Program program = new Program();

        public Relationship()
        {

        }

        public int Relationships(int i, int j, Node node)
        {
            int z = 0;
            tagValue = 0;

            foreach (string x in node.movies)
            {
                movies[z] = x;
                z++;
            }

            origin = node.Find(movies[i], null);
            end = node.Find(movies[j], null);

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

            return edge.EdgeValue(tagValue);
        }

        public Node Recomended(Node node)
        {
            bool watched = false;
            int z = 0;
            int previousValue = 0;
            tagValue = 0;

            foreach (string x in node.movies)
            {
                movies[z] = x;
                z++;
            }

            tags = Program.GetList();

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

            return end;
        }
    }
}
