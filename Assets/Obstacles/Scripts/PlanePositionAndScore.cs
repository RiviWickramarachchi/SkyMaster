using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePositionAndScore : MonoBehaviour
{
    private bool obstaclePassed = false;
    
    void Update()
    {
        if(obstaclePassed == false)
        {
            float obstacleXPos = this.gameObject.transform.position.x;
            float playerXPos = PlayerInst.instance.getPlayerXPosition();

            if(playerXPos > obstacleXPos)
            {
                ScoreManager.instance.addPoint();
                obstaclePassed = true;
            }
        }
       
    }
}
