using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Text scoretext;
    public Text timer;
    public countdowncontroller countdowncontroller;
    

    private int score = 0;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("begingame", 3);
        
    }

    void begingame()
    {
        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(enemy.gameObject);
                ScoreSys.ScoreValue += 1;
                timeElapsed = Time.time - countdowncontroller.returntime();
                timer.text = "Time: " + timeElapsed;

            }
        
       
        
    }


}
