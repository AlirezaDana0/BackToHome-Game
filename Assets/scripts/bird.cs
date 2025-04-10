using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    void Update()
    {
        transform.position += new Vector3(4.5f, 0, 0) * Time.deltaTime;
    }
}
