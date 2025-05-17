using UnityEngine;

/// <summary>
/// 20���� ���� ���� �Ǹ� ����� ����ϴ� Ŭ����
/// </summary>

public class Receipts : MonoBehaviour
{
    [SerializeField] private GOVR govr;
    
    [Header("Option")]
    private string _date       = "20210914";
    private string _storeName  = "GOVRĿ��";
    private string _storePhone = "02-012-3456";

    private int _totalProfit = 0;
    
    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Coffee randomCoffee = govr.GetRandomCoffee();
            Payment randomPayment = govr.GetRandomPaymentType();
            
            int profit = randomCoffee.Price - randomCoffee.Cost;
            _totalProfit += profit;
            
            Debug.Log($"������ : {randomCoffee.Name}|{randomCoffee.Price}|{randomPayment}|{_date}|{_storeName}|{_storePhone}");
        }
        
        Debug.Log($"���� ������ �� �ܱ��� {_totalProfit}���Դϴ�.");
    }
}
