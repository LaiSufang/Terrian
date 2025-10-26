using UnityEngine;
using UnityEngine.UI;

public class HPHandler : MonoBehaviour
{
    public int hpMax = 100;
    public Slider hpBar;
    public float damagePerSecond = 5f;

    private float currenHp;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenHp = hpMax;
        hpBar.maxValue = hpMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destructable"))
        {
            hpMax -= 1;
            hpBar.value = hpMax;
        }

    }
}
