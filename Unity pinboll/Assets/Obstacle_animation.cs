using UnityEngine;
using System.Collections;

public partial class Obstacle_animation : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject[] ob_cubes;

        ob_cubes = GameObject.FindGameObjectsWithTag("ob_cube");

        foreach (GameObject obj in ob_cubes)
        {
            Vector3 move = obj.transform.position;
            AnimationClip clip = new AnimationClip();
            clip.legacy = true;
            Keyframe[] keysX = new Keyframe[2];
            keysX[0] = new Keyframe(0f, move.x - 5);
            keysX[1] = new Keyframe(1f, move.x + 3);
            AnimationCurve curveX = new AnimationCurve(keysX);
            clip.SetCurve("", typeof(Transform), "localPosition.x", curveX);
            clip.wrapMode = WrapMode.PingPong;
            Keyframe[] keysY = new Keyframe[2];
            keysY[0] = new Keyframe(0f, move.y);
            keysY[1] = new Keyframe(1f, move.y);
            AnimationCurve curveY = new AnimationCurve(keysY);
            clip.SetCurve("", typeof(Transform), "localPosition.y", curveY);
            Keyframe[] keysZ = new Keyframe[2];
            keysZ[0] = new Keyframe(0f, move.z);
            keysZ[1] = new Keyframe(1f, move.z);
            AnimationCurve curveZ = new AnimationCurve(keysZ);
            clip.SetCurve("", typeof(Transform), "localPosition.z", curveZ);
            Animation animation = obj.GetComponent<Animation>();
            animation.AddClip(clip, "clip1");
            animation.Play("clip1");
        }
    }
}
