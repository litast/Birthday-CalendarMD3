using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Birthday_Calendar
{

    public class MyEvent
    {
        public static int day;
        public static MonthEnums month;
        public static int year;
        public static TypeEnums type;
        public static string name;

        public MyEvent(int d, string m, int y, string t, string n)
        {
            day = d;
            month = (MonthEnums)Enum.Parse(typeof(MonthEnums), m);
            year = y;
            type = (TypeEnums)Enum.Parse(typeof(TypeEnums), t);
            name = n;
        }

        public static string GetMonthName(MonthEnums month)
        {
            switch (month)
            {
                case MonthEnums.janvāris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(1); // return 'janvāris'
                case MonthEnums.februāris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(2);
                case MonthEnums.marts:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(3);
                case MonthEnums.aprīlis:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(4);
                case MonthEnums.maijs:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(5);
                case MonthEnums.jūnijs:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(6);
                case MonthEnums.jūlijs:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(7);
                case MonthEnums.augusts:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(8);
                case MonthEnums.septembris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(9);
                case MonthEnums.oktobris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(10);
                case MonthEnums.novembris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(11);
                case MonthEnums.decembris:
                    return DateTimeFormatInfo.CurrentInfo.GetMonthName(12);
                default:
                    return "Unknown month";
            }
        }

        /*
        public static int GetMonthValue(MonthEnums month)
        {
            switch (month)
            {
                case MonthEnums.janvāris:
                    return 1;
                case MonthEnums.februāris:
                    return 2;
                case MonthEnums.marts:
                    return 3;
                case MonthEnums.aprīlis:
                    return 4;
                case MonthEnums.maijs:
                    return 5;
                case MonthEnums.jūnijs:
                    return 6;
                case MonthEnums.jūlijs:
                    return 7;
                case MonthEnums.augusts:
                    return 8;
                case MonthEnums.septembris:
                    return 9;
                case MonthEnums.oktobris:
                    return 10;
                case MonthEnums.novembris:
                    return 11;
                case MonthEnums.decembris:
                    return 12;
                default:
                    return 0;
            }
        }
        */

        public static TypeEnums GetTypeValue(string type)
        {
            switch (type)
            {
                case "Dzimšanas diena":
                    return TypeEnums.Dz;
                case "Vārda diena":
                    return TypeEnums.Vd;
                case "Laulību gadadiena":
                    return TypeEnums.Lg;
                case "Miršanas gadadiena":
                    return TypeEnums.M;
                case "Valsts svētki":
                    return TypeEnums.Sv;
                case "Cits":
                    return TypeEnums.C;
                default:
                    return 0;
            }
        }

        public static string GetTypeName(TypeEnums type)
        {
            switch (type)
            {
                case TypeEnums.Dz:
                    return "Dzimšanas diena";
                case TypeEnums.Vd:
                    return "Vārda diena";
                case TypeEnums.Lg:
                    return "Laulību gadadiena";
                case TypeEnums.M:
                    return "Miršanas gadadiena";
                case TypeEnums.Sv:
                    return "Valsts svētki";
                case TypeEnums.C:
                    return "Cits";
                default:
                    return "Unknown type";
            }
        }

    };

    public enum MonthEnums
    {
        janvāris,
        februāris,
        marts,
        aprīlis,
        maijs,
        jūnijs,
        jūlijs,
        augusts,
        septembris,
        oktobris,
        novembris,
        decembris
    };

    public enum TypeEnums
    {
        [Description("Dzimšanas diena")]
        Dz,
        [Description("Vārda diena")]
        Vd,
        [Description("Laulību gadadiena")]
        Lg,
        [Description("Miršanas gadadiena")]
        M,
        [Description("Valsts svētki")]
        Sv,
        [Description("Cita atzīmējama diena")]
        C
    };

    public class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);

        }

    }

}
