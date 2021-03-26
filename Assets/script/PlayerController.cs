using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sr;
    Rigidbody2D rb2d;
    public GameObject thePrefab;
    public LayerMask grassLayer;
    public int alea;
    private Vector3 m_Velocity = Vector3.zero;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;
    private bool m_FacingRight = true;
    private bool m_Grounded; 
    public int potion;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    public Vector2 speed = new Vector2(50,50);

    // Update is called once per frame

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")* speed.x, 0.8f) 
                                    ,Mathf.Lerp(0, Input.GetAxis("Vertical")* speed.x, 0.8f));
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Tilemap")
        {
            alea = Random.Range(1,30);
            if(alea <= 7)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
        if(collider.tag == "potion")
        {
            potion = potion + 1;
            GameManager.Instance.p.potion = GameManager.Instance.p.potion + 1;
        }
        
    }

    }
    


