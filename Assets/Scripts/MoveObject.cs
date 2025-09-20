using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject: MonoBehaviour
{

    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Objective 2: Move Object
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    public void OnMouseDown()
    {
        if (moveSpeed == 5.0f)
        {
            moveSpeed = 0f;
        }
        else
        {
            moveSpeed = 5.0f;
        }
    }

}