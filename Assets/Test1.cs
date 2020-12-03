using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{

    public GameObject Cube;

    public GameObject Example;

    public Transform SpawnPoint;

    public Transform SpawnPoint1;

    public Material NewMat;

    public Material NewMat1;

    public Material NewMat2;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inst();
            Inst1();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Destr();
        }
    }

    void Inst()
    {
        Cube = Instantiate(Example, SpawnPoint1.position, SpawnPoint1.rotation, transform);

        Rigidbody rigidbody = Cube.AddComponent<Rigidbody>();
        rigidbody.useGravity = true;
        Cube.GetComponent<MeshRenderer>().material = NewMat1;
        Destroy(Cube, 5);
    }

    void Inst1()
    {
        Cube = Instantiate(Example, SpawnPoint.position, SpawnPoint.rotation, transform);

        Rigidbody rigidbody = Cube.AddComponent<Rigidbody>();
        rigidbody.useGravity = true;
        Cube.GetComponent<MeshRenderer>().material = NewMat2;
        Destroy(Cube, 5);
    }

    void EnableDisable()
    {
        Cube.SetActive(!Cube.activeSelf);
    }

    void ObjAndComp()
    {
        Cube.GetComponent<MeshRenderer>().material = NewMat;
    }

    void Destr()
    {
        Destroy(Cube);
    }
}
