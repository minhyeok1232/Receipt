using UnityEngine;

public class RandomPaymentProvider : IRandomProvider<Payment>
{
    public Payment GetRandom()
    {
        int index = (int)PaymentType.enumMax;
        int randomIndex = Random.Range(0, index);
        return new Payment((PaymentType)randomIndex);
    }
}