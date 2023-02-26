using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public float speed = 7f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.transform.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        MonsterController mCon = target.GetComponent<MonsterController>();
        mCon.TakeDamage(3);
        Destroy(gameObject);
    }

}
