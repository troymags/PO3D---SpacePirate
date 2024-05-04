using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{

    public Animator animator;
    public bool isOpen = false;
    public float delay = 2f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        delay -= Time.deltaTime;

        if (Input.GetKey(KeyCode.E) && isOpen == false)
        {
            animator.SetFloat("direction", 1);
            animator.SetTrigger("Open");
            if (delay <= 0)
            {
                isOpen = true;
                delay = 2f;
            }
        }

        else if (Input.GetKey(KeyCode.E) && isOpen == true)
        {
            animator.SetFloat("direction", -1);
            animator.SetTrigger("Open");
            if (delay <= 0)
            {
                isOpen = false;
                delay = 2f;
            }

        }

    }

}
