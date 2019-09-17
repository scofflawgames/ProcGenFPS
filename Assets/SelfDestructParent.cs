using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructParent : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
