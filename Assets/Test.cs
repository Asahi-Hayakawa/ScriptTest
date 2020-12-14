using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public class Boss
    {
        // 体力
        private int hp = 100;
        // 攻撃力
        private int power = 25;
        // マジックポイント
        private int mp = 53;
        // マジックポイント消費量
        private int mpConsumption = 5;

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

        // 魔法攻撃用の関数
        public void Magic()
        {
            if (this.mp < this.mpConsumption)
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
            else
            {
                this.mp -= this.mpConsumption;
                {
                    Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
                }
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // チャプター3課題
        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] intArray = {1, 2, 3, 4, 5};

        // for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }

        // for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = intArray.Length - 1; i >= 0; i--)
        {
            Debug.Log(intArray[i]);
        }

        // Magic関数を呼び出して、魔法を使ってください
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        // Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示することを確認してください
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
