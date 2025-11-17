using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class point : MonoBehaviour
{
    public TMP_Text txt;
    public int points = 0;
    public string score = "Score: ";
    public bool gameover = false;
    public string over = "gameover";
    public int points2 = 0;
    public string score2 = "Score: ";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
        points2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == true)
        {
            this.GetComponent<TMP_Text>().text = over;
        }
        //this.GetComponent<TMP_Text>().text = "point";
    }

    public void addpoints(int point)
    {
        points2 += point;
        this.GetComponent<TMP_Text>().text = score2 + points2.ToString();
        points += point;
        this.GetComponent<TMP_Text>().text = score + points.ToString();
    }
}
