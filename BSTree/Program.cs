using System;
using System.Diagnostics;
using System.IO;
using System.Transactions;

namespace BSTree
{
    internal class Program
    {
        public static BSTree BSTree = new BSTree();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                string MyFolder = "";
                int FolderOpt = 0;
                int TextFileOpt = 0;
                string filesize = "";

                Console.WriteLine("Press 1: Ordered file");
                Console.WriteLine("Press 2: Random");
                FolderOpt = int.Parse(Console.ReadLine());

                if (FolderOpt == 1)
                {
                    MyFolder = "../ordered/";

                    Console.WriteLine("***Ordered has been selected***");
                    Console.WriteLine("Choose File size");
                    Console.WriteLine("Press 1 for 1000");
                    Console.WriteLine("Press 2 for 5000");
                    Console.WriteLine("Press 3 for 10000");
                    Console.WriteLine("Press 4 for 15000");
                    Console.WriteLine("Press 5 for 20000");
                    Console.WriteLine("Press 6 for 25000");
                    Console.WriteLine("Press 7 for 30000");
                    Console.WriteLine("Press 8 for 35000");
                    Console.WriteLine("Press 9 for 40000");
                    Console.WriteLine("Press 10 for 45000");
                    Console.WriteLine("Press 11 for 50000");

                }
                else if (FolderOpt == 2)
                {
                    MyFolder = "../random/";

                    Console.WriteLine("***Random has been selected***");
                    Console.WriteLine("Choose File size");
                    Console.WriteLine("Press 1 for 1000");
                    Console.WriteLine("Press 2 for 5000");
                    Console.WriteLine("Press 3 for 10000");
                    Console.WriteLine("Press 4 for 15000");
                    Console.WriteLine("Press 5 for 20000");
                    Console.WriteLine("Press 6 for 25000");
                    Console.WriteLine("Press 7 for 30000");
                    Console.WriteLine("Press 8 for 35000");
                    Console.WriteLine("Press 9 for 40000");
                    Console.WriteLine("Press 10 for 45000");
                    Console.WriteLine("Press 11 for 50000");

                }

                TextFileOpt = int.Parse(Console.ReadLine());
                Console.Clear();

                // Switch statements for file manipulation options from the first snippet
                switch (TextFileOpt)
                {
                    case 1:
                        filesize = "1000";
                        break;
                    case 2:
                        filesize = "5000";
                        break;
                    case 3:
                        filesize = "10000";
                        break;
                    case 4:
                        filesize = "15000";
                        break;
                    case 5:
                        filesize = "20000";
                        break;
                    case 6:
                        filesize = "25000";
                        break;
                    case 7:
                        filesize = "30000";
                        break;
                    case 8:
                        filesize = "35000";
                        break;
                    case 9:
                        filesize = "40000";
                        break;
                    case 10:
                        filesize = "45000";
                        break;
                    case 11:
                        filesize = "50000";
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid file size.");
                        continue;
                }
                string Myline;
                string MyFile = filesize + "-words.txt";
                string path = Path.Combine(MyFolder, MyFile);
                Stopwatch sw1 = Stopwatch.StartNew();

                using (StreamReader FileContent = new StreamReader(path))
                {
                    sw1.Start();
                    while ((Myline = FileContent.ReadLine()) != null)
                    {
                        if (!Myline.Contains("#") && !string.IsNullOrWhiteSpace(Myline))
                        {
                            BSTree.Add(Myline);
                        }
                    }
                }

                sw1.Stop();
                TimeSpan timeSpan1 = sw1.Elapsed;
                Console.WriteLine("Time taken to insert into");
                Console.WriteLine("Time: " + timeSpan1.ToString(@"mm\:ss\.fffffff") + "m:ss");
                Console.WriteLine();
                Console.WriteLine($"{filesize}-word.txt from {MyFolder} has been loaded");

                bool back = false;
                while (!back)
                {
                    
                    Console.WriteLine("Press 1: ToPrint Options");
                    Console.WriteLine("Press 2: Find Operation");
                    Console.WriteLine("Press 3: Delete");
                    Console.WriteLine("Press 4: Functionally Test");
                    Console.WriteLine("Press 5: Insert Operation");
                    Console.WriteLine("Press 0: Back to main menu");
                    int OperationOpt = int.Parse(Console.ReadLine());
                    Console.Clear();




                    switch (OperationOpt)
                    {
                        case 0:
                            back = true; break;
                        case 1:
                            int PrintOpt = 0;
                            Console.WriteLine("Press 1: Pre-Order");
                            Console.WriteLine("Press 2: In-Order");
                            Console.WriteLine("Press 3: Post-Order");
                            PrintOpt = int.Parse(Console.ReadLine());

                            Stopwatch sw = Stopwatch.StartNew();

                            switch (PrintOpt)
                            {
                                case 1:
                                    Console.WriteLine(BSTree.PreOrder());
                                    Console.WriteLine("Tree depth " + BSTree.TreeDepth());
                                    break;
                                case 2:
                                    Console.WriteLine(BSTree.InOrder());
                                    Console.WriteLine("Tree depth " + BSTree.TreeDepth());
                                    break;
                                case 3:
                                    Console.WriteLine(BSTree.PostOrder());
                                    Console.WriteLine("Tree depth " + BSTree.TreeDepth());
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                            sw.Stop();
                            TimeSpan timespan = sw.Elapsed;
                            Console.WriteLine("***Time taken to perform print operation***");
                            Console.WriteLine("Time: " + timespan.ToString(@"mm\:ss\.fffffff") + "m:ss");
                            break;

                        case 2:
                            Stopwatch swFind = Stopwatch.StartNew();
                            string WordToSearch = "";
                            Console.WriteLine("Enter Word to search: ");
                            WordToSearch = Console.ReadLine();
                            swFind.Start();
                            Console.WriteLine(BSTree.Find(WordToSearch));
                            swFind.Stop();
                            TimeSpan timespanFind = swFind.Elapsed;
                            Console.WriteLine("***Time taken to perform find***");
                            Console.WriteLine("Time: " + timespanFind.ToString(@"mm\:ss\.fffffff") + "m:ss");
                            break;

                        case 3:
                            Stopwatch swDelete = Stopwatch.StartNew();
                            string WordToDelete = "";
                            Console.WriteLine("Enter Word to delete: ");
                            WordToDelete = Console.ReadLine();
                            swDelete.Start();
                            Console.WriteLine(BSTree.Remove(WordToDelete));
                            swDelete.Stop();
                            TimeSpan timespanDelete = swDelete.Elapsed;
                            Console.WriteLine("***Time taken to perform delete***");
                            Console.WriteLine("Time: " + timespanDelete.ToString(@"mm\:ss\.fffffff") + "m:ss");
                            break;

                        case 4:
                            Stopwatch swTest = Stopwatch.StartNew();
                            swTest.Start();
                            Console.WriteLine("Deleting Word(zu): ");
                            BSTree.Remove("zu");
                            Console.WriteLine("Will now find the word(zu)\n");
                            Console.WriteLine(BSTree.Find("zu"));
                            Console.WriteLine("Inserting Word/Words(The, Earth, Movement, AroundTheEarth, Grab, Pull, Enter)");

                            BSTree.Add("The");
                            BSTree.Add("Earth");
                            BSTree.Add("Movement");
                            BSTree.Add("AroundTheEarth");
                            BSTree.Add("Grab");
                            BSTree.Add("Pull");
                            BSTree.Add("Enter");

                            Console.WriteLine("Will now find the word(AroundTheEarth)\n");
                            Console.WriteLine(BSTree.Find("AroundTheEarth"));

                            swTest.Stop();
                            TimeSpan timeSpanTest = swTest.Elapsed;
                            Console.WriteLine("***Time taken to perform Functional Test***");
                            Console.WriteLine("Time: " + timeSpanTest.ToString(@"mm\:ss\.fffffff") + "m:ss");
                            break;

                        case 5:
                            Stopwatch swInsert = Stopwatch.StartNew();
                            Console.WriteLine("Enter word to insert: ");
                            string word = Console.ReadLine();
                            BSTree.Add(word);
                            Console.WriteLine("Word seccessfully added");
                            break;


                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    }
                }

                Console.WriteLine("Press 1 to continue with file size selection or 0 to exit the program");
                int optContinue = int.Parse(Console.ReadLine());
                if (optContinue == 0)
                {
                    exit = true;
                }
            }
        }
    }
