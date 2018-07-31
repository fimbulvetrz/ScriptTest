using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
    private int mp = 53;
    

    public void Magic(){

        if (mp >= 5)
        {
            mp -= 5;

            Debug.Log("魔法攻撃した。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    

    }


public class Test : MonoBehaviour {


        void Start() {

        int[] array = { 10, 20, 30, 40, 50 };

        for(int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);

        }

           for(int i = array.Length - 1; i >= 0; i--)
           {
               Debug.Log(array[i]);

           }
        


        Boss boss = new Boss();

        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();

    }




// Update is called once per frame
    void Update(){

    }
}
