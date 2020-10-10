using UnityEngine;

public class ParticleAutoDelete : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, GetComponent<ParticleSystem>().main.duration); 
    }
}
