using UnityEngine;

public class CompletedPipePositionRandomizer : MonoBehaviour
{
    public float range = 1;
    private float positionX;

    // Start is called before the first frame update
    void Start()
    {
        positionX = transform.position.x;
        RandomizeHeight();
    }

    public void RandomizeHeight()
    {
        transform.position = new Vector3 (positionX, transform.position.y, transform.position.z);
        transform.Translate(0, Random.Range(-range, range), 0);
        Debug.Log("random");
    }
}
