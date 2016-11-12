using UnityEngine;
using System.Collections;

public class velocity : MonoBehaviour {

    public Vector2 velo = new Vector2(-4, 0);

    // Use this for initialization
    void Start()
    {
        rigidbody2D.velo = velocity;
    }
}

