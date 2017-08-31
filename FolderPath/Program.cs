using System;

namespace FolderPath
{
    class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public void Cd(string newPath)
        {
            var arr = newPath.Split('/');
            foreach (var item in arr)
            {
                switch (item)
                {
                    case "..":
                        this.CurrentPath = this.CurrentPath.Substring(0, Array.LastIndexOf(CurrentPath.ToCharArray(), "/"));
                        break;
                    default:
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            Path path = new Path("/a/b/c/d");
            path.Cd("../x");
            Console.WriteLine(path.CurrentPath);
        }
    }
}
