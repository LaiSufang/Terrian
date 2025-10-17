using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnLocation;
    public AudioSource shootSoundEffect;

    // animations
    private Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("isShooting");
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnLocation.transform.position, bulletSpawnLocation.transform.rotation);
            //bullet.transform.position = bulletSpawnLocation.transform.position;
            //bullet.transform.forward = bulletSpawnLocation.transform.forward;

            shootSoundEffect.Play();
        }
        //else         
        //{
        //    animator.ResetTrigger("isShooting");
        //}
    }
}
