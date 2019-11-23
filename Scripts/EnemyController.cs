using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState
{
    CHASE,
    ATTACK
}

public class EnemyController : MonoBehaviour {

    private CharacterAnimations enem_Anim;
    private NavMeshAgent navAgent;

    private Transform playerTarget;
    public float move_speed = 3.5f;
    public float attack_distance = 1f;
    public float chase_after_Attack_distance = 1f;
    private float wait_before_attack_time = 3f;
    private float attack_timer;
    private EnemyState enemy_state;

    // Use this for initialization
    void Awake() {
        enem_Anim = GetComponent<CharacterAnimations>();
        navAgent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
    }

    void Start() {
        enemy_state = EnemyState.CHASE;
        attack_timer = wait_before_attack_time;
    }
    

	// Update is called once per frame
	void Update () {
		if(enemy_state == EnemyState.CHASE)
        {
            ChasePlayer();
        }
        if(enemy_state == EnemyState.ATTACK)
        {
            AttackPlayer();
        }
	}

    void ChasePlayer()
    {
        navAgent.SetDestination(playerTarget.position);
        navAgent.speed = move_speed;

        if(navAgent.velocity.sqrMagnitude == 0)
        {
            enem_Anim.Walk(false);
        }
        else
        {
            enem_Anim.Walk(true);
        }

        if(Vector3.Distance(transform.position, playerTarget.position) <= attack_distance)
        {
            enemy_state = EnemyState.ATTACK;
        }
    }

    void AttackPlayer()
    {

    }
}
