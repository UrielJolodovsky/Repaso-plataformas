using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMaker : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject eggSpawnPoint;
    float tamaño = 0.2f;
    float tamaño1 = 0.27f;
    float tamaño2 = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject clon;
            clon = Instantiate(eggPrefab);
            clon.transform.position = eggSpawnPoint.transform.position; 
            clon.transform.localScale = new Vector3(tamaño, tamaño1, tamaño2);
        tamaño += 1;
        tamaño1 += 1;
        tamaño2 += 1;
        }
    }
}
