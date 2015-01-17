using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace YukariGames
{

    /// <summary>
    /// テキストファイルから、文字列を読み込むためのクラス
    /// </summary>

    class TextLoadClass
    {
        //テキストから文字列を取得する関数、あるサイトからの流用
        //最後にListを返すので、呼び出す側でもListを宣言し、受け取る事
        public static ArrayList LoadTexte(ref ArrayList al)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ドキュメントまでのパス
            string Resource = @"\GitHub\kinect2014\YudukiProject\text";//テキストデータの場所
            string line = ""; //文字列を読み込むためのstring型変数
            al = new ArrayList();//文字を格納するための変数、List配列、オブジェクト型
            try
            {
                //StreamReader、恐らく名前の通りにストリームを取得する変数型だと思われる、改行をnullとみなすので、改行で区切りとなる
                using (StreamReader sr = new StreamReader(rootPath+Resource+"UserVoice.txt", Encoding.GetEncoding("UTF-8")))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        al.Add(line);
                    }
                }
            }catch (Exception e) {
                //エラー処理、ファイルが見つからなかった場合は、コンソールに表示！・・・表示するコンソールは無いけどね。
                Console.WriteLine(e.Message);
            }
            return al;
        }
    }
}
