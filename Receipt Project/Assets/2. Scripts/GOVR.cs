using System.Collections.Generic;
using UnityEngine;

public enum PaymentType
{
    ī��, ����, enumMax
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
        coffees.Add("�Ƹ޸�ī��", new Coffee("�Ƹ޸�ī��", 1500, 500));
        coffees.Add("īǪġ��",  new Coffee("īǪġ��", 2700, 1000));
        coffees.Add("ī���ī",  new Coffee("ī���ī", 3700, 1200));
        coffees.Add("�ݵ���",  new Coffee("�ݵ���", 3300, 1000));
        coffees.Add("���̽�Ƽ",  new Coffee("���̽�Ƽ", 3000, 800));
        coffees.Add("���̵�",    new Coffee("���̵�", 3500, 1300));
        coffees.Add("ī���",  new Coffee("ī���", 2700, 1100));
        coffees.Add("�ް�����",  new Coffee("�ް�����", 3800, 1500));
        coffees.Add("����ٳ���", new Coffee("����ٳ���", 3800, 1700));
        coffees.Add("��ũ����",  new Coffee("��ũ����", 3900, 1400));
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
