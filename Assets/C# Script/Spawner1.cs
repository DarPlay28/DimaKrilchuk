using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject sphere;
    public float timer = 3.0f;
    public float time;
    public bool isActive;

    private void Update()
    {
        if (isActive == true)
        {
            if (time <= 0)
            {
                Instantiate(sphere).transform.position = transform.position;
                time = timer;
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
    }
}
