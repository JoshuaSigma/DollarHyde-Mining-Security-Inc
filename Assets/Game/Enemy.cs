using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public Animator Animator;

    public float AttackRange;

    readonly string SPEED = "speed";
    readonly string ATTACK = "attack";
    readonly string DAMAGE = "damage";
    readonly string DEATH = "death";
    readonly string ANGULAR_SPEED = "angularspeed";

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(Player.position);
    }

    // Update is called once per frame
    void Update()
    {
        Animator.SetFloat(SPEED, agent.velocity.magnitude);
        //var dist = Vector3.Distance(transform.position, Player.position);
    }
}
