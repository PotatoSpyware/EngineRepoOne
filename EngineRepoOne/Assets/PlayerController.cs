using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] GameObject die;
    [SerializeField] GameObject win;
    int boost = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = 1f*boost;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -1f*boost;
        }
        else
        {
            rb.linearVelocityX = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            die.SetActive(true);
        }

        else if (collision.collider.gameObject.tag == "Boost")
        {
            boost = 2;
        }

        else if (collision.gameObject.tag == "Win")
        {
            win.SetActive(true);
        }
    }
}
