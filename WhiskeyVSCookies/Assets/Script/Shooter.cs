using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectile,gun;
    private GameObject projectileParent;
    private Animator animator;
    private Spawner myLaneSpawner;

    private void Start()
    {
        animator = GameObject.FindObjectOfType<Animator>();

        projectileParent = GameObject.Find("Projectiles");

        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
            

        }
        SetMyLaneSpawner();
    }
     void Update()
    {
        if (IsAttackerAheadInLane())
        {
            animator.SetBool("iAttacking", true);
        }
        else
        {
            animator.SetBool("iAttacking", false);
        }

        
    }

    bool IsAttackerAheadInLane()
    {
        return true;
    }
    void SetMyLaneSpawner()
    {
        Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();

        foreach (Spawner spawner in spawnerArray)
        {
            if (spawner.transform.position.y==transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }
        Debug.LogError(name + " Can't find spawner in lane");
    }


    private void Fire()
    {
       GameObject newProjectile= Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
