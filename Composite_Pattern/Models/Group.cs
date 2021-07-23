namespace Composite_Pattern.Models
{
    public class Group : Composite.INode
    {
        public string Name { get; set; }
        public System.Collections.Generic.List<Composite.INode> Nodes { get; set; }
        public int Score 
        {
            get 
            {
                int score = 0;

                foreach (var node in Nodes)
                {
                    score += node.Score;
                }

                return score;
            }
            set 
            {
                var indiValue = value / Nodes.Count;

                foreach (var node in Nodes)
                {
                    node.Score = indiValue;
                }
            }
        }
    }
}
