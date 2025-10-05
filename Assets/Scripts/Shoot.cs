using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnLocation;
    public AudioSource shootSoundEffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnLocation.transform.position, bulletSpawnLocation.transform.rotation);
            //bullet.transform.position = bulletSpawnLocation.transform.position;
            //bullet.transform.forward = bulletSpawnLocation.transform.forward;

            shootSoundEffect.Play();
        }
    }
}
