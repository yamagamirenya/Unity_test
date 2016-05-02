using UnityEngine;
using System.Collections;

public class Obstacle_move : MonoBehaviour
{

    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject Obstacle4;
    public GameObject Obstacle5;


    float n = 0;
    float r = 0;
    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {

        n += 0.1f;
        r += 0.01f;
        Vector3 pos = Obstacle1.transform.position;
        pos.x = Mathf.Sin(n)-3;
        Obstacle1.transform.position = pos;
        Vector3 pos2 = Obstacle2.transform.position;
        pos2.x = Mathf.Sin(n)+4;
        Obstacle2.transform.position = pos2;
        Vector3 pos3 = Obstacle3.transform.position;
        pos3.x = Mathf.Sin(n)-5;
        Obstacle3.transform.position = pos3;
        Vector3 pos4 = Obstacle4.transform.position;
        pos4.x = Mathf.Sin(n)+2;
        Obstacle4.transform.position = pos4;
        Vector3 pos5 = Obstacle5.transform.position;
        pos5.x = Mathf.Sin(n)-5;
        Obstacle5.transform.position = pos5;


        Obstacle1.transform.Rotate(new Vector3(0, Mathf.Sin(r) * 360, 0));
        Obstacle2.transform.Rotate(new Vector3(0, Mathf.Sin(r) * 360, 0));
        Obstacle3.transform.Rotate(new Vector3(0, Mathf.Sin(r) * 360, 0));
        Obstacle4.transform.Rotate(new Vector3(0, Mathf.Sin(r) * 360, 0));
        Obstacle5.transform.Rotate(new Vector3(0, Mathf.Sin(r) * 360, 0));


    }
}
