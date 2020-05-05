using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdowncontroller : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    private float timerstart;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime>0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "Shoot!";
        timerstart = Time.time;

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }

    public float returntime()
    {
        return timerstart;
    }
}
