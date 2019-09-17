using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRoom : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != null)
        {
            print("Room detect, do nothing(self destruct)");
            Destroy(this.gameObject);
        }
    }


}
