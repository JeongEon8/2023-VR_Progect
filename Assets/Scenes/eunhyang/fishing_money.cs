using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fishing_money : MonoBehaviour
{
    TMP_Text myMoney;
    public int count = 0;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hell");
        myMoney = GameObject.Find("Money").GetComponent<TextMeshProUGUI>();
        myMoney.text = "$ " + count;
    }

    // Update is called once per frame
    void Update()
    {
        myMoney.text = "$ " + count;
    }

    /*void plusMoney()
    {
        count += 100;
        //���� �߰�
    }*/

   /* public void select() // select ���� ��
    {

        count += 100;
        Debug.Log(count);
        //other.gameObject.SetActive(false); //������ ��Ȱ��ȭ 
        /*if(other.tag == "fish"){

                    count += 100;
                    other.gameObject.SetActive(false); //������ ��Ȱ��ȭ 

                }
    }
*/
    void OnTriggerEnter(Collider other)
     { // select ���� ��
     Debug.Log("trigger");
     if (other.tag == "fish"){

         count += 100;
         Debug.Log(count);
         other.gameObject.SetActive(false); //������ ��Ȱ��ȭ 
         audioSource.Play();

        }

    }
}
