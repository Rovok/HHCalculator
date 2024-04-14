using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HHCalculator
{
    internal class ClassData
    {
        public static readonly string Version = "2.1";
        public static readonly string FileName = "defaults.txt";
        public static readonly string ApplicationFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "\\" + "HHCalculator";
        public static readonly string FilePath = ClassData.ApplicationFolder + "\\" + ClassData.FileName;
        public static readonly string UpdateDownloadLink = "https://github.com/Rovok/HHCalculator/raw/main/HHCalculator.exe";
        public static readonly string UpdateInfoLink = "https://raw.githubusercontent.com/Rovok/HHCalculator/main/Info.txt";
        public static readonly string UpdaterLink = "https://github.com/Rovok/Updater/raw/main/Updater.exe";
        public static readonly string UserFormsPath = ClassData.ApplicationFolder + "\\UserForms";
        public static Form UI = new FormUI();
        public static Form AddNew = new FormAddNew();
        public static Form SettingsWindow = new FormSettings();
        public static readonly Dictionary<Form, string[]> InternalForms = new Dictionary<Form, string[]>()
            {
                { new FormSmith(),          new string[2]{ "Ковка", String.Empty } },
                { new FormWroughtIron(),    new string[2]{ "~~~~ $test: \"Кованое железо\" ~~~~", String.Empty } },
                { new FormBoardAndBranch(), new string[2]{ "Доски / Ветки", String.Empty } },
                { new FormCoade(),          new string[2]{ "Coade глина", String.Empty } },
                { new FormTreePot(),        new string[2]{ "Высадка деревьев", String.Empty } },
                { new FormGardenPot(),      new string[2]{ "Высадка садовых растений", String.Empty } },
                { new FormCommonCraft(),    new string[2]{ "Крафт / Строительство", String.Empty } },
                { new FormHHP(),            new string[2]{ "HHP <=> Телосложение", String.Empty } }
            };
        public static Dictionary<int, string> ExternalForms = new Dictionary<int, string>();
        public static Dictionary<int, Form> FormNumbers = new Dictionary<int, Form>();
        public static readonly Dictionary<string, string> lang_ru = new Dictionary<string, string>()
            {
                { "FormAddNew", "Создание" },
                { "Name", "Название" },
                { "InCount", "Количество строк для входных данных" },
                { "OutCount", "Количество строк для выходных данных" },
                { "BtnContinue", "Продолжить" },
                { "InNames", "Название входной переменной" },
                { "OutNames", "Название выходной переменной и формула" },
                { "FinishBtn", "Создать" },
                { "Result", "Результат" },
                { "Calculate", "Вычислить" }
            };
        public static readonly Dictionary<string, string> lang_current = lang_ru;

        public static Dictionary<string, string> Variables = new Dictionary<string, string>
            {
                { "anvil" , "Наковальня" },
                { "hammer", "Кузнечный молот" },
                { "log", "Поленья" },
                { "stone_axe", "Топор" },
                { "kiln", "Килн" },
                { "flint", "Кремень" },
                { "quartz", "Кварц" },
                { "sand", "Песок" },
                { "ball_clay", "Комовая глина" },
                { "cauldron", "Котёл" },
                { "common_water", "Вода" },
                { "salt_water", "Солёная вода" },
                { "feldspar", "Полевой шпат" },
                { "bone", "Кость" },
                { "cave_clay", "Пещерная глина" },
                { "acre_clay", "Красная глина" },
                { "gray_clay", "Серая глина" },
                { "potters_wheel", "Гончарный круг" },
                { "mulch", "Земля" },
                { "treeplanters_pot", "Горшок для деревьев" },
                { "garden_pot", "Садовый горшок" },
                { "herbalist_table", "Стол травника" }
            };

        public static Dictionary<string, string> ConvertVariables = new Dictionary<string, string>
            {
            };

        public static Dictionary<string, double> Qualities = new Dictionary<string, double>
            {
                { "anvil" , 0 },
                { "hammer", 0 },
                { "log", 0 },
                { "stone_axe", 0 },
                { "kiln", 0 },
                { "flint", 0 },
                { "quartz", 0 },
                { "sand", 0 },
                { "ball_clay", 0 },
                { "cauldron", 0 },
                { "common_water", 0 },
                { "salt_water", 0 },
                { "feldspar", 0 },
                { "bone", 0 },
                { "cave_clay", 0 },
                { "acre_clay", 0 },
                { "gray_clay", 0 },
                { "potters_wheel", 0 },
                { "mulch", 0 },
                { "treeplanters_pot", 0 },
                { "garden_pot", 0 },
                { "herbalist_table", 0 }
            };
        public static readonly System.Drawing.Font FontStrikeout = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        public static readonly System.Drawing.Font FontRegular = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
    }
}
