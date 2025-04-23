using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Tooltip("The distance this projectile will move each second in meters.")]
    public float projectileSpeed = 20.0f;
    
    [Tooltip("How far away from the main camera before destroying the projectile gameobject in meters.")]
    public float destroyDistance = 300.0f;
    void Update()
    {
        MoveProjectile();
    }
    private void MoveProjectile() {
        Vector3 v = new Vector3 (1f, 1f, 1f);
        //transform.position += transform.forward * projectileSpeed * Time.deltaTime;
        transform.position += v * projectileSpeed * Time.deltaTime;
        float dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (dist > destroyDistance) {
            Destroy(gameObject);
        }
    }
}
