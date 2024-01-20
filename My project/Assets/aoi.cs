using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aoi : MonoBehaviour
{
    private Rigidbody rb;
    private BoxCollider2D coll;

    private float dirx = 0f;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    //serialize is for adding a custom button in the unity
    [SerializeField] private float moveforce = 7f, jumpforce = 12f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<BoxCollider2D>();

        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    //private
    public void Update()
    {
        dirx = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirx * moveforce, rb.velocity.y);
        if (Input.GetButtonDown("Jump") )
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }

    }
   