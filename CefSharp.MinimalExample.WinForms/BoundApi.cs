using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms {
    public class BoundApi {
        public BoundApi() {

        }

        public string GetMethod1() {
            return nameof(GetMethod1) + " result";
        }
        public string GetMethod2() {
            string result;

            Thread.Sleep(5000);
            result = nameof(GetMethod2) + " result";

            return result;
        }
    }
}
