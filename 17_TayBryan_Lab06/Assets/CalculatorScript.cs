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
    float SGDRM = 3.08f;
    float SGDEUR = 0.63f;
    float SGDKRW = 881.54f;
    float SGDTWD = 20.73f;

    public Text Debug;

    public Toggle toggleUSDollar;
    public Toggle toggleJapYen;
    // added other currencies 
    public Toggle toggleMalaysiaRM;
    public Toggle toggleEuropianEuro;
    public Toggle toggleKoreanKRW;
    public Toggle toggleTaiwanTWD;

    public InputField AmountInput;
    public InputField ConvertedAmountInput;

    public void Start()
    {
        toggleUSDollar.isOn = false; 
        toggleJapYen.isOn = false;
        toggleMalaysiaRM.isOn = false;
        toggleEuropianEuro.isOn = false;
        toggleKoreanKRW.isOn = false;
        toggleTaiwanTWD.isOn = false;
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
        else if (toggleMalaysiaRM.isOn == true)
        {
            ToggleValue = 4;
        }
        else if (toggleEuropianEuro.isOn == true)
        {
            ToggleValue = 5; 
        }
        else if (toggleKoreanKRW.isOn == true)
        {
            ToggleValue = 6; 
        }
        else if (toggleTaiwanTWD.isOn == true)
        {
            ToggleValue = 7; 
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
        else if (ToggleValue == 4)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "RM" + (amount * SGDRM);
            }
            catch
            {
                Debug.text = "Please enter a valid input";
            }
           
        }
        else if (ToggleValue == 5)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "€" + (amount * SGDEUR);
            } 
            catch
            {
                Debug.text = "Please enter a valid input";
            }
        }
        else if (ToggleValue == 6)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "₩" + (amount * SGDKRW);
            }
            catch
            {
                Debug.text = "Please enter a valid input";
            }
        }
        else if (ToggleValue == 7)
        {
            try
            {
                amount = float.Parse(AmountInput.text);
                ConvertedAmountInput.text = "NT$" + (amount * SGDTWD);
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
