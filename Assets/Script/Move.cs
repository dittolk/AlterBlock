using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float gravity;
    //audio play
    public AudioSource jumpSound;
    
    private void Start()
    {
        gravity = GetComponent<Rigidbody2D>().gravityScale;
    }

    private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
            jumpSound.Play();
            if (GetComponent<Rigidbody2D>().gravityScale >= 0) {
                GetComponent<Rigidbody2D>().gravityScale = -gravity;
            }else
            {
                GetComponent<Rigidbody2D>().gravityScale = gravity;
            }
		}
	}
}
