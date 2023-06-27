using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SoulsFormats;
namespace Steady_Hands
{
    class Program
    {

        static Dictionary<int, byte[]> loadAntiAimPunchFiles() {
            string[] files = Directory.GetFiles(@"antiAimPunch");

            Dictionary<int, byte[]> antiPunchFiles = new Dictionary<int, byte[]>();
            foreach (string file in files)
            {
                antiPunchFiles.Add(1000000000 + Int32.Parse(file.Substring(file.LastIndexOf('_') + 2, file.LastIndexOf('.') - file.LastIndexOf('_') - 2)), File.ReadAllBytes(file));
            }

            return antiPunchFiles;
        }
        static void Main(string[] args)
        {
            String filePath = "";
            Console.WriteLine("Please drag and drop your c0000_a00_hi.anibnd.dcx onto me!");
            filePath = Console.ReadLine();
            filePath = filePath.Substring(1, filePath.Length - 2);
            Console.WriteLine(filePath + " is loaded and about to be edited.");
            BND4 c0000_a00_hi = BND4.Read(filePath);

            Dictionary<int, byte[]> antiAimPunchFiles = loadAntiAimPunchFiles();

            IEnumerable<BinderFile> hkxFiles = c0000_a00_hi.Files.Where(x => x.Name.Contains(".hkx"));

            foreach (BinderFile hkxAnim in hkxFiles) {
                if (antiAimPunchFiles.Keys.Contains(hkxAnim.ID)) {
                    hkxAnim.Bytes = antiAimPunchFiles[hkxAnim.ID];
                    Console.WriteLine("Anim has been edited.");
                }
            }
            c0000_a00_hi.Write(filePath);
            Console.WriteLine("Done. Press ENTER to exit.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
