using System;

namespace JWTAuthentication_TokenBarer
{
    public class app
    {
        public int appid { get; set; }
        public string appname { get; set; }

        public string genre { get; set; }

        public int downloads { get; set; }

        internal static app SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
