using Newtonsoft.Json;

public static class SessionExtensions
{
    public static void SetObjectAsJson(this ISession session, string key, object value)
    {
        session.SetString(key, JsonConvert.SerializeObject(value));
    }

    public static void SetValue(this ISession session, string key, string value)
    {
        session.SetString(key, value);
    }

    public static string GetValue(this ISession session, string key)
    {
        return session.GetString(key);
    }

    public static T GetObjectFromJson<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    }
}
namespace KanatStore.UI.Models
{
    public class Utility
    {
        public static string GetHrefParam(string title)
        {
            title = title.Trim();

            title = StripVN(title);
            string newTitle = "";
            bool isAttach = false;

            for (int i = 0; i < title.Length; i++)
            {
                char c = title[i];
                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == '-' || c == '.')
                {
                    newTitle += c;
                    isAttach = false;
                }
                else
                {
                    if (!isAttach)
                    {
                        newTitle += "-";
                        isAttach = true;
                    }
                }
            }

            return newTitle;
        }

        public static string StripVN(string title)
        {
            title = title.ToLower();

            title = ReplaceVN(title, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ", "a");
            title = ReplaceVN(title, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ", "e");
            title = ReplaceVN(title, "ì|í|ị|ỉ|ĩ", "i");
            title = ReplaceVN(title, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ", "o");
            title = ReplaceVN(title, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ", "u");
            title = ReplaceVN(title, "ỳ|ý|ỵ|ỷ|ỹ", "y");
            title = ReplaceVN(title, "đ", "d");

            return title;
        }

        public static string ReplaceVN(string title, string line, string p)
        {
            string[] lines = line.Split("|");
            foreach (string s in lines)
            {
                title = title.Replace(s, p);
            }
            return title;
        }
    }
}
