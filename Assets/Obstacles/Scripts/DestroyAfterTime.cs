using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float time_Interval;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, time_Interval);
    }

    
}
