using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 25f;

    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Destructable")) return;

        Destroy(collision.gameObject);
        Destroy(gameObject);

        if (ScoreManager.Instance != null)
            ScoreManager.Instance.AddScore(100);
        else
            Debug.LogWarning("[Bullet] ScoreManager.Instance is null. Score not added.");
    }
}
