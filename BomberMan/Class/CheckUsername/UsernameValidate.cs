namespace BomberMan {
    public static class UsernameValidate {
        #region Method
        public static bool CheckTHLang(string str) {
            bool isTH = false;
            if (!string.IsNullOrEmpty(str))
            {
                isTH = (!System.Text.RegularExpressions.Regex.IsMatch(str[str.Length - 1].ToString(), "^[a-zA-Z ]")) ? true : false;
            }
            return isTH;
        }
        #endregion
    }
}
