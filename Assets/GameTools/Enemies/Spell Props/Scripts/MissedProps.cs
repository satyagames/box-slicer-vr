using UnityEngine;

public class MissedProps : MonoBehaviour
{     
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Prop")
        {
            GameActions.OnPropGrounded?.Invoke();
            Debug.Log("touched the ground");
            Destroy(other.gameObject);
        }
    }
}
