namespace Library;

public class AgeVisitor : Visitor<Person>
{
    public int sum {get; private set;}
    public override void Visit(Node<Person> node)
    {
        this.sum += node.Type.age;

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}