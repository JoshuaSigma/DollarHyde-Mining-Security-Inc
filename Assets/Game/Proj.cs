using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proj : MonoBehaviour
{
    public float AliveTime;
    public GameObject Impact_FX;

    public int Damage;
    public int CriticalChance;
    public int DmgMulti;

    Vector3 lastPos;
    int actDmg;

    // Start is called before the first frame update
    void Awake()
    {
        AliveTime += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        lastPos = transform.position;
        if (Time.time > AliveTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var ran = Mathf.RoundToInt(Random.value * 100);
        if (ran <= CriticalChance)
        {
            actDmg = Damage * DmgMulti;
        }
        else
        {
            actDmg = Damage;
        }

        if (other.GetComponentInParent<Health>() != null)
        {
            Health health = other.GetComponentInParent<Health>();
            health.TakeDamage(actDmg);
        }

        Instantiate(Impact_FX, lastPos, Quaternion.identity, other.transform);
        Destroy(gameObject);
    }
}
