namespace VisitorPattern
{
    public abstract class Shape : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
