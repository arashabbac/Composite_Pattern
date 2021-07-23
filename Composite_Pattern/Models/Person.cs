namespace Composite_Pattern.Models
{
    public class Person : Composite.INode
    {
        public Person() : base()
        {
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
}
