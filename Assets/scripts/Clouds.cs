using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public static bool canMove = false;
    
    void Update()
    {
        transform.position -= new Vector3(0, 3.2f, 0) * Time.deltaTime; 
    }
    
}