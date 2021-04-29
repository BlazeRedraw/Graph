namespace Graph
{
    internal class Node
    {
        public Node list;
        public string label;

        public Node(string name)
        {
            label = name;
        }

        public string Add(string name)
        {
            if (list == null)
            {
                list = new Node(name);
            }

            return "";
        }
    }
}
