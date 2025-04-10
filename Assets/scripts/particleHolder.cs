using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleHolder : MonoBehaviour
{
    void Start()
    {
         DontDestroyOnLoad(this.gameObject);
    }

}
