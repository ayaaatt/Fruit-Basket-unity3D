using UnityEngine;

public class DragObject : MonoBehaviour
{
    private float distance;

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = ray.GetPoint(distance);
    }
}
