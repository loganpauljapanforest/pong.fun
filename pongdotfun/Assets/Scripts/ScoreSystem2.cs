using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreSystem2 : MonoBehaviour
{
    public int scoreValue2;
    public Text ScoreText;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue2 = 0;
        ScoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.x >= 11.38f && Ball)
        {
            scoreValue2 += 1;
            ScoreText.text = "Score: " + scoreValue2;
            Ball.transform.position = new Vector2(0, 0);
            Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Ball.GetComponent<Rigidbody2D>().angularVelocity = 0;
            Ball.transform.rotation = new Quaternion();
        }
        if (scoreValue2 > 11)
        {
            SceneManager.LoadScene("winscreen2");
        }
    }
}
