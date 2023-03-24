using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimation : MonoBehaviour
{
    [SerializeField] private Animator animatorLeft;
    [SerializeField] private Animator animatorRight;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.A ) || Input.GetKey(KeyCode.LeftArrow)){
            animatorLeft.SetBool("play", true);
            animatorRight.SetBool("play", false);
        }
        else if(Input.GetKey(KeyCode.D ) || Input.GetKey(KeyCode.RightArrow)){
            animatorRight.SetBool("play", true);
            animatorLeft.SetBool("play", false);
        }
        else{
            animatorLeft.SetBool("play", false);
            animatorRight.SetBool("play", false);
        }
        
    }
}
