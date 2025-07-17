using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using AnimationProject;

namespace AnimationProject
{
    public class JsonManager
    {
        private readonly string _filePath;

        /// <summary>
        /// JsonManagerの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="fileName">管理するJSONファイルの名前（例: "settings.json"）</param>
        public JsonManager(string fileName)
        {
            _filePath = Path.Combine(Application.StartupPath, fileName);
        }

        /// <summary>
        /// JSONファイルが存在しない場合に、指定されたデフォルトデータでファイルを初期化（作成）します。
        /// </summary>
        /// <typeparam name="T">データの型</typeparam>
        /// <param name="defaultData">ファイルが存在しない場合に保存するデフォルトデータ</param>
        public void InitializeIfNotExists<T>(T defaultData)
        {
            if (!File.Exists(_filePath))
            {
                Save(defaultData); // ファイルを保存
                MessageBox.Show($"初期設定ファイルを作成しました: {_filePath}", "ファイル作成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// JSONファイルを読み込み、指定された型のオブジェクトにデシリアライズします。
        /// ファイルが存在しない場合や読み込みエラーが発生した場合は、デフォルト値を返します。
        /// </summary>
        /// <typeparam name="T">読み込むデータの型</typeparam>
        /// <param name="defaultValue">ファイルが存在しない場合やエラー時に返すデフォルト値</param>
        /// <returns>読み込んだデータ、またはデフォルト値</returns>
        public T LoadOrDefault<T>(T defaultValue)
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

        /// <summary>
        /// 指定されたオブジェクトをJSON形式でファイルに保存します。
        /// </summary>
        /// <typeparam name="T">保存するデータの型</typeparam>
        /// <param name="data">保存するオブジェクト</param>
        /// <returns>保存が成功した場合はtrue、失敗した場合はfalse</returns>
        public bool Save<T>(T data)
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

        /// <summary>
        /// 管理対象のJSONファイルがディスク上に存在するかどうかを確認します。
        /// </summary>
        /// <returns>ファイルが存在すればtrue、そうでなければfalse</returns>
        public bool FileExists()
        {
            return File.Exists(_filePath);
        }
    }


    /// <summary>
    /// アプリケーションの一般的な設定を表すクラス。
    /// JSONとして保存・読み込みされます。
    /// </summary>
    public class AppSettings
    {
        public int WindowWidth { get; set; } = 800;
        public int WindowHeight { get; set; } = 600;
        public string Theme { get; set; } = "Light";
    }

    /// <summary>
    /// ゲームに関する特定の設定を表すクラス。
    /// JSONとして保存・読み込みされます。
    /// </summary>
    public class GameSetting
    {
        public int MoveSpeed { get; set; } = 5;
        public int BarSpeed { get; set; } = 1;
        public int SeVolume { get; set; } = 5;
    }
}
