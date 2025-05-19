using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class GOVR : MonoBehaviour
{
    // O(1)
    private Dictionary<string, Coffee> coffees = new Dictionary<string, Coffee>();
    
    private IRandomProvider<Coffee>  coffeeProvider;
    private IRandomProvider<Payment> paymentProvider;

    private void Awake()
    {
        LoadCoffees();

        coffeeProvider = new RandomCoffeeProvider(coffees);
        paymentProvider = new RandomPaymentProvider();
    }

    private void LoadCoffees()
    {
        TextAsset jsonText = Resources.Load<TextAsset>("coffees");
        if (jsonText == null) return;

        List<Coffee> coffeeList = JsonConvert.DeserializeObject<List<Coffee>>(jsonText.text);
        foreach (var coffee in coffeeList)
        {
            coffees[coffee.Name] = coffee;
        }
    }

    public Coffee GetRandomCoffee() => coffeeProvider.GetRandom();
    public Payment GetRandomPaymentType() => paymentProvider.GetRandom();
}