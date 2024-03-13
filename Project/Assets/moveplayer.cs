using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{
    public static string haveKey = "n";

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*3, Input.GetAxis("Vertical")*3);
    }
        
        
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("key"))
        {
            haveKey = "y";
        }
    }

    private void OnCollisionEnter2D(Collision2D door)
    {
        if ((door.gameObject.tag == "door") && (haveKey == "y")) // Corrected variable name to 'haveKey'
        {
            SceneManager.LoadScene("winscreen");
        }
    }   


}
