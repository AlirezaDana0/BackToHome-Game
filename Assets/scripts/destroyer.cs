using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    void OnEnable() {
        var persistentObjects = FindObjectsOfType<GameObject>();

    foreach (GameObject obj in persistentObjects) {
        if (obj.scene.name == "DontDestroyOnLoad") {
            Destroy(obj);
             }
    }
}
}
