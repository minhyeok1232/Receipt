using System.Collections.Generic;
using UnityEngine;

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
    public PaymentType Type { get; private set; }

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
        coffees.Add("아메리카노", new Coffee("아메리카노", 1500, 500));
        coffees.Add("카푸치노",  new Coffee("카푸치노", 2700, 1000));
        coffees.Add("카페모카",  new Coffee("카페모카", 3700, 1200));
        coffees.Add("콜드브루",  new Coffee("콜드브루", 3300, 1000));
        coffees.Add("아이스티",  new Coffee("아이스티", 3000, 800));
        coffees.Add("에이드",    new Coffee("에이드", 3500, 1300));
        coffees.Add("카페라떼",  new Coffee("카페라떼", 2700, 1100));
        coffees.Add("메가초코",  new Coffee("메가초코", 3800, 1500));
        coffees.Add("딸기바나나", new Coffee("딸기바나나", 3800, 1700));
        coffees.Add("퐁크러쉬",  new Coffee("퐁크러쉬", 3900, 1400));
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
