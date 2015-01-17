using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;


namespace csvLoadClass
{
    /// <summary>
    /// csvファイルから、文字列を読み込むためのクラス
    /// </summary>

    class CSVLoadClass
    {
        public static void LoadCsv(ref ArrayList al)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ドキュメントまでのパス
            string Resource = @"\GitHub\kinect2014\YudukiProject\text";//テキストデータの場所
            string line = ""; //文字列を読み込むためのstring型変数
            List<string> Lstring = new List<string>();
            al = new ArrayList();//文字を格納するための変数、List配列、オブジェクト型
            try
            {
                // csvファイルを開く
                using (var sr = new StreamReader(@"test.csv",Encoding.GetEncoding("UTF-8")))
                {
                    // ストリームの末尾まで繰り返す
                    //while (!sr.EndOfStream)
                    while ((line = sr.ReadLine()) != null)
                    {
                        // ファイルから一行読み込む
                        //line = sr.ReadLine();
                        // 読み込んだ一行をカンマ毎に分けて配列に格納する
                        Lstring = new List<string>(line.Split(','));
                    }
                    al.Add(Lstring);
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                System.Console.WriteLine(e.Message);
                Environment.Exit(0);//アプリケーション終了
            }
        }
    }
}
