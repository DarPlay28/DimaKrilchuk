using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.HasKey("PlayerX"))
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"));
            transform.localScale = new Vector2(PlayerPrefs.GetFloat("PlayerScaleX"), PlayerPrefs.GetFloat("PlayerScaleY"));
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerScaleX", transform.localScale.x);
        PlayerPrefs.SetFloat("PlayerScaleY", transform.localScale.y);
        PlayerPrefs.Save();
    }
}
