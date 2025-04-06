using UnityEngine;

public class KeyboardInput : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0)
            );
    }
}
