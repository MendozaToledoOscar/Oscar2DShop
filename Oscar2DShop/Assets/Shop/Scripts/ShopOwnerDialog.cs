using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOwnerDialog : MonoBehaviour
{
    public List<GameObject> dialogs;

    public int index;

    private void Start()
    {
        index = dialogs.Count - 1;
        dialogs[index].SetActive(true);
    }

    private void OnDisable()
    {
        dialogs[index].SetActive(false);
        index++;
        if (index > dialogs.Count-1)
            index = 0;
        dialogs[index].SetActive(true);
    }
}
