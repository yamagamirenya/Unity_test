using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.UI;



public partial class goal : MonoBehaviour
{
   GameObject[] goals;
   public Text score;


    void OnTriggerEnter(Collider collider)
    {

        goals = GameObject.FindGameObjectsWithTag("goal");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "goal")
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            int n = 1;
            foreach (GameObject obj in goals)
            {
                if (obj == collider.gameObject)
                {
                   // score.text = "point:" + (n * 100);
                    ParticleSystem ps = collider.gameObject.
                        GetComponent<ParticleSystem>();
                    ps.Play();

                    GameObject[] cubes;
                    cubes = GameObject.FindGameObjectsWithTag("ob_cube");
                    foreach (GameObject tako in cubes)
                    {
                        Vector3 pos =tako.transform.position;
                        pos.y += -10;
                        transform.position = pos;
                    }
                   
                }
                n++;
            }
        }
    }

}
