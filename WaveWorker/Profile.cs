using System.Xml.Serialization;
using System.IO;

namespace Hvylya_Worker
{

    static class ProfileControl
    {
        public static void Save(Profile prof)
        {
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(Profile));
            StreamWriter myWriter = new StreamWriter(Directory.GetCurrentDirectory() + "\\profile.xml");
            mySerializer.Serialize(myWriter, prof);
            myWriter.Close();
        }

        public static Profile Load(string PathToProfile)
        {
            Profile prof = new Profile();
            if (File.Exists(PathToProfile))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Profile));
                FileStream myFileStream = new FileStream(PathToProfile, FileMode.Open);
                prof = (Profile)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
            }
            return prof;
        }

        public static Soft GetPatch(string name, Profile prof)
        {
            for (int i = 0; i < prof.soft.Length; i++)
            {
                if (name == prof.soft[i].Name)
                {
                    return prof.soft[i];
                }
            }
            return null;
        }
    }

    public class Profile
    {
        public Profile()
        {
            group = new Group[1];
            soft = new Soft[1];
            group[0] = new Group();
            soft[0] = new Soft();
        }
        public Group[] group;
        public Soft[] soft;
    }

    public class Group
    {
        public Group()
        {
            Name = "Name";
            Soft = new string[1] {"Soft namespace string"};
            Autorun = new string[1] {"Autorun string"};
        }
        public string Name { get; set; }
        public string[] Soft { get; set; }
        public string[] Autorun { get; set; }
    }

    public class Soft
    {
        public Soft()
        {
            Name = "Name";
            LastPatchID = 0;
            Patches = new Patch[1];
            Patches[0] = new Patch();
        }
        public string Name { get; set; }
        public uint LastPatchID { get; set; }
        public Patch[] Patches;
    }

    public class Patch
    {
        public Patch()
        {
            PatchID = 0;
            PathToInstall = "PathToInstall";
            CommandToRun = "CommandToRun";
        }
        public uint PatchID { get; set; }
        public string PathToInstall { get; set; }
        public string CommandToRun { get; set; }
    }
}
