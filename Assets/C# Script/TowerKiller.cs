using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerKiller : MonoBehaviour
{
    public List<GameObject> mobs = new List<GameObject>();
    public int index = 0;
    public float timer;

    private void OnTriggerEnter(Collider other)
    {
        print(1);
        mobs.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        mobs.Remove(other.gameObject);
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0 && mobs.Count > 0)
        {
            if (mobs[0] == null)
            {
                mobs.RemoveRange(0, 1);
            }
            print("PiyPay" + mobs[0].name);
            mobs[index].GetComponent<MoweMonster1>().hp--;
            timer = 1;
        }
    }
}
