using UnityEngine;

public class FlyingDragon : MonoBehaviour
{
    [Header("目標")]
    public Transform target;
    [Header("速度"), Range(0, 100)]
    public float speed = 5.5f;



    private void Start()
    {
        target = GameObject.Find("跟隨座標").transform;
    }

    private void LateUpdate()
    {
       Follow();
    }

    private void Follow()
    {
        Vector3 posTarget = target.position;
        Vector3 posFlyingDragon = transform.position;

        transform.position = Vector3.Lerp(posFlyingDragon, posTarget, 0.5f * speed * Time.deltaTime);

        posTarget.y = posFlyingDragon.y;
        transform.LookAt(posTarget);
    }

}
