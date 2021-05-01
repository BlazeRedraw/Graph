namespace Graph
{
    internal class Graph
    {
        public Node node = new Node();
        public Relationship relationship = new Relationship();

        public Graph()
        {

        }

        public string GetGraph(Node node)
        {
            string text = "Movies  ";

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
                        text += relationship.Relationships(i, j, node);
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

            return text;

        }
    }
}
