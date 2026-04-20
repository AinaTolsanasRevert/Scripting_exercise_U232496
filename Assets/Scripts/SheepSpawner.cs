using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SheepSpawner : MonoBehaviour
{
    public bool canSpawn = true;
    public GameObject sheepPrefab;
    public List<Transform> sheepSpawnPosition = new List<Transform>();
    public float timeBetweenSpawns;
    private List<GameObject> sheepList = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnSheep()
    {
        Vector3 randomPosition = sheepSpawnPosition[Random.Range(0, sheepSpawnPosition.Count)].position;
        GameObject sheep = Instantiate(sheepPrefab, randomPosition,sheepPrefab.transform.rotation);
        sheepList.Add(sheep);
        sheep.GetComponent<Sheep>().SetSpawner(this);
    }
    private IEnumerator SpawnRoutine()
    {
        while (canSpawn)
        {
            SpawnSheep();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
    public void RemoveSheepFromList(GameObject sheep)
    {
        sheepList.Remove(sheep);
    }
    public void DestroyAllSheep()
    {
        // Suposant que tens una llista anomenada 'sheepList' on guardes les ovelles
        foreach (GameObject sheep in sheepList)
        {
            Destroy(sheep);
        }
        sheepList.Clear();
    }
}
