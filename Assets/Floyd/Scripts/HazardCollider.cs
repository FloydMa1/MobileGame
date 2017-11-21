using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCollider : MonoBehaviour {


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            this.gameObject.SetActive(false);
        }

        if(collision.gameObject.tag == "player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
