using UnityEngine;

public abstract class AbstractWindowUI : MonoBehaviour
{
    public virtual void CloseWindow()
    {
        gameObject.SetActive(false);
    }

    public virtual void OpenWindow()
    {
        gameObject.SetActive(true);
    }
}
