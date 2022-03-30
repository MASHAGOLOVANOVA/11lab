using System;
using System.Collections;
using System.Collections.Generic;
using laba10;
using System.Diagnostics;
namespace laba11csharp
{
    class Program
    {
        static public void AllOrganisationsInSortedList(SortedList list) //для поиска всех организаций
        {
            int count = 0;
            for (int i =0; i<list.Count; i++)
            {
                if (list.GetByIndex(i) is Organisation)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"{count} количество организаций в коллекции");
        }

        static public void AllOrganisationsInList(List<Organisation> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Organisation)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"{count} количество организаций в коллекции");
        }

        static public void AllShipbuildingCompaniesInSortedList(SortedList list) // для того чтобы написать все судостроительные компании
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list.GetByIndex(i) is Bibliothek)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"{count} количество библиотек в коллекции");
        }


        static public void AllShipbuildingCompaniesInList(List<Organisation> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Bibliothek)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"{count} количество Bibliothek в коллекции");
        }

        static public void EverythingInSortedList(SortedList list) //для того чтобы вычислить, какого типа в массиве больше всего
        {
            
            string[] list_of_things = new string[5] { "Судостроительные компании", "Заводы", "Организации", "Библиотеки", "Страховые компании" };
            int[] list_of_values = new int[5] { 0,0,0,0,0};

            for (int i = 0; i < list.Count; i++)
            {
                if (list.GetByIndex(i) is ShipbuildingCompany)
                {
                    list_of_values[0] +=1 ;
                }
                if (list.GetByIndex(i) is Organisation)
                {
                    list_of_values[2] += 1;
                }
                if (list.GetByIndex(i) is Bibliothek)
                {
                    list_of_values[3] += 1;
                }
                if (list.GetByIndex(i) is InsuranceCompany)
                {
                    list_of_values[4] += 1;
                }
                if (list.GetByIndex(i) is Plant)
                {
                    list_of_values[1] += 1;
                }
            }

            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{list_of_things[i]} существуют в количестве {list_of_values[i]}");

        }

        static public void EverythingInList(List<Organisation> list)
        {
            string[] list_of_things = new string[5] { "Судостроительные компании", "Заводы", "Организации", "Библиотеки", "Страховые компании" };
            int[] list_of_values = new int[5] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is ShipbuildingCompany)
                {
                    list_of_values[0] += 1;
                }
                if (list[i] is Organisation)
                {
                    list_of_values[2] += 1;
                }
                if (list[i] is Bibliothek)
                {
                    list_of_values[3] += 1;
                }
                if (list[i] is InsuranceCompany)
                {
                    list_of_values[4] += 1;
                }
                if (list[i] is Plant)
                {
                    list_of_values[1] += 1;
                }
            }

            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{list_of_things[i]} существуют в количестве {list_of_values[i]}");

        }

        static public SortedList CloneList(SortedList list) //для клонирования массива
        {
            SortedList clone_list = new SortedList();
            for (int i=0; i<list.Count; i++)
            {
                if (list.GetByIndex(i) is ShipbuildingCompany)
                {
                    clone_list.Add(list.GetKey(i), ((ShipbuildingCompany)list.GetByIndex(i)).Clone());
                }
                else
                if (list.GetByIndex(i) is Bibliothek)
                {
                    clone_list.Add(list.GetKey(i), ((Bibliothek)list.GetByIndex(i)).Clone());
                }
                else
                if (list.GetByIndex(i) is InsuranceCompany)
                {
                    clone_list.Add(list.GetKey(i), ((InsuranceCompany)list.GetByIndex(i)).Clone());
                }
                else
                if (list.GetByIndex(i) is Plant)
                {
                    clone_list.Add(list.GetKey(i), ((Plant)list.GetByIndex(i)).Clone());
                }
                else
                if (list.GetByIndex(i) is Organisation)
                {
                    clone_list.Add(list.GetKey(i), ((Organisation)list.GetByIndex(i)).Clone());
                }
            }
            return clone_list;
        }

        static public List<Organisation> CloneOrganisationList(List<Organisation> list)
        {
            List<Organisation> clone_list = new List<Organisation>();
            foreach (var elem in list)
            {
                if (elem is ShipbuildingCompany)
                {
                    clone_list.Add((ShipbuildingCompany)elem.Clone());
                }
                if (elem is Organisation)
                {
                    clone_list.Add((Organisation)elem.Clone());
                }
                if (elem is Bibliothek)
                {
                    clone_list.Add((Bibliothek)elem.Clone());
                }
                if (elem is InsuranceCompany)
                {
                    clone_list.Add((InsuranceCompany)elem.Clone());
                }
                if (elem is Plant)
                {
                    clone_list.Add((Plant)elem.Clone());
                }
            }
            return clone_list;
        }


        static void Main(string[] args)
        {
            Queue<Bibliothek> org_queue = new Queue<Bibliothek>();
            Queue<string> string_org_qeue = new Queue<string>();
            Bibliothek first_in_queue = new Bibliothek();
            Dictionary<Organisation, Bibliothek> orgDictionary = new Dictionary<Organisation, Bibliothek>();
            Dictionary<string, Bibliothek> stringDictionary = new Dictionary<string, Bibliothek>();
            Bibliothek last_in_dict = new Bibliothek();
            List< Organisation > organisation_list= new List<Organisation>();
            InsuranceCompany elemInsuranceCompany = new InsuranceCompany();
            Plant elemPlant = new Plant();
            Bibliothek elemBibliothek = new Bibliothek();
            ShipbuildingCompany elemShipbuildingCompany = new ShipbuildingCompany();
            Organisation elemOrganisation = new Organisation();
            int i = 0;
            Random rnd = new Random();
            SortedList main_list = new SortedList();
            Bibliothek central = new Bibliothek();
            for (i = 0; i < main_list.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", main_list.GetKey(i), main_list.GetByIndex(i));
            }
            Console.WriteLine();
            int number = 0;
            bool isRight = true;
            do
            {
                do
                {
                    number = InputOutputClass.MainInput();
                    if (number == 0)
                        isRight = false;
                } while (!isRight);
                switch (number)
                {
                    case 1:

                        {
                            int numberOfOperationWithSortedList = 0;
                            do
                            {
                                do
                                {
                                    numberOfOperationWithSortedList = InputOutputClass.OperationsInput12();
                                    if (numberOfOperationWithSortedList == 0)
                                        isRight = false;
                                } while (!isRight);
                                switch (numberOfOperationWithSortedList)
                                {
                                    case 1:
                                        {
                                            main_list = new SortedList();
                                            for (i = 0; i < 1000; i++)
                                            {
                                                int variant = rnd.Next(1, 5);
                                                if (variant == 1)
                                                {
                                                    elemInsuranceCompany.Init();
                                                    main_list.Add(i+1, elemInsuranceCompany);
                                                }
                                                if (variant == 2)
                                                {
                                                    elemPlant.Init();
                                                    main_list.Add(i+1, elemPlant);
                                                }
                                                if (variant == 3)
                                                {
                                                    elemBibliothek.Init();
                                                    main_list.Add(i+1, elemBibliothek);
                                                }
                                                if (variant == 4)
                                                {
                                                    elemShipbuildingCompany.Init();
                                                    main_list.Add(i+1, elemShipbuildingCompany);
                                                }

                                                if (variant == 5)
                                                {
                                                    elemOrganisation.Init();
                                                    main_list.Add(i+1, elemOrganisation);
                                                }
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите элемент, который хотите добавить: ");
                                            string variant = Console.ReadLine();
                                            main_list.Add(main_list.Count, variant);
                                            Console.WriteLine($"Он был добавлен по индексу {main_list.Count}");
                                            Console.WriteLine("Введите ключ элемента, который хотите удалить: ");
                                            int key = -1;
                                            string keyString = "";
                                            do
                                            {
                                                keyString = Console.ReadLine();
                                                if (InputOutputClass.LightCheck(keyString) > 0)
                                                    key = int.Parse(keyString);
                                            } while (InputOutputClass.LightCheck(keyString) < 0);
                                            if (main_list.Contains(key-1))
                                                main_list.Remove(key-1);
                                            else
                                                Console.WriteLine("Элемента с таким ключом нет в коллекции");
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (main_list != null)
                                                AllOrganisationsInSortedList(main_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 4:
                                        {
                                            if (main_list != null)
                                                AllShipbuildingCompaniesInSortedList(main_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 5:
                                        {
                                            if (main_list != null)
                                                EverythingInSortedList(main_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 6:
                                        {
                                            if (main_list.Count>1)
                                            { SortedList clon_list = new SortedList();
                                                clon_list = CloneList(main_list);
                                                Console.WriteLine("Клонирование прошло успешно");
                                                for (i = 0; i < 10; i++)
                                                    Console.WriteLine(main_list.GetByIndex(i));
                                                for (i = 0; i < 10; i++)
                                                    Console.WriteLine(clon_list.GetByIndex(i));
                                            }
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.WriteLine("Отсортировано");
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("Введите ключ элемента, который хотите найти: ");
                                            int key = -1;
                                            string keyString = "";
                                            do
                                            {
                                                keyString = Console.ReadLine();
                                                if (InputOutputClass.LightCheck(keyString) > 0)
                                                    key = int.Parse(keyString);
                                            } while (InputOutputClass.LightCheck(keyString) < 0);
                                            if (main_list.Contains(key))
                                            {
                                                if (main_list[key] is ShipbuildingCompany)
                                                {
                                                    Console.WriteLine((ShipbuildingCompany)main_list[key]);
                                                }
                                                if (main_list[key] is Organisation)
                                                {
                                                    Console.WriteLine((Organisation)main_list[key]);
                                                }
                                                if (main_list[key] is Bibliothek)
                                                {
                                                    Console.WriteLine((Bibliothek)main_list[key]);
                                                }
                                                if (main_list[key] is InsuranceCompany)
                                                {
                                                    Console.WriteLine((InsuranceCompany)main_list[key]);
                                                }
                                                if (main_list[key] is Plant)
                                                {
                                                    Console.WriteLine((Plant)main_list[key]);
                                                }
                                            }
                                            else
                                                Console.WriteLine("Элемента с таким ключ нет в коллекции");
                                            break;
                                        }
                                }
                            } while (numberOfOperationWithSortedList != 9);

                            break;

                        }
                    case 2:
                        {
                            int numberOfOperationWithList = 0;
                            do
                            {
                                do
                                {
                                    numberOfOperationWithList = InputOutputClass.OperationsInput12();
                                    if (numberOfOperationWithList == 0)
                                        isRight = false;
                                } while (!isRight);
                                switch (numberOfOperationWithList)
                                {
                                    case 1:
                                        {
                                            organisation_list = new List<Organisation>();
                                            for (i = 0; i < 1000; i++)
                                            {
                                                int variant = rnd.Next(1, 5);
                                                if (variant == 1)
                                                {
                                                    InsuranceCompany elemInsurCompany = new InsuranceCompany();
                                                    elemInsurCompany.Init();
                                                    organisation_list.Add(elemInsurCompany);
                                                }
                                                if (variant == 2)
                                                {
                                                    Plant elPlant = new Plant();
                                                    elPlant.Init();
                                                    organisation_list.Add(elPlant);
                                                }
                                                if (variant == 3)
                                                {
                                                    Bibliothek elBibliothek = new Bibliothek();
                                                    elBibliothek.Init();
                                                    organisation_list.Add(elBibliothek);
                                                }
                                                if (variant == 4)
                                                {
                                                    ShipbuildingCompany elShipbuildingCompany = new ShipbuildingCompany();
                                                    elShipbuildingCompany.Init();
                                                    organisation_list.Add(elShipbuildingCompany);
                                                }

                                                if (variant == 5)
                                                {
                                                    Organisation elOrganisation = new Organisation();
                                                    elOrganisation.Init();
                                                    organisation_list.Add(elOrganisation);
                                                }
                                            }
                                                break;
                                        }
                                    case 2:
                                        {
                                            if (organisation_list.Count > 0)
                                            {
                                                Console.WriteLine("Добавим случайно созданный элемент типа организация");
                                                Organisation org = new Organisation();
                                                org.Init();
                                                Console.WriteLine(org);
                                                organisation_list.Add(org);
                                                Console.WriteLine($"Он был добавлен по индексу {organisation_list.Count}");
                                                Console.WriteLine("Введите номер элемента, который хотите удалить: ");
                                                int key = -1;
                                                string keyString = "";
                                                do
                                                {
                                                    keyString = Console.ReadLine();
                                                    if (InputOutputClass.Check(keyString, 0, organisation_list.Count + 1))
                                                        key = int.Parse(keyString);
                                                    else Console.WriteLine("Попробуйте снова");
                                                } while (!InputOutputClass.Check(keyString, 0, organisation_list.Count + 1));
                                                Console.WriteLine($"{organisation_list[key]} был УДАЛЕН");
                                                organisation_list.RemoveAt(key);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (organisation_list.Count>0)
                                                AllOrganisationsInList(organisation_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 4:
                                        {
                                            if (organisation_list.Count > 0)
                                                AllShipbuildingCompaniesInList(organisation_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 5:
                                        {
                                            if (organisation_list.Count > 0)
                                                EverythingInList(organisation_list);
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 6:
                                        {
                                            if (organisation_list.Count > 0)
                                            {
                                                List<Organisation> clon_list = new List<Organisation>();
                                                clon_list = CloneOrganisationList(organisation_list);
                                                Console.WriteLine("Клонирование прошло успешно");
                                            }
                                            else
                                                Console.WriteLine("ПУСТО");
                                            break;
                                        }
                                    case 7:
                                        {
                                            if (organisation_list.Count > 1)
                                            {
                                                for (i = 0; i < 10; i++)
                                                    Console.WriteLine(organisation_list[i]);
                                                Console.WriteLine();
                                                organisation_list.Sort();
                                                for (i = 0; i < 10; i++)
                                                    Console.WriteLine(organisation_list[i]);
                                            }
                                            break;
                                        }
                                    case 8:
                                        {

                                            Console.WriteLine("Введите ключ элемента, который хотите найти: ");
                                            int key = -1;
                                            string keyString = "";
                                            do
                                            {
                                                keyString = Console.ReadLine();
                                                if (InputOutputClass.Check(keyString, 0, organisation_list.Count + 1))
                                                    key = int.Parse(keyString);
                                            } while (!InputOutputClass.Check(keyString, 0, organisation_list.Count + 1));

                                            if (organisation_list[key] is ShipbuildingCompany)
                                                {
                                                    Console.WriteLine((ShipbuildingCompany)organisation_list[key]);
                                                }
                                            else
                                                
                                                if (organisation_list[key] is Bibliothek)
                                                {
                                                Console.WriteLine((Bibliothek)organisation_list[key]);
                                                }
                                            else
                                                if (organisation_list[key] is InsuranceCompany)
                                                {
                                                Console.WriteLine((InsuranceCompany)organisation_list[key]);
                                                }
                                            else
                                                if (organisation_list[key] is Plant)
                                                {
                                                Console.WriteLine((Plant)organisation_list[key]);
                                                }
                                            else
                                            if (organisation_list[key] is Organisation)
                                            {
                                                Console.WriteLine(organisation_list[key]);
                                            }

                                            break;
                                        }
                                }

                            } while (numberOfOperationWithList != 9);

                            break;
                        }
                    case 3:
                        {
                            int numberOfOperationWithTestCollections = 0;
                            do
                            {
                                do
                                {
                                    numberOfOperationWithTestCollections = InputOutputClass.OperationsInput3();
                                    if (numberOfOperationWithTestCollections == 0)
                                        isRight = false;
                                } while (!isRight);
                                switch (numberOfOperationWithTestCollections)
                                {
                                    case 1:
                                        {


                                            for (i = 0; i < 1000; i++)
                                            {
                                                elemBibliothek.Init();
                                                org_queue.Enqueue(elemBibliothek);
                                                string_org_qeue.Enqueue(elemBibliothek.ToString());
                                                orgDictionary.Add(elemBibliothek.BaseOrganisation(), elemBibliothek);
                                                stringDictionary.Add(elemBibliothek.ToString(), elemBibliothek);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Добавим последний элемент в коллекции");
                                            elemBibliothek.Init();
                                            Console.WriteLine(elemBibliothek);
                                            org_queue.Enqueue(elemBibliothek);
                                            string_org_qeue.Enqueue(elemBibliothek.ToString());
                                            orgDictionary.Add(elemBibliothek.BaseOrganisation(), elemBibliothek);
                                            stringDictionary.Add(elemBibliothek.ToString(), elemBibliothek);
                                            int sign = 0;
                                            string choise;
                                            do
                                            {
                                                Console.WriteLine("Удалим первый элемент в коллекциях 1 - да, 2 - нет");
                                                choise = Console.ReadLine();
                                                if (InputOutputClass.Check(choise, 0, 3))
                                                    sign = int.Parse(choise);
;                                            }
                                            while (sign==0);
                                            switch(sign)
                                            {
                                                case 1:
                                                    {
                                                        Bibliothek elemForRemove = org_queue.Peek();
                                                        org_queue.Dequeue();
                                                        string_org_qeue.Dequeue();
                                                        orgDictionary.Remove(elemForRemove.BaseOrganisation());
                                                        stringDictionary.Remove(elemForRemove.ToString());
                                                        break;
                                                    }
                                            }
                                           
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (org_queue.Count>0)
                                            {
                                                Stopwatch firstInOrgQueue = new Stopwatch();
                                                Stopwatch firstInStringQueue = new Stopwatch();
                                                Stopwatch firstInOrgDict = new Stopwatch();
                                                Stopwatch firstInStringDict = new Stopwatch();
                                                Stopwatch lastInOrgQueue = new Stopwatch();
                                                Stopwatch lastInStringQueue = new Stopwatch();
                                                Stopwatch lastInOrgDict = new Stopwatch();
                                                Stopwatch lastInStringDict = new Stopwatch();
                                                Stopwatch centralElementInOrgQueue = new Stopwatch();
                                                Stopwatch centralElementInStringQueue = new Stopwatch();
                                                Stopwatch centralElementInOrgDict = new Stopwatch();
                                                Stopwatch centralElementInStringDict = new Stopwatch();
                                                Stopwatch noElementInOrgQueue = new Stopwatch();
                                                Stopwatch noElementInStringQueue = new Stopwatch();
                                                Stopwatch noElementInOrgDict = new Stopwatch();
                                                Stopwatch noElementInStringDict = new Stopwatch();

                                                first_in_queue = (Bibliothek)org_queue.Peek().Clone();
                                                Bibliothek[] listForElements = new Bibliothek[org_queue.Count];
                                                listForElements = org_queue.ToArray();
                                                for (int j = 0; j < org_queue.Count; j++)
                                                {
                                                    if (org_queue.Count % 2 != 0)
                                                        if (j == org_queue.Count / 2)
                                                            central = (Bibliothek)listForElements[j].Clone();
                                                    if (j == org_queue.Count - 1)
                                                        last_in_dict = (Bibliothek)listForElements[j].Clone();
                                                }
                                                Bibliothek noElement = new Bibliothek();
                                                do
                                                {
                                                    noElement.Init();
                                                }
                                                while (org_queue.Contains(noElement));

                                                firstInOrgQueue.Start();
                                                org_queue.Contains(first_in_queue);
                                                firstInOrgQueue.Stop();
                                                string str = first_in_queue.ToString();
                                                firstInStringQueue.Start();
                                                string_org_qeue.Contains(str);
                                                firstInStringQueue.Stop();
                                                firstInOrgDict.Start();
                                                orgDictionary.ContainsValue(first_in_queue);
                                                firstInOrgDict.Stop();
                                                firstInStringDict.Start();
                                                stringDictionary.ContainsKey(str);
                                                firstInStringDict.Stop();

                                                lastInOrgQueue.Start();
                                                org_queue.Contains(last_in_dict);
                                                lastInOrgQueue.Stop();
                                                str = last_in_dict.ToString();
                                                lastInStringQueue.Start();
                                                string_org_qeue.Contains(str);
                                                lastInStringQueue.Stop();
                                                lastInOrgDict.Start();
                                                orgDictionary.ContainsValue(last_in_dict);
                                                lastInOrgDict.Stop();
                                                lastInStringDict.Start();
                                                stringDictionary.ContainsKey(str);
                                                lastInStringDict.Stop();
                                                if (org_queue.Count % 2 != 0)
                                                {
                                                    centralElementInOrgQueue.Start();
                                                    org_queue.Contains(central);
                                                    centralElementInOrgQueue.Stop();
                                                    str = central.ToString();
                                                    centralElementInStringQueue.Start();
                                                    string_org_qeue.Contains(str);
                                                    centralElementInStringQueue.Stop();
                                                    centralElementInOrgDict.Start();
                                                    orgDictionary.ContainsValue(central);
                                                    centralElementInOrgDict.Stop();
                                                    centralElementInStringDict.Start();
                                                    stringDictionary.ContainsKey(str);
                                                    centralElementInStringDict.Stop();
                                                }
                                                else Console.WriteLine("no CENTRAL ELEMENT");
                                                noElementInOrgQueue.Start();
                                                org_queue.Contains(noElement);
                                                noElementInOrgQueue.Stop();
                                                str = noElement.ToString();
                                                noElementInStringQueue.Start();
                                                string_org_qeue.Contains(str);
                                                noElementInStringQueue.Stop();
                                                noElementInOrgDict.Start();
                                                orgDictionary.ContainsValue(noElement);
                                                noElementInOrgDict.Stop();
                                                noElementInStringDict.Start();
                                                stringDictionary.ContainsKey(str);
                                                noElementInStringDict.Stop();

                                                Console.WriteLine($" Queue c элементами типа string");
                                                Console.WriteLine($"1 элемент - {firstInStringQueue.ElapsedTicks}");
                                                if (org_queue.Count % 2 != 0) Console.WriteLine($"центральный элемент - {centralElementInStringQueue.ElapsedTicks}");
                                                Console.WriteLine($"Последний элемент - {lastInStringQueue.ElapsedTicks}");
                                                Console.WriteLine($"Не существующий элемент - {noElementInStringQueue.ElapsedTicks}");
                                                Console.WriteLine();
                                                Console.WriteLine($" Queue c элементами типа bibliothek");
                                                Console.WriteLine($"1 элемент - {firstInOrgQueue.ElapsedTicks}");
                                                if (org_queue.Count % 2 != 0) Console.WriteLine($"центральный элемент - {centralElementInOrgQueue.ElapsedTicks}");
                                                Console.WriteLine($"Последний элемент - {lastInOrgQueue.ElapsedTicks}");
                                                Console.WriteLine($"Не существующий элемент - {noElementInOrgQueue.ElapsedTicks}");
                                                Console.WriteLine();
                                                Console.WriteLine($" SortedDictionary c элементами типа bibliothek, keys - Organisation");
                                                Console.WriteLine($"1 элемент - {firstInOrgDict.ElapsedTicks}");
                                                if (org_queue.Count % 2 != 0) Console.WriteLine($"центральный элемент - {centralElementInOrgDict.ElapsedTicks}");
                                                Console.WriteLine($"Последний элемент - {lastInOrgDict.ElapsedTicks}");
                                                Console.WriteLine($"Не существующий элемент - {noElementInOrgDict.ElapsedTicks}");
                                                Console.WriteLine();
                                                Console.WriteLine($" SortedDictionary c элементами типа bibliothek, keys - string");
                                                Console.WriteLine($"1 элемент - {firstInStringDict.ElapsedTicks}");
                                                if (org_queue.Count % 2 != 0) Console.WriteLine($"центральный элемент - {centralElementInStringDict.ElapsedTicks}");
                                                Console.WriteLine($"Последний элемент - {lastInStringDict.ElapsedTicks}");
                                                Console.WriteLine($"Не существующий элемент - {noElementInStringDict.ElapsedTicks}");
                                                Console.WriteLine();
                                            }
                                            else Console.WriteLine("Пусто");
                                            break;
                                        }
                                }

                            } while (numberOfOperationWithTestCollections != 5);
                            break;
                        }
                }

            } while (number != 4);
        }
    }
}  

