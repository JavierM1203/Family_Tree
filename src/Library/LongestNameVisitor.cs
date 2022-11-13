namespace Library;

public class LongestNameVisitor : Visitor<Person>
{
    public Person personWithLongestName = new Person("", 0);

    public override void Visit(Node<Person> node)
    {
        personWithLongestName = (node.Type.name.Length > personWithLongestName.name.Length) ? node.Type : personWithLongestName;

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}