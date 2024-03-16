using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner2 : MonoBehaviour
{
    public GameObject sphere;
    public float timer = 3f;
    public int time;
    public Coroutine corutSpawner;

    public void Start()
    {
        corutSpawner = StartCoroutine(TimerSpawner());
    }

    IEnumerator TimerSpawner()
    {
        while (true)
        {
            time++;
            Instantiate(sphere).transform.position = transform.position;
            yield return new WaitForSeconds(timer);
        }
    }

    public void CloseGame()
    {
        StopCoroutine(corutSpawner);
    }
}

