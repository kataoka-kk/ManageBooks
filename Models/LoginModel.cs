namespace ManageBooks.Models
{
    public class LoginModel : BaseModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public bool DoLogin()
        {
            //TODO : ログイン認証関連ロジック
            return true;
        }
    }
}
