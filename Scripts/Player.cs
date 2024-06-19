using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public bool Jump;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 1f);
        if (hit.collider != null)
        {
            Jump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Jump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5f, 0);
            Jump = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

