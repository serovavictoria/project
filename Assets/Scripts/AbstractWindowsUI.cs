using UnityEngine;

public abstract class AbstractWindowsUI : MonoBehaviour
{
    public void CloseWindows()
    {
        gameObject.SetActive(false);
    }

    public void OpenWindows()
    {
        gameObject.SetActive(true);
    }
}
