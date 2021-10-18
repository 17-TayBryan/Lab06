using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{

    float amount;

    int ToggleValue;

    float SGDUSD = 0.74f;
    float SGDJPY = 82.78f;

    public Text Debug;

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
        if (toggleJapYen.isOn == true && toggleUSDollar.isOn == true)
        {
            ToggleValue = 3;
        }
        else if (toggleJapYen.isOn == true)
        {
            ToggleValue = 2;
        }
        else if (toggleUSDollar.isOn == true)
        {
            ToggleValue = 1;
        }
        else
        {
            ToggleValue = 0;
        }

        print(ToggleValue);
    }

    public void ConvertAmount()
    {
       
        if(ToggleValue == 1)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "$" + (amount * SGDUSD);
            }
            catch
            {
                Debug.text = "Please enter a valid input";
            }
            
        }
        else if(ToggleValue == 2)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "¥" + (amount * SGDJPY);
            }
            catch
            {
                Debug.text = "Please enter a valid input";
            }
            
        }
        else if(ToggleValue == 3)
        {
            Debug.text = "Please have one currency toggled.";
        }
        else
        {
            Debug.text = "Please toggle a currency.";
        }
       
    }

    public void ClearInput()
    {
        toggleUSDollar.isOn = false;
        toggleJapYen.isOn = false;
        ConvertedAmountInput.text = "";
        AmountInput.text = "";
    }

}
