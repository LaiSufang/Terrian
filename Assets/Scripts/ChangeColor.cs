using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Objective 3: change objects color 
        GetComponent<MeshRenderer>().material.color = Color.cyan;

    }

    // Update is called once per frame
    void Update()
    {

    }
}