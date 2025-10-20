using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class point : MonoBehaviour
{
    public TMP_Text txt;
    public int points = 0;
    public string score = "Score: ";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<TMP_Text>().text = "point";
    }

    public void addpoints(int point)
    {
        points += point;
        this.GetComponent<TMP_Text>().text = score + points.ToString();
    }
}
