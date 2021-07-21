using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// static 変数を使って「シーンをまたいで値を渡す」方法
/// </summary>
public class StaticPattern : MonoBehaviour
{
    /// <summary>プレイヤーの名前。これをシーンまたぎで渡す</summary>
    public static string m_name = "ああああ";
    /// <summary>メッセージを表示するテキスト</summary>
    [SerializeField] Text m_text = default;
    static Vector2 bird  ;
    

    /// <summary>
    /// 名前を保存する
    /// </summary>
    /// <param name="input"></param>
    public void SetName(InputField input)
    {
        StaticPattern.m_name = input.text;
    }

     
    void Start()
    {
        if (m_text)
        {
            Getposition();
            m_text.text = $"よくぞ来た！勇者 <b><color=red>{StaticPattern.m_name}</color></b> よ！";
            Debug.Log(m_text.text);
        }
    }

    public void Getposition()
    {
        Vector2 bird = GameObject.Find("Bird").transform.position;
        GameObject.Find("Bird").transform.position = bird;
    }

}
