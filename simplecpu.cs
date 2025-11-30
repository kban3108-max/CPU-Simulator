using System;
using CPU;
using System.IO;

namespace CPU
{
    class CPUIns
    {
        public double[] allocated;
        public string[] allocatedstr;
        public int pointer = 0;
        public int strpointer = 0;
        public double[] ALCNUM()
        {
            string size = Console.ReadLine();
            if (int.TryParse(size, out int size2)) {
            return allocated = new double[size2];
            }
            else {
                Console.WriteLine("insert a number!");
                return null;
            }
        }
        public string[] ALCSTR()
        {
            string size = Console.ReadLine();
            if (int.TryParse(size, out int size2)) {
            return allocatedstr = new string[size2];
            }
            else {
                Console.WriteLine("insert a number!");
                return null;
            }
        }
        public void PST()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
        public void PIN()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int integer))
            {
                Console.WriteLine(integer);
            }
            else
            {
                Console.WriteLine("insert a number please");
            }
        }
        public void PDB()
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double db))
            {
                Console.WriteLine(db);
            }
            else
            {
                Console.WriteLine("insert a number please");
            }
        }
        public void ADD()
        {
            string a, b;
            double a2, b2;
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
                Console.WriteLine(a2 + b2);
        }
        public void SUB()
        {
            string a, b;
            double a2, b2;
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
                Console.WriteLine(a2 - b2);
        }
        public void MUL()
        {
            string a, b;
            double a2, b2;
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
                Console.WriteLine(a2 * b2);
        }
        public void DIV()
        {
            string a, b;
            double a2, b2;
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
            if (b2 == 0) {
                Console.WriteLine("Cant divide by zero!");
                return;
            }
                Console.WriteLine(a2 / b2);
        }
        public void MOD()
        {
            string a, b;
            double a2, b2;
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
            if (b2 == 0) {
                Console.WriteLine("Cant divide by zero!");
                return;
            }
                Console.WriteLine(a2 % b2);
        }
        public void MADD()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found!");
                return;
            }

            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int a) || a >= allocated.Length || a < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int b) || b >= allocated.Length || b < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            double sum = allocated[a] + allocated[b];
            Console.WriteLine(sum);
        }
        public void MSUB()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found");
                return;
            }

            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int a) || a >= allocated.Length || a < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int b) || b >= allocated.Length || b < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            double sum = allocated[a] - allocated[b];
            Console.WriteLine(sum);
        }
        public void MMUL()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found!");
                return;
            }

            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int a) || a >= allocated.Length || a < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int b) || b >= allocated.Length || b < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            double sum = allocated[a] * allocated[b];
            Console.WriteLine(sum);
        }
        public void MDIV()
        {
            if (allocated == null)
            {
                Console.WriteLine("memory not found");
                return;
            }

            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int a) || a >= allocated.Length || a < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int b) || b >= allocated.Length || b < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            if (allocated[b] == 0)
                {
                    Console.WriteLine("cant divide by zero");
                    return;
                }
            double sum = allocated[a] / allocated[b];
            Console.WriteLine(sum);
        }
        public void MMOD()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found!");
                return;
            }

            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int a) || a >= allocated.Length || a < 0)
            {
                Console.WriteLine("ERR: out of bounds");
                return;
            }
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int b) || b >= allocated.Length || b < 0)
            {
                Console.WriteLine($"ERR: out of bounds");
                return;
            }
            if (allocated[b] == 0)
                {
                    Console.WriteLine("cant divide by zero");
                    return;
                }
            double sum = allocated[a] % allocated[b];
            Console.WriteLine(sum);
        }
        public void MOV()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found!");
                return;
            }
            string pos;
            pos = Console.ReadLine();
            if (int.TryParse(pos, out int pos2) && pos2 >= 0 && pos2 < allocated.Length) {
                pointer = pos2;
            }
            else {
                Console.WriteLine("you went over the limit!");
                return;
            }
        }
        public void STRMOV()
        {
            if (allocatedstr == null)
            {
                Console.WriteLine("please allocate string memory!");
                return;
            }
            string strpos = Console.ReadLine();
            if (int.TryParse(strpos, out int strpos2) && strpos2 >= 0 && strpos2 < allocatedstr.Length) {
                strpointer = strpos2;
            }
            else {
                Console.WriteLine("you went over the limit or typed an invalid element!");
                return;
            }
        }

        public void SET()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory!");
                return;
            }
            double value2;
            string value = Console.ReadLine();
            if (!double.TryParse(value, out value2)) {
                Console.WriteLine("insert a number!");
                return;
            }
            if (pointer >= allocated.Length || pointer < 0)
            {
                Console.WriteLine("ERR: out of bounds!");
                return;
            }
            allocated[pointer] = value2;
        }
        public void STRSET()
        {
            if (allocatedstr == null)
            {
                Console.WriteLine("allocate string memory please!");
                return;
            }
            if (strpointer >= allocatedstr.Length || strpointer < 0)
            {
                Console.WriteLine("you went over the limit!");
                return;
            }
            string value = Console.ReadLine();
            allocatedstr[strpointer] = value;
        }

        public void GET()
        {
            if (allocated == null)
            {
                Console.WriteLine("memory not found!");
                return;
            }
            if (pointer >= allocated.Length || pointer < 0)
            {
                Console.WriteLine("you went over the limit!");
                return;
            }
            Console.WriteLine(allocated[pointer]);
        }
        public void STRGET() {
            if (allocatedstr == null)
            {
                Console.WriteLine("memory not found!");
                return;
            }
            if (strpointer >= allocatedstr.Length || strpointer < 0)
            {
                Console.WriteLine("you went over the limit!");
                return;
            }
            Console.WriteLine(allocatedstr[strpointer]);
        }
        public void IFNUM()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double a2, b2;
            if (!double.TryParse(a, out a2) || !double.TryParse(b, out b2)) {
                Console.WriteLine("insert a number!");
                return;
            }
            if (a2 == b2)
            {
                Console.WriteLine("Equal!");
            }
            else if (a2 != b2)
            {
                Console.WriteLine("Not Equal!");
            }
            else
            {
                Console.WriteLine("Unknown Error!");
                return;
            }
        }
        public void IFSTR()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("A and B are the same string");
            }
            else if (a != b)
            {
                Console.WriteLine("A and B arent equal strings");
            }
            else
            {
                Console.WriteLine("Unknown Error!");
                return;
            }
        }
        public void MIN()
        {
            if (allocated == null)
            {
                Console.WriteLine("no memory found!");
                return;
            }
            int condition = int.Parse(Console.ReadLine());
            if (condition >= allocated.Length || condition < 0)
            {
                Console.WriteLine("ERR: Out Of Bounds!");
                return;
            }
            for (int i = 0; i < condition; i++)
            {
                Console.WriteLine(allocated[i]);
            }
        }
        public void SAVE()
        {
            if (allocated == null)
            {
                Console.WriteLine("nothing to save");
                return;
            }
            string input = Console.ReadLine();
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/persistentmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            long size = new System.IO.FileInfo(FilePath).Length;
            if (size == 0)
            {
                System.IO.File.WriteAllText(FilePath, input + Environment.NewLine);
            }
            if (size > 0)
            {
                System.IO.File.AppendAllText(FilePath, input + Environment.NewLine);
            }
        }
        public void STRSAVE()
        {
            if (allocatedstr == null)
            {
                Console.WriteLine("nothing to save");
                return;
            }
            string input = Console.ReadLine();
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/stringmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            long size = new System.IO.FileInfo(FilePath).Length;
            if (size == 0)
            {
                System.IO.File.WriteAllText(FilePath, input + Environment.NewLine);
            }
            if (size > 0)
            {
                System.IO.File.AppendAllText(FilePath, input + Environment.NewLine);
            }
        }
        public void MSTRSAVE()
        {
            if (allocatedstr == null)
            {
                Console.WriteLine("nothing to save");
                return;
            }
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/mstringmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            long size = new System.IO.FileInfo(FilePath).Length;

            for (int i = 0; i < allocatedstr.Length; i++)
            {
                if (!string.IsNullOrEmpty(allocatedstr[i]))
                {
                    string thing1 = allocatedstr[i];
                    System.IO.File.AppendAllText(FilePath, thing1 + Environment.NewLine);
                }
            }


        }
        public void MSAVE()
        {
            if (allocated == null)
            {
                Console.WriteLine("nothing to save");
                return;
            }
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/mpersistentmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            long size = new System.IO.FileInfo(FilePath).Length;

            for (int i = 0; i < allocated.Length; i++)
            {
                if (allocated[i] != 0)
                {
                    double thing1 = allocated[i];
                    System.IO.File.AppendAllText(FilePath, thing1 + Environment.NewLine);
                }
            }
        }
        public void MLOAD()
        {
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/mpersistentmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            Console.WriteLine("this will wipe your numbers in memory. are you sure you wish to continue? (Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
            {
                allocated = Array.ConvertAll(File.ReadAllLines(FilePath), double.Parse);
            }
            else if (ans == "N" || ans == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Unknown Error!");
                return;
            }
        }
        public void MSTRLOAD()
        {
            string FolderPath = "/storage/emulated/0/Download/simplecpu";
            string FilePath = "/storage/emulated/0/Download/simplecpu/mstringmemory.txt";
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
            if (!System.IO.File.Exists(FilePath))
            {
                using (var fs = System.IO.File.Create(FilePath)) { }
            }
            Console.WriteLine("this will wipe your strings in memory. are you sure you wish to continue? (Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
            {
                allocatedstr = File.ReadAllLines(FilePath);
            }
            else if (ans == "N" || ans == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Unknown Error!");
                return;
            }
        }
        public void SHOWOPCODES() {
    Console.WriteLine("0x001 = move your pointer across memory");
    Console.WriteLine("0x002 = arithmetic addition");
    Console.WriteLine("0x003 = arithmetic subtraction");
    Console.WriteLine("0x004 = arithmetic multiplication");
    Console.WriteLine("0x005 = arithmetic division");
    Console.WriteLine("0x006 = arithmetic modulos");
    Console.WriteLine("0x022 = arithmetic addition using memory slots");
    Console.WriteLine("0x023 = arithmetic subtraction using memory slots");
    Console.WriteLine("0x024 = arithmetic multiplication using memory slots");
    Console.WriteLine("0x025 = arithmetic division using memory slots");
    Console.WriteLine("0x026 = arithmetic modulos using memory slots");
    Console.WriteLine("0x010 = allocate number memory");
    Console.WriteLine("0x060 = allocate string memory");
    Console.WriteLine("0x030 = set cell you're on to certain value");
    Console.WriteLine("0x031 = show the contents of the cell you're on");
    Console.WriteLine("0x011 = print string from console");
    Console.WriteLine("0x012 = print integer from console");
    Console.WriteLine("0x013 = print double from console");
    Console.WriteLine("0x061 = move string pointer across string memory");
    Console.WriteLine("0x062 = set string cell you're on to certain value");
    Console.WriteLine("0x063 = show string cell you're on");
    Console.WriteLine("0x050 = if numbers are equal or not");
    Console.WriteLine("0x051 = if strings are equal or not");
    Console.WriteLine("0x055 = print memory cells up to given index");
    Console.WriteLine("0x095 = save current input to persistent memory");
    Console.WriteLine("0x096 = save numeric memory to persistent memory");
    Console.WriteLine("0x097 = save string memory to persistent memory");
    Console.WriteLine("0x098 = save full string memory to persistent memory");
    Console.WriteLine("0x099 = load numeric memory from persistent memory");
    Console.WriteLine("0x0100 = load string memory from persistent memory");
}
        public void RUN()
        {
            while (true)
            {
                Console.WriteLine("insert opcode (0x000 to exit and 0x999 to show all opcodes): ");
                string opcodemain = Console.ReadLine();
                if (string.IsNullOrEmpty(opcodemain))
                {
                    Console.WriteLine("Nothing Typed. Type An Opcode!");
                    continue;
                }
                if (opcodemain == "0x000")
                {
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                }
                else if (opcodemain == "0x001")
                {
                    MOV();
                }
                else if (opcodemain == "0x002")
                {
                    ADD();
                }
                else if (opcodemain == "0x003")
                {
                    SUB();
                }
                else if (opcodemain == "0x010")
                {
                    ALCNUM();
                }
                else if (opcodemain == "0x004")
                {
                    MUL();
                }
                else if (opcodemain == "0x005")
                {
                    DIV();
                }
                else if (opcodemain == "0x006")
                {
                    MOD();
                }
                else if (opcodemain == "0x011")
                {
                    PST();
                }
                else if (opcodemain == "0x012")
                {
                    PIN();
                }
                else if (opcodemain == "0x013")
                {
                    PDB();
                }
                else if (opcodemain == "0x022")
                {
                    MADD();
                }
                else if (opcodemain == "0x030")
                {
                    SET();
                }
                else if (opcodemain == "0x031")
                {
                    GET();
                }
                else if (opcodemain == "0x023")
                {
                    MSUB();
                }
                else if (opcodemain == "0x024")
                {
                    MMUL();
                }
                else if (opcodemain == "0x025")
                {
                    MDIV();
                }
                else if (opcodemain == "0x026")
                {
                    MMOD();
                }
                else if (opcodemain == "0x050")
                {
                    IFNUM();
                }
                else if (opcodemain == "0x051")
                {
                    IFSTR();
                }
                else if (opcodemain == "0x060")
                {
                    ALCSTR();
                }
                else if (opcodemain == "0x061")
                {
                    STRMOV();
                }
                else if (opcodemain == "0x062")
                {
                    STRSET();
                }
                else if (opcodemain == "0x063") {
                    STRGET();
                }
                else if (opcodemain == "0x055")
                {
                    MIN();
                }
                else if (opcodemain == "0x095")
                {
                    SAVE();
                }
                else if (opcodemain == "0x096")
                {
                    MSAVE();
                }
                else if (opcodemain == "0x097")
                {
                    STRSAVE();
                }
                else if (opcodemain == "0x098")
                {
                    MSTRSAVE();
                }
                else if (opcodemain == "0x099")
                {
                    MLOAD();
                }
                else if (opcodemain == "0x0100")
                {
                    MSTRLOAD();
                }
                else if (opcodemain == "0x999")
                {
                    SHOWOPCODES();
                }
                else {
                    Console.WriteLine("Unknown Opcode!");
                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        CPUIns CI = new CPUIns();
        CI.RUN();
    }
}