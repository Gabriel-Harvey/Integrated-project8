using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Ball":
                Destroy(gameObject);
                break;
        }
    }
}
