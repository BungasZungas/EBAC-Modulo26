using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetWeenLetters = .1f;

    public string phrase;


    private void Awake()
    {
        textMesh.text = "";
    }


    [NaughtyAttributes.Button]
    public void StarType()
    {
        StartCoroutine(Type(phrase));
    }


    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach (char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetWeenLetters);
        }
    }
}
