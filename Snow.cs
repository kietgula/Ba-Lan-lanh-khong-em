using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    public float fallSpeed = 0.01f;
    public float warm = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * fallSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ri")
        {
            collision.gameObject.GetComponent<Player>().Warm(warm);
            this.transform.position = new Vector3(Random.Range(-9f, -7.5f), 8, 0);
        }
        if (collision.gameObject.name=="Hell")
            Destroy(this.gameObject);
    }

}
