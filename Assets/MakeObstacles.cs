using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObstacles : MonoBehaviour
{

    [SerializeField] float delay;
    [SerializeField] GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnStuff());
    }

    IEnumerator SpawnStuff () {
        while (true){
            yield return new WaitForSeconds(delay);
            Instantiate (obstacle, transform.position + Vector3.up * (Random.value * 4 - 2)*Time.deltaTime, Quaternion.identity);
        }
    }
}
