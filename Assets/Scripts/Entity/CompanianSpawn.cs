using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanianSpawn : MonoBehaviour
{
    public GameObject companion;
    public GameObject plane;
    public PlayerStats stats;

    public float xPos;
    public float zPos;
    public int companionCount;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        
    }

    IEnumerator Spawn() {
        while (companionCount <= stats.maxCompanions) {
            xPos = Random.Range(plane.transform.position.x, plane.transform.localScale.x);
            zPos = Random.Range(plane.transform.position.z, plane.transform.localScale.z);
            Instantiate(companion, new Vector3(xPos, 0, zPos), Quaternion.identity);
            companionCount += 1;
            yield return null;
        }
    }
}
