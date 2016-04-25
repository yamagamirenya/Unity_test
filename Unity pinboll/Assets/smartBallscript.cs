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

        


        MoveCube();

        rigidbody.AddForce(0f, 0f, -1.5f);
        if (button)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                power += 0.01f;
                if (power > 1f)
                {
                    power = 0.25f;
                }
                renderer.material.color = new Color(1f, power, 0f);
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0f, 0f, power * 3000f));
            power = 0f;
            renderer.material.color = Color.red;
            button = false;
        }
    }

    void MoveCube()
    {
        GameObject[] ob_cubes;

        ob_cubes = GameObject.FindGameObjectsWithTag("ob_cube");
        foreach (GameObject obj in ob_cubes)
        {
            obj.transform.Rotate(new Vector3(0f, 5f, 0f));
        }
    }

    

   
}
