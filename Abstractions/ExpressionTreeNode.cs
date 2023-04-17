namespace ScriptyFlow
{
    public class ExpressionTreeNode
    {
        public Guid Id { get; init; }
        public Type ResultType { get; init; }
        public IEnumerable<ExpressionTreeNode> Children { get; init; }
        public Dictionary<Guid, IValue> ExecutionResults { get; init; }
        public Dictionary<string, IValue> Variables { get; init; }
        public string Expression { get; init; }
    }
}
