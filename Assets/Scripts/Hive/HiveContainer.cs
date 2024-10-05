using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveContainer : MonoBehaviour
{
    [SerializeField] KeyCode CreateBugsKey = KeyCode.Z;
    [SerializeField] List<Bug> Bugs;
    [SerializeField] GameObject BugPrefab;
    [SerializeField] GameObject Cursor;

    int bugsCount = 0;
    // Start is called before the first frame update
    private void CreateBugs(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject prefab = Instantiate(BugPrefab);
            prefab.transform.SetParent(transform, false);
            Bugs.Add(BugPrefab.GetComponent<Bug>());

            prefab.GetComponent<HiveOffsetChange>().offset = new(Random.value, Random.value);

            prefab.GetComponent<HiveOffsetChange>().Joint.connectedBody = Cursor.GetComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        var mw = Input.GetAxis("Mouse ScrollWheel");
        if (Input.GetKey(CreateBugsKey))
        {
            if (mw != 0)
                bugsCount+= (int)(mw*10);
            
            Debug.Log("count of bugs =" + bugsCount);
        }

        if (Input.GetKeyUp(CreateBugsKey))
        {
            CreateBugs(bugsCount);
            Debug.Log("Created bugs =" + Bugs.Count);
            bugsCount = 0;
        }

    }
}
