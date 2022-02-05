using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingObstacles : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private GameObject player;
    [SerializeField] private float waitTime = 5.0f;
    private float minXRange = 10.0f;
    private float maxXRange = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateObstacles());
    }

    // Update is called once per frame
  
    private float generateXPos()
    {
        float randomNum = Random.Range(minXRange, maxXRange);

        return randomNum;
    }

   
    private void instantiateObstacles()
    {

        int index = Random.Range(0, obstacles.Length);
        float x = player.transform.position.x + generateXPos();
        float y = 25.96f;

        //Instantiate(availableGems[index], new Vector3(x, y, z), Quaternion.identity);
        GameObject.Instantiate(obstacles[index], new Vector3(x, y, 0), Quaternion.Euler(0f,0f,180f));
       

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
