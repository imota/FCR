using UnityEngine;

/// <summary> Makes an object follow a given object at a given offset value. </summary>
public class FollowObject : MonoBehaviour
{
    private Vector3 followedPos;

    public GameObject followed;
    public Vector3 offset;

    void Start()
    {
        UpdatePosition();
    }

    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {
        if (followed != null)
        {
            followedPos = followed.transform.position;
            transform.position = followedPos + offset;
        }
    }
}