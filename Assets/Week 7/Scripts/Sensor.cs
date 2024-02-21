using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
        SendMessage("IncreaseScore", SendMessageOptions.DontRequireReceiver);
        SendMessage("ResetBallPosition", SendMessageOptions.DontRequireReceiver);
    }
}