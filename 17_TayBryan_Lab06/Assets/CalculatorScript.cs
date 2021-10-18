using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{

    float amount;

    float SGDUSD = 0.74f;
    float SGDJPY = 82.78f;

    public Toggle toggleUSDollar;
    public Toggle toggleJapYen;

    public InputField AmountInput;
    public InputField ConvertedAmountInput;

    public void Start()
    {
        toggleUSDollar.isOn = false;
        toggleJapYen.isOn = false;
    }

    public void Update()
    {
        amount = float.Parse(AmountInput.text);
    }

    public void ConvertAmount()
    {
        ConvertedAmountInput.text = "$" + (amount * SGDUSD);
    }




}
