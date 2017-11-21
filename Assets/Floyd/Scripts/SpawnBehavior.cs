using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{


    public float minX = 0.0f;
    public float maxX = 0.0f;
    public GameObject[] Hazards;
    public float timeBetweenSpawn = 0.0f;
    private bool canSpawn = false;
    private int amountOfHazardsToSpawn = 0;
    private int hazardToSpawn = 0;

	void Start ()
    {
        canSpawn = true;
	}
	
	void Update ()
    {
        if (canSpawn == true)
        {
            StartCoroutine(GenerateHazard());
        }
	}

    private IEnumerator GenerateHazard()
    {
        canSpawn = false;
        timeBetweenSpawn = Random.Range(0.5f, 2.0f);
        amountOfHazardsToSpawn = Random.Range(1, 6);
        for (int i = 0; i < amountOfHazardsToSpawn; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), 8.0f, 0.0f);
            Instantiate(Hazards[hazardToSpawn], spawnPos, Quaternion.identity);
        }
        yield return new WaitForSeconds(timeBetweenSpawn);
        canSpawn = true;
    }
}
