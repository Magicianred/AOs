using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;

namespace AOs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AOs";
            BIOS("Done.");
        }

        static void Sys()
        {
            Console.Title = "AOs";
            Console.ResetColor();
            Console.Clear();

            bool Loop = true;
            string Prompt = "$ ";
            string SYSVersion = "AOs 2021 [Version 1.5.9]";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(SYSVersion);
            Console.ResetColor();
            while (Loop)
            {
                Console.Write(Prompt);
                string Check = Console.ReadLine();
                string Global = Check.ToLower();
                if (Check == "" || Check == " " || Check.Contains("  "))
                {
                    continue;
                }

                else if (Check.ToLower() == "help")
                {
                    string[] HelpCenter = {
                    "about    - Tells you about AOs.",
                    "shutdowm - Shuts your PC down.",
                    "restart  - Restarts your PC.",
                    "shout    - Prints to the console.",
                    "get      - Takes input from the User.",
                    "generate - Generates a random number.",
                    "clear    - Clears the console.",
                    "scan     - Scans the system to check for viruses, malwares, spywares and etc.",
                    "color    - Changes the user-interface theme.",
                    "title    - Changes the title of the AOs window.",
                    "update   - Updates your pc to the latest version.",
                    "math     - Calculate integers given by user.",
                    "calander - Displays current time and date.",
                    "credits  - Provides Credit to Developers.",
                    "timer    - Creats a stop-watch for users.",
                    "lock     - Locks your pc so others can't access your system.",
                    "admin    - An adminstrator tool for more advanced AOs commands.",
                    "pixstore - Helps you to install any applications easily.",
                    "builder  - Provides user a notepad to store multi-line data.",
                    "version  - Shows you the current version of AOs.",
                    "leaf     - Leaf is a webbrowser you can use to open webpages.",
                    "run      - Allows you to applications that exists in your system.",
                    "terminal - Opens System Terminal using AOs."
                    };
                    Console.WriteLine("Type 'help' to get information of all the commands.");
                    Array.Sort(HelpCenter);
                    for (int i = 0; i < HelpCenter.Length; i++)
                    {
                        Console.WriteLine(HelpCenter[i]);
                    }
                }

                else if (Check.ToLower() == "terminal" || Check.ToLower() == "console" || Check.ToLower() == "cmd" || Check.ToLower() == "command prompt")
                {
                    CommandPrompt("start cmd");
                }

                else if (Check.ToLower() == "hintmeeaster")
                {
                    string[] HelpCenter = {
                    "AOs1000  - AOs was made up of 1000 lines of code.",
                    "$Prompt - Use this command line at the end of an invalid command line and change the prompt of AOs.",
                    };
                    Console.WriteLine("'hintmeeaster' is an easter egg in AOs which will show info about all the secret and hidden commands on AOs.");
                    Array.Sort(HelpCenter);
                    for (int i = 0; i < HelpCenter.Length; i++)
                    {
                        Console.WriteLine(HelpCenter[i]);
                    }
                }

                else if (Global.StartsWith("run ") || Check.ToLower() == "run")
                {
                    if (Global.StartsWith("run "))
                    {
                        string RUN = Global.Replace("run ", "");
                        if (RUN.EndsWith(" external-run"))
                        {
                            string EXTERNALRUN = RUN.Replace(" external-run", "");
                            CommandPrompt($"start {EXTERNALRUN}");
                        }

                        else
                        {
                            CommandPrompt($"call {RUN}");
                        }
                    }

                    else if (Check.ToLower() == "run")
                    {
                        Console.WriteLine("You need to give some file name that you want to run.");
                        Console.WriteLine("You can use external-run command line at the end to launch the application separately from AOs.");
                    }
                }

                else if (Global.StartsWith("python"))
                {
                    try
                    {
                        CommandPrompt(Global);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (Global.StartsWith("glass"))
                {
                    try
                    {
                        CommandPrompt(Global);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (Global.StartsWith("g++") || Global.StartsWith("gcc"))
                {
                    try
                    {
                        CommandPrompt(Global);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (Global.StartsWith("dotnet"))
                {
                    try
                    {
                        CommandPrompt(Global);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (Global.StartsWith("java"))
                {
                    try
                    {
                        CommandPrompt(Global);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (Check.EndsWith("$Prompt"))
                {
                    Prompt = Check.Replace("Prompt", " ");
                }

                else if (Global.StartsWith("leaf ") || Check.ToLower() == "leaf")
                {
                    if (Global.StartsWith("leaf "))
                    {
                        string Leaf = Check.Replace("leaf ", "start ");
                        CommandPrompt(Leaf);
                    }

                    else if (Check.ToLower() == "leaf")
                    {
                        Console.WriteLine("Please Enter any site name after calling the command \"leaf\"");
                        Console.WriteLine("Open any website using Leaf like this: leaf [site_url].");
                        Console.WriteLine("instead of \"[site_url]\" enter the actual URL or the Website.");
                    }
                }

                else if (Check.ToLower() == "version" || Check.ToLower() == "-v")
                {
                    Console.WriteLine(SYSVersion);
                }

                else if (Global.StartsWith("builder ") || Check.ToLower() == "builder")
                {
                    if (Global.StartsWith("builder "))
                    {
                        string Text = Check.Replace("builder ", "");
                        if (Text.StartsWith("open "))
                        {
                            string Open_Text = Text.Replace("open ", "");
                            string op = Open_Text.Replace(" ", "");
                            if (File.Exists(op))
                            {
                                string READ_FILE = File.ReadAllText(op);
                                Console.WriteLine(READ_FILE);
                            }

                            else
                            {
                                Console.WriteLine($"Cannot open {op}");
                            }
                        }

                        else if (Text.StartsWith("delete "))
                        {
                            string Txt = Text.Replace("delete ", "");
                            if (File.Exists(Txt))
                            {
                                File.Delete(Txt);
                                Console.WriteLine($"\"{Txt}\" deleted successfully");
                            }

                            else
                            {
                                Console.WriteLine($"Cannot delete {Txt}");
                            }
                        }

                        else if (!Text.StartsWith("delete ") && !Text.StartsWith("open "))
                        {
                            string Txt = Text.Replace(" ", "");
                            if (File.Exists(Txt))
                            {
                                string CD = File.ReadAllText(Txt);
                                Console.WriteLine($"{CD}Add more text.");
                                Builder_Txt(Txt);
                            }

                            else
                            {
                                File.WriteAllText(Txt, "");
                                Builder_Txt(Txt);
                            }
                        }
                    }

                    else if (Check.ToLower() == "builder")
                    {
                        Console.WriteLine("You need to give some file name, such as \"Test.txt\".");
                        Console.WriteLine("You need to add some arguments, such as, \"open\", \"delete\".");
                        Console.WriteLine("Use \"--builder<quit>\" to exit.");
                    }
                }

                else if (Global.StartsWith("pixstore ") || Check.ToLower() == "pixstore")
                {
                    if (Global.StartsWith("pixstore "))
                    {
                        string App = Check.Replace("pixstore ", "");
                        string application = App.ToLower();
                        if (application.StartsWith("open "))
                        {
                            string Open = application.Replace("open ", "");
                            string apps = Open.Replace(" ", "");
                            if (File.Exists($"{apps}.co"))
                            {
                                Console.WriteLine($"Opening {apps}");
                            }

                            else
                            {
                                Console.WriteLine($"Cannot open {apps}");
                            }
                        }

                        else if (application.StartsWith("install "))
                        {
                            string Install = application.Replace("install ", "");
                            string apps = Install.Replace(" ", "");
                            if (File.Exists($"{apps}.co"))
                            {
                                Console.WriteLine($"Collecting {apps}");
                                Thread.Sleep(1000);

                                Console.WriteLine($"Updating {apps}");
                                Console.WriteLine($"Finalizing {apps}");
                                Thread.Sleep(3000);

                                File.WriteAllText($"{apps}.co", $"\"{apps}\" updated successfully.");
                                Console.WriteLine($"{apps} updated\n");
                            }

                            else
                            {
                                Console.WriteLine($"Collecting {apps}");
                                Thread.Sleep(1000);

                                Console.WriteLine($"Installing {apps}");
                                Console.WriteLine($"Finalizing {apps}");
                                Thread.Sleep(3000);

                                File.WriteAllText($"{apps}.co", $"\"{apps}\" installed successfully.");
                                Console.WriteLine($"{apps} installed\n");

                                File.AppendAllText("Pixstore_installed.log", $"{apps}\n");
                            }
                        }

                        else if (application.StartsWith("update "))
                        {
                            string Uninstall = application.Replace("update ", "");
                            string apps = Uninstall.Replace(" ", "");
                            if (File.Exists($"{apps}.co"))
                            {
                                Console.WriteLine($"Collecting {apps}");
                                Thread.Sleep(1000);

                                Console.WriteLine($"Updating {apps}");
                                Console.WriteLine($"Finalizing {apps}");
                                Thread.Sleep(3000);

                                File.WriteAllText($"{apps}.co", $"\"{apps}\" updated successfully.");
                                Console.WriteLine($"{apps} updated\n");
                            }

                            else
                            {
                                Console.WriteLine($"Cannot update {Uninstall}");
                            }
                        }

                        else if (application.StartsWith("uninstall "))
                        {
                            string Uninstall = application.Replace("uninstall ", "");
                            string apps = Uninstall.Replace(" ", "");
                            if (File.Exists($"{apps}.co"))
                            {
                                Console.WriteLine($"Collecting {apps}");
                                Thread.Sleep(1000);

                                Console.WriteLine($"Uninstalling {apps}");
                                Console.WriteLine($"Finalizing {apps}");
                                Thread.Sleep(3000);

                                File.Delete($"{apps}.co");

                                Console.WriteLine($"{apps} uninstalled\n");

                                string Deline = File.ReadAllText("Pixstore_installed.log");
                                string[] Strlist = Deline.Split($"{apps}\n");
                                string NewLine = string.Join("", Strlist);
                                string repl = NewLine.Replace("\n", "");
                                File.WriteAllText("Pixstore_installed.log", $"{repl}\n");
                            }

                            else
                            {
                                Console.WriteLine($"Cannot uninstall {Uninstall}");
                            }
                        }

                        else if (App.ToLower() == "list")
                        {
                            if (File.Exists("Pixstore_installed.log"))
                            {
                                string Cd = File.ReadAllText("Pixstore_installed.log");
                                if (Cd == "")
                                {
                                    Console.WriteLine("No software listed.");
                                }

                                else
                                {
                                    Console.WriteLine(Cd);
                                }
                            }

                            else
                            {
                                Console.WriteLine("You haven't installed any programs yet.");
                            }
                        }
                    }

                    else if (Check.ToLower() == "pixstore")
                    {
                        Console.WriteLine("You need to add some arguments, such as, \"install\", \"update\", \"uninstall\", \"list\"");
                    }
                }

                else if (Check.ToLower() == "admin")
                {
                    Adminstrator();
                }

                else if (Check.ToLower() == "lock")
                {
                    LockPC();
                }

                else if (Check.ToLower() == "timer")
                {
                    Console.WriteLine("Set time.");
                    Console.Write("Seconds: ");
                    long sec = Convert.ToInt64(Console.ReadLine());
                    for (int defaultTime = 1; defaultTime <= sec; defaultTime++)
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(defaultTime);
                        if (defaultTime == sec)
                        {
                            Console.Write("Times up...\nContinue.");
                            Console.ReadKey();
                            Console.WriteLine("");
                        }
                    }
                }

                else if (Check == "AOs1000")
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations for hitting 1000 lines of code in AOs.");
                    Console.WriteLine("It is your first program to hit 1000 lines of code.");
                }

                else if (Check.ToLower() == "credits")
                {
                    string[] CreditCenter = {
                        "_________ AOS - Team ________",
                        "Developer - Srijan Srivastava",
                        "Found on  - 15 June 2020",
                        "Github    - github.com/Light-Lens",
                        "",
                        "____________________ Note(For Developers Only) ____________________",
                        "|| AOs - Terminal based Operating System",
                        "|| Contact: Srivastavavsrijan321@gmail.com",
                        "",
                        "|| AOs is an Open-Source Software.",
                        "|| If you want to modify or contribute on this project.",
                        "|| Then you can do anything you want.",
                        "|| But only at a condition,",
                        "|| When you say in your program \"Based on AOs Kernel 1.5\".",
                        "",
                        "____________________ Note(For All) ____________________",
                        "|| Warning - Do not delete any of the files or folders,",
                        "|| or it may cause system corruption",
                        "|| and may lead AOs not to boot.",
                        "",
                        "For more information type \"help\" or checkout README.docx"
                    };
                    Console.Clear();
                    for (int i = 0; i < CreditCenter.Length; i++)
                    {
                        Console.WriteLine(CreditCenter[i]);
                    }
                    Console.Write("Continue.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.Clear();
                }

                else if (Check.ToLower() == "calander")
                {
                    Console.WriteLine(DateTime.Now.DayOfWeek);
                    Console.WriteLine(DateTime.Now.TimeOfDay);
                    Console.WriteLine(DateTime.Now.Date);
                }

                else if (Check.ToLower() == "math")
                {
                    Console.Write("Enter your First number: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your Second number: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter you Operator: ");
                    string ope = Console.ReadLine();
                    Calculate(n1, n2, ope);
                }

                else if (Check.ToLower() == "scan")
                {
                    Scan();
                }

                else if (Global.StartsWith("color"))
                {
                    CommandPrompt(Check);
                }

                else if (Global.StartsWith("title"))
                {
                    CommandPrompt(Check);
                }

                else if (Check.ToLower() == "update")
                {
                    Load("Update.");
                    Update();
                }

                else if (Check.ToLower() == "about")
                {
                    Console.WriteLine("'891420135511920518' - Decode this number in Alphabetical order.");
                    Console.WriteLine("AOs is a terminal based Operating System inspired by MS-DOS and BatchUnited.");
                }

                else if (Global.StartsWith("shout "))
                {
                    string Repl = Check.Replace("shout ", "");
                    Console.WriteLine(Repl);
                }

                else if (Global.StartsWith("get "))
                {
                    string Repl = Check.Replace("get ", "");
                    Console.Write(Repl);
                    Console.ReadLine();
                }

                else if (Check.ToLower() == "shout")
                {
                    Console.WriteLine("");
                }

                else if (Check.ToLower() == "get")
                {
                    Console.ReadLine();
                }

                else if (Check.ToLower() == "clear" || Check.ToLower() == "cls")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(SYSVersion);
                    Console.ResetColor();
                }

                else if (Check.ToLower() == "generate")
                {
                    Console.WriteLine("Generate a random number");
                    Console.Write("Enter you first number: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter you second number: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    Random rand = new Random();
                    int Generic = rand.Next(n1, n2+1);
                    Console.WriteLine(Generic);
                }

                else if (Check.ToLower() == "restart")
                {
                    BIOS("Restart.");
                }

                else if (Check.ToLower() == "shutdown")
                {
                    Load("Shutdown.");
                    Environment.Exit(0);
                }

                else if (Check.ToLower() == "quit" || Check.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Command does not exist.");
                    Console.ResetColor();
                }
            }
        }

        static void Adminstrator()
        {
            Console.ResetColor();
            Console.Clear();

            bool Loop = true;
            Directory.SetCurrentDirectory("..");
            while(Loop)
            {
                Console.Write("admin> ");
                string Check = Console.ReadLine();
                string Global = Check.ToLower();
                if (Check == "" || Check == " " || Check.Contains("  "))
                {
                    continue;
                }

                else if (Check.ToLower() == "help")
                {
                    string[] HelpCenter = {
                    "diagxt    - Displays machine specific properties and configuration.",
                    "generate  - Generates a random number of your desired integer values.",
                    "terminate - Terminates all your PC process, This may lead AOs to crash.",
                    "exit      - Quits adminstrator.",
                    "lock      - Asks for password at PC start-up.",
                    "format    - Formats your PC for better performance.",
                    "recover   - Restores all important files and folders."
                    };
                    Console.WriteLine("Type 'help' to get information of all the commands.");
                    Array.Sort(HelpCenter);
                    for (int i = 0; i < HelpCenter.Length; i++)
                    {
                        Console.WriteLine(HelpCenter[i]);
                    }
                }

                else if (Check.ToLower() == "recover")
                {
                    RecoverSYSTEM();
                }

                else if (Check.ToLower() == "format")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WARNING: Formatting your PC will delete all your system and personal data including AOs update backup and reset AOs to default settings.");
                    Console.WriteLine("Are you sure? Y/N");
                    Console.ResetColor();

                    Console.Write(">>> ");
                    ConsoleKeyInfo FormatKey = Console.ReadKey();
                    string GetKey = FormatKey.Key.ToString();
                    Console.WriteLine("");
                    if (GetKey == "Y")
                    {
                        try
                        {
                            Directory.Delete("Files.x72");
                            File.Delete("BOOT.log");
                            if (File.Exists("Crashreport.log"))
                            {
                                File.Delete("Crashreport.log");
                            }

                            if (Directory.Exists("UpdatePackages/AOs.old"))
                            {
                                Directory.Delete("UpdatePackages/AOs.old");
                            }

                            Console.WriteLine("System Format Completed!");
                            Console.Write("A system restart is required to apply all changes.");
                            Console.ReadKey();
                            BIOS("Restart.");
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Cannot perform a System Format.");
                        }
                    }

                    else if (GetKey == "N")
                    {
                        Console.WriteLine("System Format Cancelled!");
                    }

                    else
                    {
                        Console.WriteLine("Invalid Key Input.");
                    }
                }

                else if (Check.ToLower() == "lock")
                {
                    LockSYS();
                }

                else if (Check.ToLower() == "diagxt" || Check.ToLower() == "ran")
                {
                    string Cfg = File.ReadAllText("Config.set");
                    Console.WriteLine(Cfg);
                }

                else if (Global.StartsWith("generate"))
                {
                    if (Global.Contains("uniform"))
                    {
                        Random Ran = new Random();
                        double Generic = Ran.NextDouble();
                        Console.WriteLine(Generic);
                    }

                    else if (Global.Contains("random"))
                    {
                        Console.WriteLine("Generate a random number");
                        Console.Write("Enter you first number: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter you second number: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        Random rand = new Random();
                        int Generic = rand.Next(n1, n2+1);
                        Console.WriteLine(Generic);
                    }

                    else
                    {
                        Console.WriteLine("Command does not exist.");
                    }
                }

                else if (Check.ToLower() == "terminate")
                {
                    Random Ran = new Random();
                    int Generic = Ran.Next(0, 2);
                    if (Generic == 0)
                    {
                        CrashSys();
                    }

                    else
                    {
                        Console.WriteLine("Terminating all your PC processes.");
                        Thread.Sleep(10000);
                        Console.WriteLine("All PC processes was terminated successfully.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WARNING: As all the processes are terminated, AOs may not work properly. So we request you to restart AOs (it is not compulsory).");
                        Console.ResetColor();
                    }
                }

                else if (Check.ToLower() == "exit" || Check.ToLower() == "quit")
                {
                    Directory.SetCurrentDirectory("Files.x72");
                    Console.Title = "AOs";
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Command does not exist.");
                    Console.ResetColor();
                }
            }
        }

        static void Builder_Txt(string txt)
        {
            while (true)
            {
                string Data = Console.ReadLine();
                if (Data == "--builder<quit>")
                {
                    break;
                }
                File.AppendAllText(txt, $"{Data}\n");
            }
        }

        static void LockSYS()
        {
            Console.Clear();
            Console.Write("Set Password: ");
            string pinLock = Console.ReadLine();
            Console.Clear();
            Directory.SetCurrentDirectory("..");
            File.WriteAllText("user.set", $"{pinLock}");
            while(true)
            {
                Console.Write("Enter Password: ");
                string askPin = Console.ReadLine();
                if (askPin == pinLock)
                {
                    Console.Write("Correct password.\nContinue.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.Clear();
                    break;
                }

                else
                {
                    Console.Write("Incorrect password.\nContinue.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.Clear();
                }
            }
            Directory.SetCurrentDirectory("Files.x72");
        }

        static void CrashSys()
        {
            Console.WriteLine("Terminating all your PC processes.");
            Thread.Sleep(10000);
            Environment.Exit(0);
        }

        static void CommandPrompt(string Commands)
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe", $"/c {Commands}");
            Process.Start(start);
        }

        static void LockPC()
        {
            Console.Clear();
            Console.Write("Set Password: ");
            string pinLock = Console.ReadLine();
            Console.Clear();

            while(true)
            {
                Console.Write("Enter Password: ");
                string askPin = Console.ReadLine();
                if (askPin == pinLock)
                {
                    Console.Write("Correct password.\nContinue.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.Clear();
                    break;
                }

                else
                {
                    Console.Write("Incorrect password.\nContinue.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.Clear();
                }
            }
        }

        static void Calculate(int num1, int num2, string ope)
        {
            if (ope == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (ope == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (ope == "*" || ope == "x")
            {
                Console.WriteLine(num1 * num2);
            }

            else if (ope == "/")
            {
                Console.WriteLine(num1 / num2);
            }
        }

        static void Update()
        {
            Random Ran = new Random();
            int Generic = Ran.Next(0, 18);
            if (Generic == 17)
            {
                Console.WriteLine("");
                Console.WriteLine("Updates are available!");
                Console.Write("Continue.");
                Console.ReadKey();
                Console.WriteLine("");

                Console.Clear();

                Directory.SetCurrentDirectory("..");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE");
                Console.WriteLine("[]\n");

                Console.WriteLine("Connecting.");
                Thread.Sleep(Generic_Range(0, 10001));
                Console.WriteLine("Connected to server.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Getting things ready.");
                Thread.Sleep(Generic_Range(0, 10001));
                if (Directory.Exists("UpdatePackages"))
                {
                    Directory.SetCurrentDirectory("UpdatePackages");
                    if (File.Exists("UPR.exe") == false)
                    {
                        Console.WriteLine("Cannot find \"UPR.exe\"");
                        Console.WriteLine("Cancelling update");
                        Thread.Sleep(Generic_Range(0, 3001));
                        return;
                    }
                    Directory.SetCurrentDirectory("..");
                }
                else
                {
                    Console.WriteLine("Cannot find \"UpdatePackages\" directory.");
                    Console.WriteLine("Cancelling update");
                    Thread.Sleep(Generic_Range(0, 3001));
                    return;
                }
                Console.WriteLine("[]\n");

                Console.WriteLine("Downloading.");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE_DOWNLOAD_EXECUTION");
                Console.Write("This may take a few minutes: ");
                Thread.Sleep(Generic_Range(0, 10001));
                for (int i = 0; i <= 50; i++)
                {
                    if (i >= 50)
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    Console.Write("-");
                    Thread.Sleep(1000);
                }
                File.WriteAllText("UpdatePackages\\Data\\updatedata.info", "72500 files Downloaded");
                Console.WriteLine("72500 files Downloaded.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Copying.");
                Thread.Sleep(7000);
                CommandPrompt("call UpdatePackages\\UPR.exe");
                Console.WriteLine("72500 files Copied.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Verifying.");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE_VERIFICATION_EXECUTION");
                Console.Write("This may take a few seconds: ");
                Thread.Sleep(Generic_Range(0, 10001));
                for (int i = 0; i <= 50; i++)
                {
                    if (i >= 50)
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    Console.Write("-");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("72500 files Verified.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Extracting.");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE_EXTRACTION_EXECUTION");
                Console.Write("This may take a few minutes: ");
                Thread.Sleep(Generic_Range(0, 17001));
                for (int i = 0; i <= 50; i++)
                {
                    if (i >= 50)
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    Console.Write("-");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("107005 files Extracted.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Installing.");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE_INSTALLATION_EXECUTION");
                Console.Write("This may take a few minutes: ");
                Thread.Sleep(Generic_Range(0, 27001));
                for (int i = 0; i <= 50; i++)
                {
                    if (i >= 50)
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    Console.Write("-");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("10500 files Installed.");
                Console.WriteLine("[]\n");

                Console.WriteLine("Updating.");
                Console.WriteLine("AOS_1.5_UPDATE_PACKAGE_EXECUTION");
                Thread.Sleep(Generic_Range(0, 7001));
                if (File.Exists("updateinfo.log"))
                {
                    File.AppendAllText("updateinfo.log", $"This PC was updated at {DateTime.Now}  : BUG FIXES, Optimizes\n");
                }

                else
                {
                    File.WriteAllText("updateinfo.log", $"This PC was updated at {DateTime.Now} : BUG FIXES, Optimizes\n");
                }

                Console.WriteLine("Your PC is Updated.");
                Console.WriteLine("[]\n");
                Console.Write("Restart.");
                Console.ReadKey();

                Directory.SetCurrentDirectory("Files.x72");
                BIOS("Restart.");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("You are Up-To-Date.");
                Console.Write("Continue.");
                Console.ReadKey();
                Console.WriteLine("");
            }
        }

        static void Scan()
        {
            Load("Scaning.");
            Console.WriteLine("Scaning completed successfully!");
            Thread.Sleep(3000);
            Console.WriteLine("Generating report.");
            Thread.Sleep(1000);
            Random Ran = new Random();
            int Generic = Ran.Next(0, 18);
            if (Generic == 17)
            {
                Console.WriteLine("Your PC ran into problem =(");
            }

            else
            {
                Console.WriteLine("Your pc is working fine.");
                Console.Write("Continue.");
                Console.ReadKey();
                Console.WriteLine("");
            }
        }

        static void RecoverSYSTEM()
        {
            Console.WriteLine("");
            CommandPrompt("xcopy \"Sysfail/Recovery\" \".\" /E /H /C /I /S /V /Y /Q");
        }

        static void BIOS(string data)
        {
            string RootDir = Directory.GetCurrentDirectory();
            if (RootDir.Contains("AOs\\Files.x72"))
            {
                Directory.SetCurrentDirectory("..");
            }

            if (File.Exists("PROPERTIES"))
            {
                string Line = File.ReadAllText("PROPERTIES");
                if (Line.Contains("GTA5M-09VC8-5SA50-3QK2P") == false)
                {
                    File.AppendAllText("BOOT.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\n");
                    Console.Title = "Error 0x004.";
                    CommandPrompt("color 17");
                    Console.Clear();
                    Console.WriteLine("Error 0x004.");
                    Console.WriteLine("ERROR : FUNCTIONAL_KEY_MISSING");
                    File.WriteAllText("Crashreport.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\nERROR : FUNCTIONAL_KEY_MISSING\n");
                    Console.Write("Hard Shutdown");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            if (File.Exists("BOOT.log"))
            {
                File.AppendAllText("BOOT.log", "");
            }

            else
            {
                File.WriteAllText("BOOT.log", "BOOT_LOG\n");
            }

            Random Ran = new Random();
            int Generic = Ran.Next(0, 18);
            if (Generic == 17)
            {
                Timer();

                File.AppendAllText("BOOT.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\n");
                Console.Title = "Error 0x001.";
                CommandPrompt("color 17");
                Console.Clear();
                Console.WriteLine("Error 0x001.");
                Console.WriteLine("ERROR : LOCALHOST_TIMEOUT");
                File.WriteAllText("Crashreport.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\nERROR : LOCALHOST_TIMEOUT\n");

                string[] Syscrash = {
                "1 >>      Hard Shutdown",
                "2 >>      Restart anyway"
                };
                for (int i = 0; i < Syscrash.Length; i++) { Console.WriteLine(Syscrash[i]); }
                Console.Write(">>> ");
                ConsoleKeyInfo Control = Console.ReadKey();
                string GetKey = Control.Key.ToString();
                Console.WriteLine("");

                if (GetKey == "D1")
                {
                    Environment.Exit(0);
                }

                else if (GetKey == "D2")
                {
                    Console.Title = "AOs";
                    Console.ResetColor();
                    Console.Clear();
                    Load(data);
                    RootPackages();
                    Sys();
                }

                else
                {
                    Console.WriteLine("Option doesn't exist.");
                    Environment.Exit(0);
                }
            }

            else if (File.Exists("Config.set") == false)
            {
                File.AppendAllText("BOOT.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\n");
                Console.Title = "Error 0x002.";
                CommandPrompt("color 17");
                Console.Clear();
                Console.WriteLine("Error 0x002.");
                Console.WriteLine("Cannot specify Config.set.");
                Console.WriteLine("ERROR : SYSTEM_FILE_MISSING");
                File.WriteAllText("Crashreport.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\nERROR : SYSTEM_FILE_MISSING\n");

                string[] Syscrash = {
                "1 >>      Hard Shutdown",
                "2 >>      Restart anyway",
                "3 >>      Recover files"
                };
                for (int i = 0; i < Syscrash.Length; i++)
                {
                    Console.WriteLine(Syscrash[i]);
                }

                Console.Write(">>> ");
                ConsoleKeyInfo Control = Console.ReadKey();
                string GetKey = Control.Key.ToString();
                Console.WriteLine("");

                if (GetKey == "D1")
                {
                    Environment.Exit(0);
                }

                else if (GetKey == "D2")
                {
                    BIOS("Restart.");
                }

                else if (GetKey == "D3")
                {
                    RecoverSYSTEM();
                    Console.Title = "AOs";
                    Console.ResetColor();
                    Console.Clear();
                    Load(data);
                    RootPackages();
                    Sys();
                }

                else
                {
                    Console.WriteLine("Option doesn't exist.");
                    Environment.Exit(0);
                }
            }

            else if (File.Exists("PROPERTIES") == false)
            {
                File.AppendAllText("BOOT.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\n");
                Console.Title = "Error 0x003.";
                CommandPrompt("color 17");
                Console.Clear();
                Console.WriteLine("Error 0x003.");
                Console.WriteLine("Cannot specify PROPERTIES.");
                Console.WriteLine("ERROR : SYSTEM_FILE_MISSING");
                File.WriteAllText("Crashreport.log", $"AOs crashed with a BSOD at {DateTime.Now}, {DateTime.Now.TimeOfDay}\nERROR : SYSTEM_FILE_MISSING\n");

                string[] Syscrash = {
                "1 >>      Hard Shutdown",
                "2 >>      Restart anyway",
                "3 >>      Recover files"
                };
                for (int i = 0; i < Syscrash.Length; i++)
                {
                    Console.WriteLine(Syscrash[i]);
                }

                Console.Write(">>> ");
                ConsoleKeyInfo Control = Console.ReadKey();
                string GetKey = Control.Key.ToString();
                Console.WriteLine("");

                if (GetKey == "D1")
                {
                    Environment.Exit(0);
                }

                else if (GetKey == "D2")
                {
                    BIOS("Restart.");
                }

                else if (GetKey == "D3")
                {
                    RecoverSYSTEM();
                    Console.Title = "AOs";
                    Console.ResetColor();
                    Console.Clear();
                    Load(data);
                    RootPackages();
                    Sys();
                }

                else
                {
                    Console.WriteLine("Option doesn't exist.");
                    Environment.Exit(0);
                }
            }

            else
            {
                File.AppendAllText("BOOT.log", $"AOs booted at {DateTime.Now}, {DateTime.Now.TimeOfDay}\n");
                if (File.Exists("user.set"))
                {
                    Console.ResetColor();
                    string Cd = File.ReadAllText("user.set");
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter password: ");
                        string ByPassCode = Console.ReadLine();
                        if (ByPassCode == Cd)
                        {
                            Console.Write("Correct password.\nContinue.");
                            Console.ReadKey();
                            Console.WriteLine("");
                            break;
                        }

                        else
                        {
                            Console.Write("Incorrect password.\nContinue.");
                            Console.ReadKey();
                            Console.WriteLine("");
                        }
                    }
                    Load(data);
                    RootPackages();
                    Sys();
                }

                else
                {
                    Load(data);
                    RootPackages();
                    Sys();
                }
            }
        }

        static void RootPackages()
        {
            if (Directory.Exists("Files.x72"))
            {
                Directory.SetCurrentDirectory("Files.x72");
            }

            else
            {
                Directory.CreateDirectory("Files.x72");
                Directory.SetCurrentDirectory("Files.x72");
            }
        }

        static void Load(string loading)
        {
            Timer();
            Console.Write(loading);
            Console.ReadKey();
        }

        static void Timer()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10); // As miliseconds are counted.
                Console.Clear();
            }
        }

        static int Generic_Range(int n1, int n2)
        {
            Random rand = new Random();
            int Generic = rand.Next(n1, n2);
            return Generic;
        }
    }
}
