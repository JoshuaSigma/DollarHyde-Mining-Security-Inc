using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFX : MonoBehaviour
{
    public float AliveTime;

    // Start is called before the first frame update
    void Awake()
    {
        AliveTime += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > AliveTime)
        {
            Destroy(gameObject);
        }
    }
}
