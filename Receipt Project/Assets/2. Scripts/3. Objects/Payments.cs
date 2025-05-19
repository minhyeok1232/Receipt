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