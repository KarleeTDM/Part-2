using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float timerValue;
    float targetValue = 0.05f;
    public GameObject prefab;
    // Update is called once per frame
    void Update()
    {
        timerValue = 1 * Time.deltaTime;
        Debug.Log(timerValue);
        if (timerValue > targetValue)
        {
            Instantiate(prefab);
            timerValue = 0;
        }
    }
}
