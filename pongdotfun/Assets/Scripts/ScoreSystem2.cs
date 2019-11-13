using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreSystem2 : MonoBehaviour
{
    public int scoreValue2;
    public Text ScoreText2;
    public GameObject Ball;
    public GameObject Slab;
    public GameObject Slab2;
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue2 = 0;
        ScoreText2.text = "Score: 0";
        Slab.GetComponent<Rigidbody2D>();
        Slab2.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.x <= -11.38f && Ball)
        {
            scoreValue2 += 1;
            ScoreText2.text = "Score: " + scoreValue2;
            Ball.transform.position = new Vector2(0, 0);
            Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)).normalized * speed;
            Slab.transform.position = new Vector2(8, 0);
            Slab2.transform.position = new Vector2(-8, 0);
        }
        if (scoreValue2 >= 11)
        {
            SceneManager.LoadScene("winscreen2");
        }
    }
}
