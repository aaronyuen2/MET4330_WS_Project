using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float lifeTime = 1f;  // destroy the particle after 1 second

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        print(lifeTime);

        if (lifeTime <= 0f)
            Destroy(gameObject);
    }
}
