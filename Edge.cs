namespace Graph
{
    internal class Edge
    {
        public int weight;

        public Edge()
        {

        }

        public int EdgeValue(int tagValue)
        {
            weight = 10;

            return weight - tagValue;
        }
    }
}
