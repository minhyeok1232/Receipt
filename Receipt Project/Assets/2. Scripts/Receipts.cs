using UnityEngine;

/// <summary>
/// 20잔의 랜덤 음료 판매 결과를 출력하는 클래스
/// </summary>

public class Receipts : MonoBehaviour
{
    [SerializeField] private GOVR govr;
    
    [Header("Option")]
    private string _date       = "20210914";
    private string _storeName  = "GOVR커피";
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
            
            Debug.Log($"영수증 : {randomCoffee.Name}|{randomCoffee.Price}|{randomPayment}|{_date}|{_storeName}|{_storePhone}");
        }
        
        Debug.Log($"저희 매장의 총 잔금은 {_totalProfit}원입니다.");
    }
}
