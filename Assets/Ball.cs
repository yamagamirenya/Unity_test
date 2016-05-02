using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Ball : MonoBehaviour
{

    public GameObject button;
    public Text scoreLabel;
    public Text restart;

    

    void OnTriggerEnter(Collider other)
    {
        var goal = other.gameObject.GetComponent<Goal>();
        if (goal != null)
        {
            scoreLabel.text = goal.score.ToString();
            ParticleSystem ps = goal.GetComponent<ParticleSystem>();
            ps.Play();
            Destroy(this.gameObject);
            button.SetActive(true);
            restart.text = "restart";

        }
    }
}