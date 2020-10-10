using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMove : MonoBehaviour
{
    PlayerMaster master;
    NavMeshAgent nma;

    private const float epsilon = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        master = GetComponent<PlayerMaster>();
    }

    void SetMoveDestination(RaycastHit target)
    {
        nma.SetDestination(target.point);
        master.playerAnimation.SetWalkingState(true);
    }

    void CheckDestination()
    {
        float dist = nma.remainingDistance; 

        if (nma.pathStatus == NavMeshPathStatus.PathComplete && 
            nma.remainingDistance < epsilon)
        {
            master.playerAnimation.SetWalkingState(false);
        }
    }

    void CheckInput()
    {
        if (Input.GetMouseButton(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print("Trafiłem w " + hit.point);
                SetMoveDestination(hit);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        CheckDestination();
    }
}
