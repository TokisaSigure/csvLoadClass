using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csvLoadClass
{
    class CSVLoadClassVer2
    {

        static public void LoadCSV(ref string[] str)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ドキュメントまでのパス
            string Resource = @"\GitHub\csvLoadClass\csv\";//csvデータの場所

            try
            {
                // csvファイルを開く
                using (var sr = new System.IO.StreamReader(rootPath + Resource + "sample3.csv"))
                {
                    // ストリームの末尾まで繰り返す
                    while (sr.ReadLine()!=null)
                    {
                        if (sr.ReadLine() != "\n")
                        {
                            // ファイルから一行読み込む
                            var line = sr.ReadLine();
                            // 読み込んだ一行をカンマ毎に分けて配列に格納する
                            str = line.Split(new char[] { ',', '\n' });
                            // 出力する
                            foreach (var value in str)
                            {
                                System.Console.Write("{0} ", value);
                            }
                            System.Console.WriteLine();
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
