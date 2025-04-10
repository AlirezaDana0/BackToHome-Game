using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundDestroyer : MonoBehaviour
{
    void Start()
    {
       StartCoroutine(Destroyer());
    }
     IEnumerator Destroyer() {
         yield return new WaitForSeconds(8f);
         Destroy(gameObject);
         StartCoroutine(Destroyer());
    }
}
