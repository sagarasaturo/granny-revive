using UnityEngine;

public class GrannyAI : EnemyAI
{
    float speed;
    float hearingRange;

    protected override void Start()
    {
        base.Start();
        speed = difficulty.GrannySpeed();
        hearingRange = difficulty.GrannyHearingRange();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        // Sound detection
        if (distance <= hearingRange)
        {
            MoveToPlayer();
        }
    }

    void MoveToPlayer()
    {
        Vector3 dir = (player.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}using UnityEngine;

public class GrandpaAI : EnemyAI
{
    float visionDistance;
    float visionAngle;

    protected override void Start()
    {
        base.Start();
        visionDistance = difficulty.GrandpaVisionDistance();
        visionAngle = difficulty.GrandpaVisionAngle();
    }

    void Update()
    {
        Vector3 dir = player.position - transform.position;
        float dist = dir.magnitude;

        if (dist > visionDistance) return;

        float angle = Vector3.Angle(transform.forward, dir);

        if (angle < visionAngle / 2f)
        {
            LookAtPlayer();
        }
    }

    void LookAtPlayer()
    {
        Vector3 lookDir = player.position - transform.position;
        lookDir.y = 0;
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(lookDir),
            Time.deltaTime * 2f
        );
    }
}
