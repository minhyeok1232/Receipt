using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public enum PaymentType
{
    카드, 현금, enumMax
}

public class Coffee
{
    public string Name { get; private set; }
    public int Price   { get; private set; }
    public int Cost    { get; private set; }

    public Coffee(string name, int price, int cost)
    {
        Name  = name;
        Price = price;
        Cost  = cost;
    }
}

public class Payment
{
    public PaymentType Type { get; set; }

    public Payment(PaymentType type)
    {
        Type = type;
    }

    public override string ToString()
    {
        return Type.ToString();
    }
}

public class GOVR : MonoBehaviour
{
    // O(1)
    private Dictionary<string, Coffee> coffees = new Dictionary<string, Coffee>();
    
    private void Awake()
    {
        LoadCoffess();
    }
    
    private void LoadCoffess()
    {
        TextAsset jsonText = Resources.Load<TextAsset>("coffees");
        if (jsonText == null)
        {
            return;
        }

        List<Coffee> coffeeList = JsonConvert.DeserializeObject<List<Coffee>>(jsonText.text);
        foreach (var coffee in coffeeList)
        {
            coffees[coffee.Name] = coffee;
        }
    }

    public Coffee GetRandomCoffee()
    {
        List<string> coffeeNames = new List<string>(coffees.Keys);
        string randomName = coffeeNames[Random.Range(0, coffeeNames.Count)];
        return coffees[randomName];
    }

    public Payment GetRandomPaymentType()
    {
        int index = (int)PaymentType.enumMax;
        int randomIndex = Random.Range(0, index);
        PaymentType type = (PaymentType)randomIndex;
        return new Payment(type);
    }
}
