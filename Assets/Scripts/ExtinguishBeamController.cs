using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishBeamController : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    public Transform mParticleSystem;
    private MeshRenderer mRenderer;

    public void Awake()
    {
        mRenderer = GetComponent<MeshRenderer>();
        _particleSystem.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        _particleSystem.Play();
        UpdateStream(GetLength(other));
    }

    void OnTriggerStay(Collider other)
    {
        UpdateStream(GetLength(other));
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("OnTriggerExit");
        _particleSystem.Stop();
        UpdateStream(0);
    }

    private void UpdateStream(float length)
    {
        Debug.Log($"Update Stream with length: {length}");

        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, length);
        mParticleSystem.position = newPosition;

        float cutoff = length / transform.localScale.z;
        mRenderer.material.SetFloat("_Cutoff", cutoff);
    }

    private float GetLength(Collider collider)
    {
        return collider.transform.position.z + collider.bounds.size.z / 2;
    }
    
}
