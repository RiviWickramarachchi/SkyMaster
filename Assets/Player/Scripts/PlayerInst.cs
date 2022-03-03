using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInst : MonoBehaviour
{
    private static PlayerInst instance;

    public static PlayerInst GetInstance { get => instance; }

    private void Awake()
    {
        instance = this;
    }
    public float getPlayerXPosition()
    {
        return this.transform.position.x;
    }

    
}
