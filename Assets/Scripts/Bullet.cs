using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletLifeTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, bulletLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destructable")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
