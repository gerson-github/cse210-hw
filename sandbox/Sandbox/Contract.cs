using System;
using System.Collections.Generic;

public class Contract 
{
    public string Id {get; set;}
    public Dictionary<string, object> Fields {get; private set;} = new Dictionary<string, object>();

    //metodo para adicionar um campo dinamicamente a classe contrato
    public void AddField(string key, object value)
    {
        if (!@Fields.ContainsKey(key))
        {
            Fields.Add(key,value);
        } else
        {
            Fields[key] = value; //atualiza um campo ja existente
        }
    }

    public void RemoveField(string key)
    {
        if (Fields.ContainsKey(key))
        {
            Fields.Remove(key);
        }
    }
    //aplica o template dinamicamente addicionando os campos
    public void SetTemplate(Template template) {
        foreach(var field in template.Fields)
        {
            AddField(field,null); //adiciona os campos com o valor nulo como default
        }

    }

 // Method to get the value of a field
    public object GetField(string key)
    {
        if (Fields.ContainsKey(key))
        {
            return Fields[key];
        }
        return null;
    }

    public void PrintAllFields()
    {
        Console.WriteLine("Contract fields:");
        foreach(var field in Fields)
        {
            Console.WriteLine($"{field.Key}: {field.Value}");
        }
    }


}