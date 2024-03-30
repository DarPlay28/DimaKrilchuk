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
            for (int x = 0;x < 5;x++)
            {
                number = 0;
                if (mass[y, x] != -1)
                {
                    if (y > 0)
                    {
                        if (mass[y - 1, x] == -1)
                        {
                            number++;
                        }
                    }
                    if (y < 4)
                    {
                        if (mass[y + 1, x] == -1)
                        {
                            number++;
                        }
                    }
                    if (x < 4)
                    {
                        if (mass[y, x + 1] == -1)
                        {
                            number++;
                        }
                    }
                    if (x > 0)
                    {
                        if (mass[y, x - 1] == -1)
                        {
                            number++;
                        }
                    }
                    if (x > 0 && y > 0)
                    {
                        if (mass[y - 1, x + 1] == -1)
                        {
                            number++;
                        }
                    }
                    if (x > 0 && y < 4)
                    {
                        if (mass[y - 1, x + 1] == -1)
                        {
                            number++;
                        }
                    }
                    if (x > 0 && y > 0)
                    {
                        if (mass[y - 1, x + 1] == -1)
                        {
                            number++;
                        }
                    }
                    if (x > 0 && y > 0)
                    {
                        if (mass[y - 1, x + 1] == -1)
                        {
                            number++;
                        }
                    } //
                }
            }
        }
    }

    public void Check(int index)
    {
        int y = index / 5;
        int x = index % 5;
        if (mass[y, x] == -1)
        {
            buttons[intex].transform.parent.GetComponent<Image>().color = Color.red;
        }
        else
        {
            buttons[index].text = mass[y, x].ToString();
        }
    }
}
