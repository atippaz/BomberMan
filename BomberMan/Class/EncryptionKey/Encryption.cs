using System;
using System.IO;

namespace BomberMan {
    static class Encryption {
        #region Fields
        private static string _Username;
        private static int _HighScore;
        private static int key = 20;
        private static int index;
        private static string[] _EngLang =
            {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        #endregion

        #region Properties 
        public static int HightScore { get => _HighScore; }
        public static string Username { get => _Username; }
        // public static int SetKey { set { key = value; } }
        #endregion

        #region Encrypt and Decrypt methods
        public static void Encrypt(string username, string score) {
            string strEncrypt = "";
            char str = ' ';
            index = 0;
            for (int i = 0; i < 8; i++) {
                str = Convert.ToChar(username[i]);
                for (int k = 0; k < _EngLang.Length; k++) {
                    // Upper case
                    if (char.IsUpper(str)) {
                        if (str.ToString() == _EngLang[k].ToUpper()) {
                            index = (k + key) % _EngLang.Length;
                            strEncrypt += _EngLang[index];
                        }
                    }
                    // Lower case
                    if (char.IsLower(str)) {
                        if (str.ToString() == _EngLang[k].ToLower()) {
                            index = (k + key) % _EngLang.Length;
                            strEncrypt += _EngLang[index].ToLower();
                        }
                    }
                }
            }
            strEncrypt += score;
            File.WriteAllText(Paths.PathHighScore, String.Empty);
            File.WriteAllText(Paths.PathHighScore, strEncrypt);
        }

        public static void Decrypt() {
            string str = File.ReadAllText(Paths.PathHighScore);
            if (str != "") {
                string username = "";
                char str1 = ' ';
                index = 0;
                for (int i = 0; i < 8; i++) {
                    str1 = Convert.ToChar(str[i]);
                    for (int k = 0; k < _EngLang.Length; k++) {
                        // Upper case
                        if (char.IsUpper(str1)) {
                            if (str1.ToString() == _EngLang[k].ToUpper()) {
                                index = (_EngLang.Length + (k - key)) % _EngLang.Length;
                                username += _EngLang[index].ToUpper();
                            }
                        }
                        // Lower case
                        if (char.IsLower(str1)) {
                            if (str1.ToString() == _EngLang[k].ToLower()) {
                                index = (_EngLang.Length + (k - key)) % _EngLang.Length;
                                username += _EngLang[index].ToLower();
                            }
                        }
                    }
                }
                _Username = username;
                _HighScore = int.Parse(str.Substring(8));
            }
        }
        #endregion
    }
}
