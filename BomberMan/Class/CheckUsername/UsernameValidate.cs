namespace BomberMan {
    public static class UsernameValidate {
        #region Method
        public static bool CheckTHLang(string str) {
            bool isTH = false;
            if (!string.IsNullOrEmpty(str))
            {
                isTH = (!System.Text.RegularExpressions.Regex.IsMatch(str[str.Length - 1].ToString(), "^[a-zA-Z ]")) ? true : false;
            }
            if (str != "") {
                if (!System.Text.RegularExpressions.Regex.IsMatch(str[str.Length - 1].ToString(), "^[a-zA-Z ]")) {
                    isTH = true;
                }
                else {
                    isTH = false;
                }
            }
            return isTH;
        }
        #endregion
    }
}
