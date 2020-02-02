using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanianSpawn : MonoBehaviour
{
    public GameObject companion;
    public GameObject companion2;
    public GameObject plane;

    public float xPos;
    public float zPos;
    public int companionCount;

    GameObject[] companionList = new GameObject[2];


    // Start is called before the first frame update
    void Start()
    {
        companionList[0] = companion;
        companionList[1] = companion2;
        StartCoroutine(Spawn());
        
    }

    IEnumerator Spawn() {
        while (companionCount < 3) {
            xPos = Random.Range(plane.transform.position.x, plane.transform.localScale.x);
            zPos = Random.Range(plane.transform.position.z, plane.transform.localScale.z);
            Instantiate(companionList[Random.Range(0,companionList.Length)], new Vector3(xPos, 0, zPos), Quaternion.identity);
            companionCount += 1;
            yield return null;
        }
    }
}
