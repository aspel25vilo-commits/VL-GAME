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
   
    void Start()
    {
        points = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == true)
        {
            this.GetComponent<TMP_Text>().text = over;
        }
        
    }

    public void addpoints(int point)
    {
        points += point;
        this.GetComponent<TMP_Text>().text = score + points.ToString();
    }
    
}
