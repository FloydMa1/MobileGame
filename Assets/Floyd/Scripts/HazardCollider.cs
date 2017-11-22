using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCollider : MonoBehaviour {

    private static Score scoreScript;

    private void Start()
    {
        if (!scoreScript)
            scoreScript = GameObject.Find("Score").GetComponent<Score>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            scoreScript.score++;
            this.gameObject.SetActive(false);
        }

        if(collision.gameObject.tag == "player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
