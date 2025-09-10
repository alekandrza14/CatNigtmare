using UnityEngine;

public class HideBarier : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<fristPersonControler>())
        {
            obj.SetActive(false);
        }
    }
}
