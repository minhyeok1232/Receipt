using System.Collections.Generic;
using UnityEngine;

public class RandomCoffeeProvider : IRandomProvider<Coffee>
{
    private Dictionary<string, Coffee> coffees;

    public RandomCoffeeProvider(Dictionary<string, Coffee> coffees)
    {
        this.coffees = coffees;
    }

    public Coffee GetRandom()
    {
        var keys = new List<string>(coffees.Keys);
        string randomKey = keys[Random.Range(0, keys.Count)];
        return coffees[randomKey];
    }
}