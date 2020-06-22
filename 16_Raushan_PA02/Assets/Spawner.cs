using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] GameObject[] position;
    float ac= 0;
    float b = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ac += Time.deltaTime;

        if(b < ac)
        {
            b = ac + 1;
            int j = Random.Range(0, obstacles.Length);
            int k = Random.Range(0, position.Length);

            GameObject clone = Instantiate(obstacles[j], position[k].transform.position, position[k].transform.rotation);
            Destroy(clone, 1);


        }
    }
}
