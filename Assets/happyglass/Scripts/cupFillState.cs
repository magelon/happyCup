using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupFillState : MonoBehaviour
{
    public float time;
    void OnTriggerStay2D(Collider2D other)
    {
        time += Time.time;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        time = 0;
    }
}
