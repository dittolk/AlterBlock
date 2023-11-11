using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{
    public static float speed;
    public static bool status;
    // Use this for initialization
    void Start()
    {
        speed = -10.5f;
        status = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.tag == "SpikeBawah") || (other.gameObject.tag == "SpikeAtas"))
        {
            Application.LoadLevel(3);
        }
    }
}
