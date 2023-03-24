using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 700;
    public int Lives;
    [SerializeField]private Animator animatorHeart;
    [SerializeField]private Animator animatorScore;
    [SerializeField]private LevelManager levelManager;
    [SerializeField]private Transform LeftBound;
    [SerializeField]private Transform RightBound;
    public AudioSource wrongSound;
    public AudioSource correctSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < LeftBound.position.x){
            transform.position = new Vector2(LeftBound.position.x, transform.position.y);
        }
        if(transform.position.x > RightBound.position.x){
            transform.position = new Vector2(RightBound.position.x, transform.position.y);
        }

        MoveCharacter();
        
    }
    void MoveCharacter(){
        // character can only move horizontally
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy"){
            StartCoroutine(PlayAnimation(animatorHeart));
            wrongSound.Play();
            Lives--;
            if(Lives <= 0){
                levelManager.GameOver();

            }
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Food"){
            correctSound.Play();
            levelManager.AddScore(10);
            StartCoroutine(PlayAnimation(animatorScore));
        }
        Destroy(other.gameObject);
    }

    IEnumerator PlayAnimation(Animator animator){
        animator.SetBool("play", true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("play", false);
    }
    


}
