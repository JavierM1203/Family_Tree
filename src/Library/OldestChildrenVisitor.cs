namespace Library;

public class OldestChildVisitor : Visitor<Person>
{
    public Person oldestChild = new Person("Reference", 0);

    public override void Visit(Node<Person> node)
    {
        if(node.Children.Count != 0)
        {
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        } 
        else
        {
            oldestChild = (node.Type.age > oldestChild.age) ? node.Type : oldestChild;
        }
    }
}