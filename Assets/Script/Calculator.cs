using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Calculator : MonoBehaviour
{
    public TMP_Text TextX;
    public TMP_Text TextY;
    public TMP_Text TextR;

    public int x = 0;
    public int y = 0;
    public int sum = 0;
    public int opp = 0;
    bool flag = false;

    public void FunctionForVlaues(int i)
    {
        if (!flag)
        {
            x *= 10;
            x += i;
            TextX.SetText((x).ToString());
        }
        else
        {
            y *= 10;
            y += i;
            TextY.SetText((y).ToString());
        }
    }
    public void FunctionForFlag() 
    {
        flag = true;
    }
    public void FunctionForEqual()
    {
        if (opp != 0)
        {
            if(opp == 1)
            {
                FunctionForAdd();
            }
            else if (opp == 2)
            {
                FunctionForSubtraction();
            }
            else if (opp == 3)
            {
                FunctionForMultiplication();
            }
            else if (opp == 4)
            {
                FunctionForDivision();
            }
            else if (opp == 5)
            {
                FunctionForMod();
            }
            else { TextR.SetText("Error"); }
        }
        else { TextR.SetText("Error"); }
    }

    public void FunctionForDel()
    {
        if (flag && y!=0) 
        {
            y = y / 10;
            TextY.SetText((y).ToString());
        }
        else if (y==0 && flag)
        {
            opp = 0;
            flag=false;

        }
        else if (!flag) 
        {
            x = x / 10;
            TextX.SetText((x).ToString());
        }
    }
    public void FunctionForC()
    {
        x=0; y=0;
        TextX.SetText((0).ToString());
        TextY.SetText((0).ToString());
        flag = false;
    }
    public void FunctionForOpp(int i)
    {
        opp = i;
    }
    void FunctionForAdd()
    {
        TextR.SetText((x+y).ToString());
    }
    void FunctionForSubtraction()
    {
        TextR.SetText((x - y).ToString());
    }
    void FunctionForMultiplication()
    {
        TextR.SetText((x * y).ToString());
    }
    void FunctionForDivision()
    {
        if (y != 0)
        {
            TextR.SetText((x / y).ToString());
        }
        else
        {
            TextR.SetText("Error");
        }
    }
    void FunctionForMod()
    {
        TextR.SetText((x % y).ToString());
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

}