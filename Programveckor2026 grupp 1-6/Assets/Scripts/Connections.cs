using System.Collections.Generic;
using UnityEngine;

public class Bosshuvud : MonoBehaviour
{
    public float speed = 3.0f;
    public List<Transform> BodySegments;
    public float distance = 0.4f;
    public GameObject BosshuvudPrefab;
    Vector2 currentDirection;

    private List<Vector3> positionhistory = new List<Vector3>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeDirection();

        InvokeRepeating(nameof(ChangeDirection), 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        MoveBody();
        transform.position += (Vector3)currentDirection * speed * Time.deltaTime;

    }

    void Move()
    {
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        transform.position += (Vector3)dir * speed * Time.deltaTime;
        positionhistory.Insert(0, transform.position);


    }
    void MoveBody()
    {
        for (int i = 0; i < BodySegments.Count; i++)
        {
            Vector3 point = positionhistory[Mathf.Min(i * 10, positionhistory.Count - 1)];
            BodySegments[i].position = Vector3.Lerp(BodySegments[i].position, point, Time.deltaTime * 10f);

        }
    }
    void die()
    {
        int splitindex = BodySegments.Count / 2;
        CreateNewBoss(BodySegments.GetRange(0, splitindex));
        CreateNewBoss(BodySegments.GetRange(splitindex, BodySegments.Count - splitindex));


        Destroy(gameObject);

    }

    void CreateNewBoss(List<Transform> segments)
    {
        if (segments.Count == 0) return;


        GameObject NewHead = Instantiate(BosshuvudPrefab, segments[0].position, Quaternion.identity);

        Bosshuvud nyboss = NewHead.GetComponent<Bosshuvud>();

        segments.RemoveAt(0);

        nyboss.BodySegments = segments;
    }

    void ChangeDirection()
    {
        currentDirection = Random.insideUnitCircle.normalized;

    }


}
