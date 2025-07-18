using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AnimationProject
{
    public class JsonManager // json管理クラス
    {
        private readonly string _filePath;

        public JsonManager(string fileName) // 新しいインスタンスを初期化
        {
            _filePath = Path.Combine(Application.StartupPath, fileName);
        }

        public T LoadOrDefault<T>(T defaultValue) // エラーハンドリング
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string jsonText = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<T>(jsonText);
                }
                else
                {
                    // ファイルが存在しない場合はデフォルト値を保存し、そのデフォルト値を返す
                    Save(defaultValue);
                    return defaultValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ファイル読み込みエラーが発生しました:\n{ex.Message}\nファイル: {_filePath}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return defaultValue; // エラー時はデフォルト値を返す
            }
        }

        public bool Save<T>(T data) // 保存
        {
            try
            {
                // オブジェクトを整形されたJSON文字列にシリアライズ
                string jsonText = JsonConvert.SerializeObject(data, Formatting.Indented);
                // ファイルに書き込む（既存の場合は上書き）
                File.WriteAllText(_filePath, jsonText);
                return true; // 保存成功
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ファイル保存エラーが発生しました:\n{ex.Message}\nファイル: {_filePath}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // 保存失敗
            }
        }
    }

    public class GameSetting // デフォルトデータ
    {
        // Ballの移動量
        public int BallSpeed { get; set; } = 5;

        // Barの移動量
        public int BarRange { get; set; } = 1;

        // SEのボリューム
        public int SeVolume { get; set; } = 5;

        // ハイスコア
        public int HighScore { get; set; } = 0;

        // ---キーバインド---
        // 右移動
        public string RightKey { get; set; } = "A";
        // 左移動
        public string LeftKey { get; set; } = "D";
    }
}
