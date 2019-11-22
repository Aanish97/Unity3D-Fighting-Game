using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    CHASE,
    ATTACK
}

public class EnemyController : MonoBehaviour {

    private CharacterAnimations enem_Anim;
    private NavMesh navAgent;

    private Transform playerTarget;
    public float move_speed = 3.5f;
    public float attack_distance = 1f;
    public float chase_after_Attack_distance = 1f;
    private float wait_before_attack_time = 3f;
    private float attaci_timer;
    private EnemyState enemy_state;

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
