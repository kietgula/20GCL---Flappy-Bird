using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject PipePrefab;
    public float density = 0.5f;
    public float offset = 2f;
    private float nextSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + 1/density;
    }

    // Update is called once per frame
    void Update()
    {
        if ( nextSpawnTime < Time.time)
        {
            nextSpawnTime = Time.time + 1/density + Random.Range(-1f*offset, offset);

            GameObject newPipe = Instantiate(PipePrefab, transform);
            newPipe.transform.position = new Vector3(10, Random.Range(-2f,3f),2);

        }
    }
}
