using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace csvLoadClass
{
    class CSVLoadClassVer2
    {

        static public void LoadCSV(ref string[][] str)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ドキュメントまでのパス
            string Resource = @"\GitHub\csvLoadClass\csv\";//csvデータの場所

            try
            {
                // csvファイルを開く
                using (StreamReader sr = new StreamReader(rootPath + Resource + "sample3.csv",Encoding.UTF8))
                {
                    for (int loop = 0; loop < 30; ++loop)
                    {
                        string[] temp = sr.ReadLine().Split(',');
                        for (int loop2 = 0; loop2 < temp.Length; loop2++)
                        {
                            str[loop][loop2] = temp[loop2];
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
            }
        }
    }
}
