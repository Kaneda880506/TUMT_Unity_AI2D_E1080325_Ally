using UnityEngine;
using UnityEngine.Audio;    //引用 音頻 API
using UnityEngine.UI;       //引用 介面 API
using UnityEngine.SceneManagement;

public class GameManagel : MonoBehaviour 
{
  //定義欄位(宣告變數)
  //修飾詞 類型 名稱 結尾
  //public 公開 private 私人
    public AudioMixer mixer;


  public Slider loading;

  //定義方法(宣告函式)
  //修飾詞 類型 名稱 (參數) {敘述}
  public void SetVBGM(float value)
  {
   //音效管理器.設定浮點數("名稱"，值)
   mixer.SetFloat("VBGM",value);
   }
   public void SetVSFX(float value)
  {
   //音效管理器.設定浮點數("名稱"，值)
   mixer.SetFloat("VSFX",value);

   }

   private void OnTriggerEnter(Collider other){
   if(other.name=="Magic fire 2"){
			print("VVVVVVVVV");
		}
   }
	public void Play(){
		SceneManager.LoadScene("遊戲場景");
		//StartCoroutine();    //啟動協同程序(協同程序方法名稱());
		
	}	



 }
