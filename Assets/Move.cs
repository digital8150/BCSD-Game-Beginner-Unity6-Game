using UnityEngine;

public class Move : MonoBehaviour
{

    Vector3 traget = new Vector3(5.91f, 1.49f, 3.7f);

    // Update is called once per frame
    void Update()
    {

        //transform.position = Vector3.MoveTowards(transform.position, traget, 0.1f);

        /*
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, traget, ref velo, 0.1f);
        */

        /*
        transform.position = Vector3.Lerp(transform.position, traget, 0.05f);
        */

        transform.position = Vector3.Slerp(transform.position, traget, 0.05f);
    }
}
