using System;
using System.Collections.Generic;
using System.Text;

namespace Blueprint.Utils.Helpers {
    public static class Helpers {

        //@ convert > to String
        public static String str<S>(S s) => Convert.ToString(s);

        //@ get > full path (from root)
        public static String path(String p)
        {
            string projectRoot = Directory.GetParent(System.Windows.Forms.Application.StartupPath)
                                    .Parent  // Debug
                                    .Parent  // bin
                                    .Parent  // ProjectName
                                    .FullName;
            return Path.Combine(projectRoot, p);
        }
    }
}
