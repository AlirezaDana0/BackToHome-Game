using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerS : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Bird;
    void Start()
    {
        StartCoroutine(Make());
        StartCoroutine(MakeBird());


    }
    
     IEnumerator Make() {
        yield return new WaitForSeconds(Random.Range(0.7f, 1.1f));
        GameObject cloud = Instantiate(Ground , new Vector3(Random.Range(-2.2f,2.2f),5.4f,0),Quaternion.identity);
              StartCoroutine(Make());
              Destroy(cloud,6f);
    }
    IEnumerator MakeBird() {
        yield return new WaitForSeconds(Random.Range(13f, 18f));
        GameObject Birds = Instantiate(Bird , new Vector3(-4.6f,Random.Range(-4.2f,4.7f),0),Quaternion.identity);
              StartCoroutine(MakeBird());
              Destroy(Birds,3.5f);
    }
}
