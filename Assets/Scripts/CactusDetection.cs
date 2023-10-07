using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDetection : MonoBehaviour
{

    private Animator cactusAnimator;
    public float detectionDistance = 0.1f;


    private void Start()
    {

        cactusAnimator = GetComponent<Animator>();
    }

    private void Update()
    {

        //pentru testarea punctului b) <=> la apasarea space se activeaza modul attack pt toti cactusii    
        if(cactusAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cactusAnimator.SetTrigger("TrAttack");

            }
        }


        //incercare punct c)
        /*GameObject[] cactuses = GameObject.FindGameObjectsWithTag("Cactus");

        foreach(GameObject cactus in cactuses)
        {
            if(cactus != gameObject)
            {
                float distance = Vector3.Distance(transform.position, cactus.transform.position);
                if(distance <= detectionDistance)
                {
                    cactusAnimator.SetTrigger("TrAttack");
                    break;
                }
            }
        }*/

    }
}
