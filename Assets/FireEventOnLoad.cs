using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireEventOnLoad : MonoBehaviour
{
    public UnityEvent eventsToFire;
    // Start is called before the first frame update
    void Start()
    {
        if (eventsToFire != null)
            eventsToFire.Invoke();
    }
}
