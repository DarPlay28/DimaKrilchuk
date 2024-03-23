using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpBomb : MonoBehaviour
{
    public int[,] mass = new int[5, 5];
    public Text[] buttons;
    public int number = 0;

    public void Restart()
    {
        foreach(Text button in buttons)
        {
            button.text = "";
            button.transform.parent.GetComponent<Image>().color = Color.white;
        }
        for(int y = 0;y < 5;y++)
        {
            for (int x = 0; x < 5; x++)
            {
                mass[y, x] = Random.Range(-1, 4);
            }
        }
        for(int y = 0;y < 5;y++)
        {
            chk
        }
    }
}
