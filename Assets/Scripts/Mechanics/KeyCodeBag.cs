using System.Collections.Generic;
using UnityEngine;

public class KeyCodeBag : MonoBehaviour
{
    public List<KEY_CODE> KeyCodes = new List<KEY_CODE>();

    public void AddKey(KEY_CODE key)
    {
        KeyCodes.Add(key);
    }


    public int GetCountOfType(KEY_CODE codeToGetCount)
    {
        int count = 0;

        foreach(KEY_CODE  code in KeyCodes)
        {
            if(code == codeToGetCount)
            {
                count = count + 1;
            }
        }
        Debug.Log("LA CANTIDAD DE " + codeToGetCount + " ES " + count);
        return count;
    }


    public void TestFunctionGetCountOfType()
    {
        GetCountOfType(KEY_CODE.PUERTA1);
    }

}


public enum KEY_CODE
{
    PUERTA1,
    PUERTA2,
    PUENTE1,
    AVISMO2,
    Star
}