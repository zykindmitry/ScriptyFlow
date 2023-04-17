namespace ScriptyFlow
{
    public interface IParseExpression
    {
        ExpressionTreeNode Parse(string expression, Dictionary<string, IValue> globalVariables);
    }
}
