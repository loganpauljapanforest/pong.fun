using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public int scoreValue;
    public Text ScoreText;
    public GameObject Ball;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        ScoreText.text = "Score: 0";
        Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)).normalized*speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Ball.transform.position.x >= 11.38f && Ball)
        {
            scoreValue += 1;
            ScoreText.text = "Score: " + scoreValue;
            Ball.transform.position = new Vector2(0, 0);
            Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)).normalized*speed;
            
        }
        if(scoreValue >= 11)
        {
            SceneManager.LoadScene("winscreen");
        }
        if (Input.GetKeyDown("r"))
        {
            Ball.transform.position = new Vector2(0, 0);
            Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)).normalized*speed;
        }
    }
}
