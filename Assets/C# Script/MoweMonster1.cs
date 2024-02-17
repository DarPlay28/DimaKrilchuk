using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoweMonster1 : MonoBehaviour
{
    public Transform[] road;
    public float speed;
    public int index = 0;
    public int hp = 2;
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, road[index].transform.position, speed);
        if(Vector3.Distance(transform.position, road[index].position) < 0.1f)
        {
            if (index < road.Length)
                index++;
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
