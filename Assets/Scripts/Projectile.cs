using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float ProjectileSpeed = 0.5f;

    public int maxYPosition = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, 0.4f));
        if (transform.position.y > 100){
            Destroy(gameObject);
        }
    }
}
