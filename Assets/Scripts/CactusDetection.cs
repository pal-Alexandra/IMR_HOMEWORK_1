using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDetection : MonoBehaviour
{

    private Animator cactusAnimator;

    public GameObject objectToFollow;
    public float detectionDistance = 0.5f;


    private void Start()
    {

        cactusAnimator = GetComponent<Animator>();
    }

    private void Update()
    {

        //pentru testarea punctului b) <=> la apasarea space se activeaza modul attack pt toti cactusii    
        /*if(cactusAnimator != null)
          {
              if (Input.GetKeyDown(KeyCode.Space))
              {
                 cactusAnimator.SetTrigger("TrAttack");

              }
         }*/


        if (objectToFollow != null)
        {
            float distance = Vector3.Distance(transform.position, objectToFollow.transform.position);
            if (distance <= detectionDistance)
            {
                Debug.Log("hei1");
                cactusAnimator.SetTrigger("TrAttack");

            }
            else
            {
                Debug.Log("hei2");
                cactusAnimator.SetTrigger("TrIdle");
            }
        }

    }
}