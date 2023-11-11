using System;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject[] benda;
    
	private int i;
    float min;
    float max;
    private float y;
	
	private void Start()
	{
		i = -1;
		Invoke("spawn", 0.5f); //time to spawn at start
        min = 0.24f;
        max = 0.39f;
	}
	
	private void Update()
	{
	}
	
	private void spawn()
	{
		int putar;

		float time = UnityEngine.Random.Range(min, max);
		float value = UnityEngine.Random.value;
			
			i = UnityEngine.Random.Range(0, 2);
		if (i == 0) {
			y = -4.17f;
			putar=0;
		} else {
			y=4.07f;
			putar=180;
		}

		Quaternion rotate = Quaternion.identity;
		rotate.eulerAngles = new Vector3(0, 0, putar);


		UnityEngine.Object.Instantiate(this.benda[i], new Vector3(base.transform.localPosition.x, this.y, base.transform.localPosition.z), rotate);
		base.Invoke("spawn", time);

	}
}
