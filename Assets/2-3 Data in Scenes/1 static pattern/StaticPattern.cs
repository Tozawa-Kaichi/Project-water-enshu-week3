using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// static 変数を使って「シーンをまたいで値を渡す」方法
/// </summary>
public class StaticPattern : MonoBehaviour
{
    /// <summary>プレイヤーの名前。これをシーンまたぎで渡す</summary>
    public static string s_name = "ああああ";
    /// <summary>メッセージを表示するテキスト</summary>
    [SerializeField] Text m_text = default;
    public static Vector3 bird ;
    

    /// <summary>
    /// 名前を保存する
    /// </summary>
    /// <param name="input"></param>
    public void SetName(InputField input)
    {
        StaticPattern.s_name = input.text;
        bird = GameObject.Find("Bird").transform.position;
    }

     
    void Start()
    {
        
        if (m_text)
        {
           
            GameObject.Find("Bird").transform.position = bird;
            
            m_text.text = $"よくぞ来た！勇者 <b><color=red>{StaticPattern.s_name}</color></b> よ！";
            Debug.Log(m_text.text);
        }
    }
}
