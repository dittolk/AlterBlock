using System;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
	private Rigidbody2D moving;
    

    private void Start()
	{
        this.moving = base.GetComponent<Rigidbody2D>();
        Invoke("Faster", 0.5f); //time to spawn at start
    }
	
	private void Update()
	{
              
        this.moving.velocity = new Vector2(Box.speed, 0f);
        

		if (base.transform.localPosition.x < -9.5f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	
	private void OnCollisionEnter2D(Collision2D testing)
	{
		
	}

    private void Faster()
    {
        if (Score.score % 20 == 0 && !Box.status && Score.score != 0 && Score.score <= 140)
        {
            Box.speed -= 3f;
            Box.status = true;
            Move.gravity = 2f;
            
        }else if (Score.score %20 == 1)
        {
            Box.status = false;
        }
        base.Invoke("Faster", 0.5f);
    }
}