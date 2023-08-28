using UnityEngine;

public class Paint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MainUI.Instance.Button.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        MainUI.Instance.Button.SetActive(false);
    }
}
