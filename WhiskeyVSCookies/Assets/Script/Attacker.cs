using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public float seenEverySeconds;
    private GameObject currentTarget;
    private float currentSpeed;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left *currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("iAttacking", false);
        }
    }

     void OnTriggerEnter2D()
    {
        Debug.Log(name + " trigger enter");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (currentTarget)
        { 
            Health health= currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }
    }
    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
