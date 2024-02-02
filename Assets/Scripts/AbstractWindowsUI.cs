using UnityEngine;

public abstract class AbstractWindowsUI : MonoBehaviour
{
    public virtual void CloseWindows()
    {
        gameObject.SetActive(false);
    }

    public virtual void OpenWindows()
    {
        gameObject.SetActive(true);
    }
}
