using System.Collections.Generic;

namespace Graph
{
    internal class Node
    {
        public string text;
        public Node movieList;
        public Node nextNode;
        public List<string> movies = new List<string>();
        public List<string> list = new List<string>();
        public Program program = new Program();

        internal Node MovieList { get => movieList; set => movieList = value; }

        internal Node NextNode { get => nextNode; set => nextNode = value; }

        public Node()
        {

        }

        public Node(string name, string[] tags)
        {
            list.Add(name.Trim());

            for (int i = 0; i < tags.Length; i++)
            {
                if (!list.Contains(tags[i]) && tags[i] != null)
                {
                    list.Add(tags[i].Trim());
                }
            }
        }

        public Node Find(string name, Node node)
        {
            name = name.Trim();

            if (node == null)
            {
                node = movieList;
            }

            if (node == null)
            {
                return null;
            }

            if (node.list.Contains(name))
            {
                return node;
            }
            else
            {
                if (node.nextNode != null)
                {
                    return Find(name, node.nextNode);
                }
            }

            return null;
        }

        public string Search(string name, Node node)
        {
            name.Trim();
            node = Find(name, node);

            if (node != null)
            {
                text = string.Join(", ", node.list);

                if (text != "")
                {
                    text = text.TrimEnd(' ');
                    text = text.TrimEnd(',') + ".\n";
                    return text;
                }
            }

            return name + " was not found.\n";
        }

        public string Watch(string name, Node node)
        {
            name = name.Trim();

            node = Find(name, node);

            if (node != null)
            {
                foreach (string tag in node.list)
                {
                    program.Watched(tag);
                }
                return name + " has been watched.\n";
            }

            return name + " was not found.\n";
        }

        public string Add(string name, string[] tags, Node node)
        {
            name = name.Trim();

            if (!movies.Contains(name))
            {
                movies.Add(name);
            }

            if (node == null)
            {
                node = movieList;
            }

            if (node == null)
            {
                movieList = new Node(name, tags);
            }
            else
            {
                if (node.list.Contains(name))
                {
                    for (int j = 0; j < tags.Length; j++)
                    {
                        if (!node.list.Contains(tags[j]) && tags[j] != null)
                        {
                            node.list.Add(tags[j].Trim());
                        }
                    }

                    return name + " already exists and was updated if needed.\n";
                }
                else
                {
                    if (node.nextNode == null)
                    {
                        node.nextNode = new Node(name, tags);
                    }
                    else
                    {
                        return Add(name, tags, node.nextNode);
                    }
                }
            }

            return name + " was successfully added.\n";
        }

        public string Remove(string name, Node node)
        {
            name = name.Trim();

            if (movies.Contains(name))
            {
                movies.Remove(name);
            }

            if (node == null)
            {
                node = movieList;
            }

            if (node == null)
            {
                return "There are no movies.\n";
            }

            if (node.list.Contains(name))
            {
                movieList = node.nextNode;
                return "Succesfully removed '" + name + "'.\n";
            }
            else
            {
                if (node.nextNode != null)
                {
                    if (node.nextNode.list.Contains(name))
                    {
                        node.nextNode = node.nextNode.nextNode;
                        return "'" + name + "' was succsessfully removed.\n";
                    }
                    else
                    {
                        return Remove(name, node.nextNode);
                    }
                }
            }

            return "'" + name + "' doesn't exist.\n";
        }
    }
}
