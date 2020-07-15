using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    Bounds SpawnArea;
    [SerializeField]
    GameObject[] fish;

    void Start()
    {
        SpawnArea = gameObject.GetComponent<BoxCollider2D>().bounds;
        Vector2 newPosition = Vector2.zero;
        foreach(GameObject go in fish) //for each fish
        {
            go.transform.position = RandomPointInBounds();
        }
    }

    private Vector2 RandomPointInBounds()
    {
        Vector2 result = new Vector2(Random.Range(SpawnArea.min.x, SpawnArea.max.x),
                                     Random.Range(SpawnArea.min.y, SpawnArea.max.y));
        return result;
    }

    void Update()
    {
        foreach(GameObject go in fish)
        {
            if(!go.activeInHierarchy)
            {
                go.transform.position = RandomPointInBounds();
                go.SetActive(true);
            }
        }
    }
}
