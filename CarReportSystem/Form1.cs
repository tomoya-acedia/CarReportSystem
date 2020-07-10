using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        //リスト
        BindingList<CarReport> Reports = new BindingList<CarReport>();
        
        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = Reports;
        }

        //開く(画像)
        private void button3_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //削除をクリックしたら画像をクリアする
        private void btClearImage_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("画像がありません。");
                return;
            }

            pbImage.Image = null;
        }

        //追加をクリックしたら入力したものを記事一覧に表示
        private void btAdd_Click(object sender, EventArgs e)
        {
            //CarReportオブジェクト生成
            CarReport obj = new CarReport
            {
                Date = CreateDate.Value,    //作成日
                Author = RecordName.Text,   //記録者
                Maker = GetCarMaker(),      //メーカー
                CarName = cbCarName.Text,   //車名
                Report = rtReport.Text,     //レポート
                CarPicture= pbImage.Image,  //画像
            };

            //記録者の名前を保存
            SetComboboxRecordName(RecordName.Text);

            //車名を保存
            SetComboboxCarName(cbCarName.Text);

            //入力データをリストの先頭へ追加
            Reports.Insert(0, obj);

            //ボタンのON/OFF
            initButtons();

            //高さを自動調整
            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //すべてクリア状態にする
            inputItemAllClear();
        }

       
        //選択されているメーカーのチェック
        private CarReport.CarMaKer GetCarMaker()
        {
            if (toyota.Checked == true)
                return CarReport.CarMaKer.トヨタ;

            if (nissan.Checked == true) 
                return CarReport.CarMaKer.日産;

            if (honda.Checked == true)
                return CarReport.CarMaKer.ホンダ;

            if (subaru.Checked == true)
                return CarReport.CarMaKer.スバル;

            if (gaisya.Checked == true)
                return CarReport.CarMaKer.外車;

            if (snota.Checked == true)
                return CarReport.CarMaKer.その他;

            return CarReport.CarMaKer.DEFAULT;
        }

        //終了
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //修正
        private void btModify_Click(object sender, EventArgs e)
        {
            //変更対象のレコード（オブジェクト）
            CarReport selectedCar = Reports[dgvCarData.CurrentRow.Index];

            selectedCar.Date = CreateDate.Value;
            selectedCar.Author = RecordName.Text;
            selectedCar.Maker = GetCarMaker();
            selectedCar.CarName = cbCarName.Text;
            selectedCar.Report = rtReport.Text;
            selectedCar.CarPicture = pbImage.Image;

            dgvCarData.Refresh();       //データグリッドビューの再描画

            //ボタンのON/OFF
            initButtons();
        }

        //削除
        private void btDelete_Click(object sender, EventArgs e)
        {
            Reports.RemoveAt(dgvCarData.CurrentRow.Index);
            initButtons();
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        //フォーム
        private void Form1_Load(object sender, EventArgs e)
        {
            btModify.Enabled = false;
            btDelete.Enabled = false;
        }

        //記事一覧に何もないときは削除・修正ボタンを押せないようにする
        //記事一覧にあるときは削除・修正ボタンを押せる状態にする
        private void initButtons()
        {
            if (Reports.Count == 0)
            {
                btModify.Enabled = false;
                btDelete.Enabled = false;
            }
            else
            {
                btModify.Enabled = true;
                btDelete.Enabled = true;
            }
        }

        //すべてクリアにする
        private void inputItemAllClear()
        {
            CreateDate.Text = "";
            RecordName.Text = "";
            cbCarName.Text = "";
            rtReport.Text = "";
            pbImage.Image = null;

            //すべてのチェックを外す
            toyota.Checked = false;
            nissan.Checked = false;
            honda.Checked = false;
            subaru.Checked = false;
            gaisya.Checked = false;
            snota.Checked = false;
        }

        //開く(記事一覧)
        private void btKiziHiraku_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                //ファイルストリームを生成
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        Reports = (BindingList<CarReport>)formatter.Deserialize(fs);

                        dgvCarData.DataSource = Reports;

                        dgvCarData_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, Reports);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //記事一覧
        private void dgvCarData_Click(object sender, EventArgs e)
        {
            if (dgvCarData.CurrentRow == null)
                return;

            CarReport selectedCar = Reports[dgvCarData.CurrentRow.Index];

            CreateDate.Value = selectedCar.Date;
            RecordName.Text = selectedCar.Author;
            cbCarName.Text = selectedCar.CarName;
            rtReport.Text = selectedCar.Report;
            pbImage.Image = null;

            //当てはまるものにチェックする
            switch (selectedCar.Maker)
            {
                case CarReport.CarMaKer.トヨタ:
                    {
                        toyota.Checked = true;
                        break;
                    }
                case CarReport.CarMaKer.日産:
                    {
                        nissan.Checked = true;
                        break;
                    }
                case CarReport.CarMaKer.ホンダ:
                    {
                        honda.Checked = true;
                        break;
                    }
                case CarReport.CarMaKer.スバル:
                    {
                        subaru.Checked = true;
                        break;
                    }
                case CarReport.CarMaKer.外車:
                    {
                        gaisya.Checked = true;
                        break;
                    }
                case CarReport.CarMaKer.その他:
                    {
                        snota.Checked = true;
                        break;
                    }
            }
        }

        //記録者を保存
        private void SetComboboxRecordName(string Author)
        {
            if (!RecordName.Items.Contains(Author))
                RecordName.Items.Add(Author);
        }

        //車名を保存
        private void SetComboboxCarName(string Name)
        {
            if (!cbCarName.Items.Contains(Name))
                cbCarName.Items.Add(Name);
        }

        //新規作成
        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputItemAllClear();
            Reports.Clear();
        }

        //開く
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                //ファイルストリームを生成
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        Reports = (BindingList<CarReport>)formatter.Deserialize(fs);

                        dgvCarData.DataSource = Reports;

                        dgvCarData_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //すべて保存
        private void すべて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //名前をつけて保存
        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, Reports);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //終了
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
