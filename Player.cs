using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    public float lifeTime = 100;
    public GameObject score;

    void Start()
    {
        
    }

    void Update()
    {
        Warm(-Time.deltaTime);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        if (lifeTime<=0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Warm(float warmTime)
    {
        lifeTime = lifeTime + warmTime;
        score.GetComponent<TextMeshProUGUI>().text = lifeTime.ToString();
    }

}
