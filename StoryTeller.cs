using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryTeller : MonoBehaviour
{
    bool musicPlay = false;
    public GameObject music;
    public GameObject Story;
    public GameObject player;
    bool warmed = false;

    float deltaTime = 0;

    void Start()
    {
        deltaTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = deltaTime + Time.deltaTime;

        if (deltaTime <= 3)
            Story.GetComponent<TextMeshProUGUI>().text = "Hej Ri";
        else if (deltaTime <= 5)
            Story.GetComponent<TextMeshProUGUI>().text = "snieg zaraz spadnie";
        else if (deltaTime <= 13)
            Story.GetComponent<TextMeshProUGUI>().text = "Widzisz te czapki i skarpetki?";
        else if (deltaTime <= 17)
            Story.GetComponent<TextMeshProUGUI>().text = "zaloz na ciepfo";
        else if (deltaTime <= 20)
        {
            Story.GetComponent<TextMeshProUGUI>().text = "pozwol mi wfaczyc muzyke";
            if (musicPlay == false)
            {
                Instantiate(music, transform.position, transform.rotation);
                musicPlay = true;
            }
        }
        else if (deltaTime <= 25)
            Story.GetComponent<TextMeshProUGUI>().text = "nastepnie....";
        else if (deltaTime <= 30)
            Story.GetComponent<TextMeshProUGUI>().text = "dzis jest dzien wietnamskich kobiet";
        else if (deltaTime <= 40)
        { 
            Story.GetComponent<TextMeshProUGUI>().text = "zycze Ci ciepfa";
            if (warmed == false)
            { 
                player.GetComponent<Player>().Warm(999999);
                warmed = true;
            }
        }

        else if (deltaTime <= 60)
        {
            Story.GetComponent<TextMeshProUGUI>().text = "To koniec. Do widzenia..";

        }
    }
}
