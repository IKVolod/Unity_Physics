﻿using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            var exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(gameObject);
        }    
    }
}
