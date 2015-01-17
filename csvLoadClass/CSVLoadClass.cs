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
        public static void LoadCsv(ref List<string> sl)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ドキュメントまでのパス
            string Resource = @"\GitHub\csvLoadClass\csv\";//csvデータの場所
            string line = ""; //文字列を読み込むためのstring型変数
            List<string> Lstring = new List<string>();
            try
            {
                // csvファイルを開く
                using (var sr = new StreamReader(rootPath+Resource+"sample3.csv"))
                {
                    // ストリームの末尾まで繰り返す
                    //while (!sr.EndOfStream)
                    while ((line = sr.ReadLine()) != null)
                    {
                        // ファイルから一行読み込む
                        // 読み込んだ一行をカンマ毎に分けて配列に格納する
                        sl = new List<string>(line.Split(','));
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                Environment.Exit(0);//アプリケーション終了
            }
        }
    }
}
