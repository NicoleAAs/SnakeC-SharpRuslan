using System;
using System.IO;

namespace Snake
{
    public class Params
    {
        private string ResourcesFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin",StringComparison.Ordinal);
            string binFolder = Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();
            ResourcesFolder = binFolder + "resources\\";
        }

        public string GetResourcesFolder()
        {
            return ResourcesFolder;
        }
    }
}