using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{

    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private GameObject player;
    [SerializeField]private float waitTime = 3.0f;
    private float minXRange = 15.0f;
    private float maxXRange = 25.0f;
    private float minYRange = -8.0f;
    private float maxYRange = -2.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private float generateXPos()
    {
        float randomNum = Random.Range(minXRange, maxXRange);

        return randomNum;
    }

    private float generateYPos()
    {
        float randomYPos = Random.Range(minYRange, maxYRange);
        return randomYPos;
    }
    private void instantiateObstacles()
    {
        
        int index = Random.Range(0, obstacles.Length);
        float x = player.transform.position.x + generateXPos();
        float y =0;
        if(index == 0)
        {
            y = 1.79f;
        }
        if(index == 1)
        {
            y = 6.54f;
        }
        //Instantiate(availableGems[index], new Vector3(x, y, z), Quaternion.identity);
        Instantiate(obstacles[index], new Vector3(x, y, 0), Quaternion.identity);
        //print("fly instantiated");
        
    }

    private IEnumerator generateObstacles()
    {
        while (true)
        {

            yield return new WaitForSeconds(waitTime);
            instantiateObstacles();

        }
    }
}
