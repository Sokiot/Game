using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnToxic : MonoBehaviour
{
    Bounds SpawnArea;
    [SerializeField]
    GameObject[] toxic;

    void Start()
    {
        SpawnArea = gameObject.GetComponent<BoxCollider2D>().bounds;
        Vector2 newPosition = Vector2.zero;
        foreach (GameObject go in toxic) //for each fish
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
        foreach (GameObject go in toxic)
        {
            if (!go.activeInHierarchy)
            {
                go.transform.position = RandomPointInBounds();
                go.SetActive(true);
            }
        }
    }
}
