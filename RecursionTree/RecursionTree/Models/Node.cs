namespace RecursionTree.Models
{
    public class Node
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Node>? SubNode { get; set; }
    }
}
