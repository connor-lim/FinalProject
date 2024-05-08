using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangeAIController : MonoBehaviour
{

    public Transform target;
    public NavMeshAgent agent;
    public Animator animator;
    public LayerMask whatIsGround, whatIsPlayer;
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public GameObject knife;
    public Transform spawner;
    public float throwSpeed;


    public float sightRange, attackRange;
    bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        target = GameObject.Find("Ninja").transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        animator.SetFloat("speed", 0);
        if (playerInSightRange && !playerInAttackRange)
        {
            ChasePlayer();
        }
        if (playerInSightRange && playerInAttackRange)
        {
            AttackPlayer();
        }
    }

    private void ChasePlayer()
    {
        animator.SetFloat("speed", 0.5f);
        agent.SetDestination(target.position);

    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        if(!alreadyAttacked)
        {
            animator.SetTrigger("attack");
            GameObject enemyKnife = Instantiate(knife, spawner.transform.position, spawner.transform.rotation) as GameObject;
            Rigidbody knifeRig = enemyKnife.GetComponent<Rigidbody>();
            knifeRig.AddForce(knifeRig.transform.forward * throwSpeed);
            Destroy(enemyKnife, 5f);
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

}

