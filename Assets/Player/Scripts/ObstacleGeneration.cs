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
    private float minYRange = 1.0f;
    private float maxYRange = 1.9f;
   
    
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

    private float generateYScalePos()
    {
        float randomYPos = Random.Range(minYRange, maxYRange);
        return randomYPos;
    }
    private void instantiateObstacles()
    {
        
        int index = Random.Range(0, obstacles.Length);
        float x = player.transform.position.x + generateXPos();
        float y = -1.5f;
        
        //Instantiate(availableGems[index], new Vector3(x, y, z), Quaternion.identity);
        GameObject building = Instantiate(obstacles[index], new Vector3(x, y, 0), Quaternion.identity);
        building.transform.localScale = new Vector3(1f, generateYScalePos(), 1f);
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
