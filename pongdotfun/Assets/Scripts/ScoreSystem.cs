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
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        ScoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if(Ball.transform.position.x <= -11.38f && Ball)
        {
            scoreValue += 1;
            ScoreText.text = "Score: " + scoreValue;
            Destroy(Ball.gameObject);
            Ball = Instantiate(Ball, new Vector3(0, 0, 0), new Quaternion());
        }
        if(scoreValue > 11)
        {
            SceneManager.LoadScene("winscreen");
        }
    }
}
