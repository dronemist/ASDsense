using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeScreenWhite : MonoBehaviour
{
    public Canvas canvasObject;
    float time;
    float wait_time = 10f;
    bool isWhite = false;
    // making screen white randomly after two seconds
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int rand = Random.Range(0, 10);
        if(time>wait_time && rand == 1 && !isWhite)
        {
            StartCoroutine(screenWhite());
            isWhite = true;
            canvasObject.enabled = true;
            time = 0;
        }
        wait_time -= 0.05f * Time.deltaTime;
        wait_time = Mathf.Max(5, wait_time);
    }
    IEnumerator screenWhite()
    {
        yield return new WaitForSeconds(1f);
        canvasObject.enabled = false;
        isWhite = false;
    }
}
