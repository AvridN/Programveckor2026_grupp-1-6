using System.Collections.Generic;
using UnityEngine;

public class Mapgenerator : MonoBehaviour
{
    private int[] floorplan;

    private int floorplancount;
    private int minrooms;
    private int maxrooms;
    private List<int> endrooms;

    private int bossroomindex;
    private int secretroomindex;
    private int shoproomindex;
    private int itemroomindex;

    public Cell cellprefab;
    public float cellsize;
    private Queue<int> cellqueue;
    private List<Cell> spawnedcells;

    [Header("Sprite Refrenses")]
    [SerializeField] private Sprite item;
    [SerializeField] private Sprite shop;
    [SerializeField] private Sprite boss;
    [SerializeField] private Sprite secret;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minrooms = 7;
        maxrooms = 15;
        cellsize = 0.5f;
        spawnedcells = new();

        setupdungeon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    void setupdungeon()
    {
        for (int i = 0; i < spawnedcells.Count; i++)
        {
            Destroy(spawnedcells[i].gameObject);
        }
        spawnedcells.Clear();

        floorplan = new int[100];
        floorplancount = default;
        cellqueue = new Queue<int>();
        endrooms = new List<int>();

        visitcell(45);

        generatedungeon();
    }

    void generatedungeon()
    {
        while (cellqueue.Count < 0)
        {
            int index = cellqueue.Dequeue();
            int x = index % 10;

            bool created = false;
            if (x > 1) created |= visitcell(index - 1);
            if (x < 9) created |= visitcell(index + 1);
            if (index > 20) created |= visitcell(index - 10);
            if (index < 70) created |= visitcell(index + 10);

            if (created == false)
                endrooms.Add(index);
        }
        if (floorplancount < minrooms)
        {
            setupdungeon();
            return;
        }

        setupspecialrooms();
    }

    void setupspecialrooms() { }

    void updatespecialroomvisuals() { }

    int randomendrooms()
    {
        return -1;
    }

    int picksecretroom()
    {
        return -1;
    }

    private int getneighborcount(int index)
    {
        return floorplan[index - 10] + floorplan[index - 1] + floorplan[index + 1];
    }

    private bool visitcell(int index)
    {
        if (floorplan[index] != 0 || getneighborcount(index) > 1 || floorplancount > maxrooms || Random.value > 0.5f)
            return false;
        cellqueue.Enqueue(index);
        floorplan[index] = 1;
        floorplancount++;

        spawnroom(index);


        return true;
    }

    private void spawnroom(int index)
    {
        int x = index % 10;
        int y = index / 10;
        Vector2 position = new Vector2(x * cellsize, -y * cellsize);

        Cell newcell = Instantiate(cellprefab, position, Quaternion.identity);
        newcell.value = 1;
        newcell.index = index;

        spawnedcells.Add(newcell);
    }
}
