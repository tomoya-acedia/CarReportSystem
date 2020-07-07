using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarReportSystem
{
    [Serializable]
    class CarReport
    {
        public DateTime Date{get;set;}     //作成日
        public string Author{get;set;}     //記録者
        public CarMaKer Maker{get;set;}    //メーカー(列挙型)
        public string CarName{get;set;}    //車名
        public string Report{get;set;}     //レポート
        public Image CarPicture{get; set;} //画像

        //メーカー
        public enum CarMaKer
        {
            DEFAULT,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他,
        }
    }
}
