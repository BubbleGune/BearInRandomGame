using UnityEngine;

public class Bear : MonoBehaviour
{
    public void Movement()
    {
        transform.position = new Vector2(
                Random.Range(-3.0f, 3.0f),
                Random.Range(-3.0f, 3.0f));
    }

    
}
