using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Contracts.V1
{

    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Todo
        {
            public const string GetAll = Base + "/todo";

            public const string Update = Base + "/todo/{todoid}";

            public const string Delete = Base + "/todo/{todoid}";

            public const string Get = Base + "/todo/{todoid}";

            public const string Create = Base + "/todo";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/login";

            public const string Register = Base + "/identity/register";

            public const string Refresh = Base + "/identity/refresh";
        }
    }

}
