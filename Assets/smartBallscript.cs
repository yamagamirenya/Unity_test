using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Collections;

public partial class smartBallscript : MonoBehaviour
{

    float power = 0f;
    bool button = true;


    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Renderer renderer = GetComponent<Renderer>();
        


        if (button)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                power += 0.05f;
                if (power > 1f)
                {
                    power = 0.5f;
                }
                renderer.material.color = new Color(1f, power, 0f);
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                rigidbody.AddForce(new Vector3(0f, 0f, power * 5000f));
                power = 0f;
                renderer.material.color = Color.red;
                button = false;
            }
        }





    }
}