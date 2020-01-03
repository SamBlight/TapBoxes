using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RarityCalc : MonoBehaviour
{
    //public Inventory inventory;
    //public Text Display;
    int URCount = 0;
    int RCount = 0;
    int UCCount = 0;
    int CCount = 0;
    int count = 0;

    public int Return(int itemCount)
    {
        int randomNum;



        randomNum = Random.Range(1, itemCount+1);

        return randomNum;

        /*
        if (randomNum == 10)
        {
            Result = "Ultra Rare";
            URCount++;
            Debug.Log("<color=gold>Ultra Rare Count: </color>" + URCount);
            //Display.text = Result;
            //inventory.UpdateItem(3, 3, URCount);
        }
        else if (randomNum <= 9 && randomNum >= 8)
        {
            Result = "Rare";
            RCount++;
            Debug.Log("<color=purple>Rare Count: </color>" + RCount);
            //Display.text = Result;
            //inventory.UpdateItem(2, 2, RCount);
        }
        else if (randomNum <= 7 && randomNum >= 5)
        {
            Result = "Uncommon";
            UCCount++;
            Debug.Log("<color=blue>Uncommon Count: </color>" + UCCount);
            //Display.text = Result;
            //inventory.UpdateItem(1, 1, UCCount);
        }
        else if (randomNum <= 4)
        {
            Result = "Common";
            CCount++;
            Debug.Log("<color=grey>Common Count: </color>" + CCount);
            //Display.text = Result;
            //inventory.UpdateItem(0, 0, CCount);

        }
        else
        {
            Result = "Something went wrong";
        }
        count++;
        Debug.Log("Count: " + count);
        return (Result);
    */
    }

}
