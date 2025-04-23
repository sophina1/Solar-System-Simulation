using UnityEngine;

public class CometSpawner : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("Spawner", 1.0f, 5.0f);
    }

    void Spawner() {
        Instantiate (target, transform.position, transform.rotation, null);
    }
}
