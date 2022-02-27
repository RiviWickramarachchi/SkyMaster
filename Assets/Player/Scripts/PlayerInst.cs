using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInst : MonoBehaviour
{
    public static PlayerInst instance;

    private void Awake()
    {
        instance = this;
    }
    public float getPlayerXPosition()
    {
        return this.transform.position.x;
    }

    
}
