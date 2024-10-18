public class Template
{
    public string Name {get;set;}
    public List<string> Fields {get; private set;}
    public Template(string name, List<string> fields)
    {
        Name = name;
        Fields = fields;
    }
}