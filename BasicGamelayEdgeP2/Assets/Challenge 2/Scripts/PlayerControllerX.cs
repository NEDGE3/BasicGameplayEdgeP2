using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float SpawnRate = 1.0f;
    float timeStamp = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= timeStamp)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeStamp = Time.time + SpawnRate;
        }
    }
}
