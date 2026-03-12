using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 2000f;
    [SerializeField] private float horizontalSpeed = 500f;
    [SerializeField] private TextMeshProUGUI scoretext;
    private float score = 0f;

    private void Awake()
    {
        
        rb = this.GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        EndlessPlayerForwardMovement();
        PlayerInpurControl();

    }
    void Update()
    {
        ScoreIncrement();
    }

    private void EndlessPlayerForwardMovement()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
    }

    private void PlayerInpurControl()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A)){

            rb.AddForce(-horizontalSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            rb.AddForce(horizontalSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")|| collision.gameObject.CompareTag("Below Ground"))
        {
            Invoke("RestartLevel", 0.5f);
        }
    }

    private  void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ScoreIncrement()
    {
        score += Time.deltaTime * 5f;
        scoretext.text = "Score: " + Mathf.FloorToInt(score);
    }
}
