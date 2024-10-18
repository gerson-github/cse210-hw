using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello  World!");

        //definindo o template
        Template templateA = new Template("TemplateA", new List<string>
        {
            "Field1", "Field2", "Field3", "Field4", "Field5", 
            "Field6", "Field7", "Field8", "Field9", "Field10"
        });

        Template templateB = new Template("TemplateB", new List<string>
        {
            "Field1", "Field2", "Field3", "Field4", "Field5"
        });

        //cria um contrato e designa um template
        Contract contract = new Contract {Id = "1234"}        ;
        contract.SetTemplate(templateA);

        //addciona valores para campos especificos
        contract.AddField("Field1", "value1");
        contract.AddField("Field2", "value2");

        Console.WriteLine("Field1: " + contract.GetField("Field1")); // Outputs: Value1
        contract.PrintAllFields();

    // Apply TemplateB with 5 fields
        Contract contract2 = new Contract { Id = "5678" };
        contract2.SetTemplate(templateB);




    }
}