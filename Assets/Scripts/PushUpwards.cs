using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushUpwards : MonoBehaviour
{
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private float totalForce;
    [SerializeField]
    private int Side;
    [SerializeField]
    private int PosX;
    [SerializeField]
    private int PosZ;
    [SerializeField]
    private InsideList ColliderScript = null;

    public void Upgrade()
    {
        totalForce = totalForce + 0.1f;
    }

    public void Push()
    {
        List<GameObject> rings = ColliderScript.getRings();
        foreach (GameObject ring in rings)
        {
            float sideForce = (float)Math.Round((ring.transform.position.x - this.transform.position.x) * 8,2);
            float upForce = totalForce - Mathf.Abs(sideForce);
            float power = 0.041f * (24 - ring.transform.position.y);
            Debug.Log("Launching " + ring.gameObject.name + " launched with side: " + sideForce*power + " Up: "+ upForce*power);
            ring.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(sideForce * power , upForce * power, 0), new Vector3(PosX, 0, PosZ), ForceMode.Impulse);
            //ring.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(5, 45, 0), new Vector3(PosX, 0, PosZ), ForceMode.Impulse);
        }
    }
}
